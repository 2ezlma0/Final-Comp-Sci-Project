using Newtonsoft.Json.Linq;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Runtime.CompilerServices;

namespace Final_Computer_Science_Project
{
    public partial class Form1 : Form
    {
        public List<string> audioFilesNames = new List<string>();
        public List<string> searchedPaths = new List<string>();
        public bool loggedIn = false; //assume not logged in
        public static EmbedIOAuthServer _server;
        public static string authToken;
        public static string clientID = "2ec60cf076b4451598cf045659a32756";
        public static string clientSecret = "1e4d597acfbe4132a827c6c38b66619f"; //client id and secret for app i created at https://developer.spotify.com/dashboard/applications
        public static string playlistID;
        public static List<string> spotifySongLinks = new List<string>();
        public static SearchResponse result = new SearchResponse();
        public static bool noSearchResults = false; //assume there is search results

        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string path = directoryTextBox.Text;

            if (path == "") //if the textbox is empty, assume they want to search the entire c drive (or whatever their main drive's letter is), hopefully they put something in the box though because searching the whole c drive is very slow atm
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                path = drives[0].Name;
            }

            if (searchedPaths.Contains(path))
            {
                MessageBox.Show("Path has already been searched for");
            }
            else
            {
                searchedPaths.Add(path); //adds the path to a list of searched paths to not duplicate results in the checkedlist
                List<string> accessableDirectories = CheckAccessableDirectories(Directory.GetDirectories(path)); //first layer of subdirectories that are accessable
                List<string> audioFiles = new List<string>();
                List<string> directoriesToCheck = accessableDirectories; //sets first list to check the accessable directories already found on the first layer
                List<string> checkedDirectories = new List<string>(); //list to store the directories that have been checked and are accessable
                List<string> tempDirectories = new List<string>(); // list to store temporary directories to add to checked directories
                bool finished = false; //assume unfinished
                while (!finished)
                {
                    for (int i = 0; i < directoriesToCheck.Count; i++)
                    {
                        tempDirectories = CheckAccessableDirectories(Directory.GetDirectories(directoriesToCheck[i]));
                        if (tempDirectories.Count > 0)
                        {
                            for (int j = 0; j < tempDirectories.Count; j++)
                            {
                                checkedDirectories.Add(tempDirectories[j]);
                            }
                        }
                    }

                    if (checkedDirectories.Count == 0)
                    {
                        finished = true;
                    }
                    else
                    {
                        for (int j = 0; j < checkedDirectories.Count; j++)
                        {
                            accessableDirectories.Add(checkedDirectories[j]); //adds checked directories of the next layer in the accessible directories list to check for audio files
                        }
                        directoriesToCheck = checkedDirectories; //sets the directories to check the next layer in                    
                    }
                    checkedDirectories = new List<string>(); //clears checked directories for the next loop (.Clear doesnt work for some reason because uhhh c#)
                }

                for (int i = 0; i < accessableDirectories.Count; i++)
                    searchedPaths.Add(accessableDirectories[i]); //adds all the accessable directories to the list of searched paths as well to not duplicate results in the checkedlist

                audioFiles = AudioFileSearch(path, accessableDirectories);
                audioFilesNames = ExcessPathRemover(audioFiles);
                for (int i = 0; i < audioFilesNames.Count; i++)
                {
                    audioNameCheckList.Items.Add(audioFilesNames[i]);
                }
            }
        }

        private List<string> CheckAccessableDirectories(string[] directories)
        {
            List<string> accessableDirectories = new List<string>();
            bool accessable = false;
            for (int i = 0; i < directories.Length; i++)
            {
                accessable = false;

                try
                {
                    string[] temp = Directory.GetFiles(directories[i]);
                    if (temp != null) //checks if it can access files (and directories in the next try), if it cant read them the string array's value is null, therefore if it isnt then the directory is readable
                    {
                        accessable = true;
                    }
                }
                catch (UnauthorizedAccessException) //just in case it causes an error
                {

                }

                if (!accessable)
                {
                    try
                    {
                        string[] temp2 = Directory.GetDirectories(directories[i]);
                        if (temp2 != null)
                        {
                            accessable = true;
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {

                    }
                }

                //if (directories[i] == "C:\\Documents and Settings" || directories[i] == "C:\\System Volume Information")
                //   accessable = false;

                if (accessable) //if accessable has been set to true because files/directories have been read without an error, adds the directory to the list that will be returned when the function ends
                    accessableDirectories.Add(directories[i]);
            }

            return accessableDirectories;
        }

        private List<string> AudioFileSearch(string root, List<string> directories)
        {
            List<string> audioFiles = new List<string>();
            string[] tempFiles = Directory.GetFiles(root, "*.mp3", SearchOption.TopDirectoryOnly); //goes through the root folder for audio files
            if (tempFiles.Length > 0)
            {
                for (int i = 0; i < tempFiles.Length; i++)
                {
                    audioFiles.Add(tempFiles[i]);
                }
            }

            string[] tempFiles1 = Directory.GetFiles(root, "*.wav", SearchOption.TopDirectoryOnly);
            if (tempFiles1.Length > 0)
            {
                for (int i = 0; i < tempFiles1.Length; i++)
                {
                    audioFiles.Add(tempFiles1[i]);
                }
            }
            string[] tempFiles2 = Directory.GetFiles(root, "*.m4a", SearchOption.TopDirectoryOnly);
            if (tempFiles2.Length > 0)
            {
                for (int i = 0; i < tempFiles2.Length; i++)
                {
                    audioFiles.Add(tempFiles2[i]);
                }
            }

            for (int i = 0; i < directories.Count; i++) //goes through all the subdirectories from the root path (that have been checked that theyre readable) for audio files
            {
                string[] tempFiles3 = Directory.GetFiles(directories[i], "*.mp3", SearchOption.TopDirectoryOnly);
                if (tempFiles3.Length > 0)
                {
                    for (int j = 0; j < tempFiles3.Length; j++)
                    {
                        audioFiles.Add(tempFiles3[j]);
                    }
                }
                string[] tempFiles4 = Directory.GetFiles(directories[i], "*.wav", SearchOption.TopDirectoryOnly);
                if (tempFiles4.Length > 0)
                {
                    for (int j = 0; j < tempFiles4.Length; j++)
                    {
                        audioFiles.Add(tempFiles4[j]);
                    }
                }

                string[] tempFiles5 = Directory.GetFiles(directories[i], "*.m4a", SearchOption.TopDirectoryOnly);
                if (tempFiles5.Length > 0)
                {
                    for (int j = 0; j < tempFiles5.Length; j++)
                    {
                        audioFiles.Add(tempFiles5[j]);
                    }
                }
            }
            return audioFiles;
        }

        private List<string> ExcessPathRemover(List<string> files)
        {
            List<string> removedPaths = new List<string>();
            List<string> output = new List<string>();
            for(int i = 0; i < files.Count; i++)
            {
                string[] tempSplit = files[i].Split(@"\");
                if (!removedPaths.Contains(tempSplit[tempSplit.Length - 1])) //removes duplicates
                    removedPaths.Add(tempSplit[tempSplit.Length - 1]); //splits the line into substrings at the symbol '\', meaning the last substring will be the audio file without any of the path (e.g 'C:\\Users\test.wav' turns into 'test.wav')            
            }

            for (int j = 0; j < removedPaths.Count; j++)
            {
                if (!output.Contains(removedPaths[j].Remove(removedPaths[j].Length - 4))) //removes duplicates
                    output.Add(removedPaths[j].Remove(removedPaths[j].Length - 4)); //removes the file extension, they are all 4 characters (including the dot)
            }

            return output;
        }

        private async void selectedAddButton_Click(object sender, EventArgs e)
        {
            if (authToken == "" || authToken == null) //check if theyve logged into spotify, string should just be empty but check if its null just in case
            {
                MessageBox.Show("Please login with the login button below");
            }
            else if (audioNameCheckList.Items.Count == 0)
            {
                MessageBox.Show("Checklist empty, please search and find an audio file before you use this button");
            }
            else
            {
                var spotify = new SpotifyClient(authToken);
                List<string> checkedItems = new List<string>();
                for (int i = 0; i < audioNameCheckList.CheckedItems.Count; i++) //goes through the checked items and adds them to a list
                {
                    checkedItems.Add(audioNameCheckList.CheckedItems[i].ToString());
                }

                for (int i = 0; i < checkedItems.Count; i++)
                {
                    await SearchSongUri(checkedItems[i]); //searches all the songs that are checked, and adds them to the spotifySongLinks
                }

                if (spotifySongLinks.Count == 0)
                {
                    MessageBox.Show("Search return no spotify songs, please use different audio files");
                }
                else
                {
                    await CreatePlaylist(spotify, checkedItems[0]); //creates a playlist, uses the first song as the playlist name, also stores the playlistID
                    await AddSongsToPlaylist(spotify);
                    MessageBox.Show("Playlist created on your account");
                }
            }
        }

        private async void allAddButton_Click(object sender, EventArgs e)
        {
            if (authToken == "" || authToken == null) //check if theyve logged into spotify, string should just be empty but check if its null just in case
            {
                MessageBox.Show("Please login with the login button below");
            }
            else if (audioNameCheckList.Items.Count == 0)
            {
                MessageBox.Show("Checklist empty, please search and find an audio file before you use this button");
            }
            else
            {
                var spotify = new SpotifyClient(authToken);
                List<string> items = new List<string>();
                for (int i = 0; i < audioNameCheckList.Items.Count; i++) //goes through the items and adds them to a list
                {
                    items.Add(audioNameCheckList.Items[i].ToString());
                }

                for (int i = 0; i < items.Count; i++)
                {
                    await SearchSongUri(items[i]); //searches all the songs that are checked, and adds them to the spotifySongList
                }

                if (spotifySongLinks.Count == 0)
                {
                    MessageBox.Show("Search return no spotify songs, please use different audio files");
                }
                else
                {
                    await CreatePlaylist(spotify, items[0]); //creates a playlist, uses the first song as the playlist name, also stores the playlistID
                    await AddSongsToPlaylist(spotify);
                    MessageBox.Show("Playlist created on your account");
                }
            }
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            await Login();
        }

        private async void openButton_Click(object sender, EventArgs e)
        {
            if (audioNameCheckList.Text == "")
            {
                MessageBox.Show("Please check the song you want to open in spotify");
            }
            else
            {
                string selectedString = audioNameCheckList.Text;
                await SearchAndOpenSpotifyLink(selectedString);
            }
        }

        public static async Task Search(string searchTerm)
        {
            var config = SpotifyClientConfig.CreateDefault();

            var request = new ClientCredentialsRequest(clientID, clientSecret);
            var response = await new OAuthClient(config).RequestToken(request);

            var spotify = new SpotifyClient(config.WithToken(response.AccessToken));

            var searchRequest = new SearchRequest(SearchRequest.Types.Track, searchTerm);

            result = await spotify.Search.Item(searchRequest);
            if (result.Tracks.Items.Count == 0 || result.Tracks.Items.Count == null) //makes sure the search returned at least one track, check for null just in case
                noSearchResults = true;
        }

        public static async Task SearchAndOpenSpotifyLink(string searchTerm)
        {
            await Search(searchTerm);

            if (!noSearchResults)
            {
                string link = CreateSpotifyLink(result);

                Process.Start(new ProcessStartInfo(link) { UseShellExecute = true }); //new .net version needs this UseShellExecute thing (thanks stack overflow)
            }
            else
            {
                noSearchResults = false;
                MessageBox.Show("No results found for " + searchTerm);
            }
        }

        public static async Task SearchSongUri(string term)
        {
            await Search(term);
            if (!noSearchResults)
                spotifySongLinks.Add(result.Tracks.Items[0].Uri);
            else
                noSearchResults = false;
        }

        public static async Task CreatePlaylist(SpotifyClient spotify, string name)
        {
            var createRequest = new PlaylistCreateRequest(name);
            var currentUser = await spotify.UserProfile.Current(); //ONLY WORKS IF YOU ADD THE USER TO THE 'USERS AND DEVELOPERS' ON THE SPOTIFY DASHBOARD
            var createdPlaylist = await spotify.Playlists.Create(currentUser.Id, createRequest);
            playlistID = createdPlaylist.Id;
        }

        public static async Task AddSongsToPlaylist(SpotifyClient spotify)
        {
            PlaylistAddItemsRequest addItems = new PlaylistAddItemsRequest(spotifySongLinks);
            await spotify.Playlists.AddItems(playlistID, addItems);
        }

        public static async Task Login() //thanks to https://johnnycrazy.github.io/SpotifyAPI-NET/docs/authorization_code for this code
        {
            // Make sure "http://localhost:5000/callback" is in your spotify application as redirect uri!
            _server = new EmbedIOAuthServer(new Uri("http://localhost:5000/callback"), 5000);
            await _server.Start();

            _server.AuthorizationCodeReceived += OnAuthorizationCodeReceived;
            _server.ErrorReceived += OnErrorReceived;

            var request = new LoginRequest(_server.BaseUri, clientID, LoginRequest.ResponseType.Code)
            {
                Scope = new List<string> { Scopes.UserReadEmail, Scopes.PlaylistModifyPrivate, Scopes.PlaylistModifyPublic, Scopes.PlaylistReadCollaborative, Scopes.PlaylistReadPrivate, Scopes.UserReadPrivate, Scopes.AppRemoteControl, Scopes.UserLibraryRead, Scopes.UserLibraryModify } //what permissions to ask for
            };
            BrowserUtil.Open(request.ToUri());
        }

        public static async Task OnAuthorizationCodeReceived(object sender, AuthorizationCodeResponse response)
        {
            await _server.Stop();

            var config = SpotifyClientConfig.CreateDefault();
            var tokenResponse = await new OAuthClient(config).RequestToken(
              new AuthorizationCodeTokenRequest(
                clientID, clientSecret, response.Code, new Uri("http://localhost:5000/callback")
              )
            );

            authToken = tokenResponse.AccessToken; //saves access token
    }

        private static async Task OnErrorReceived(object sender, string error, string state)
        {
            MessageBox.Show($"Aborting authorization, error received: {error}");
            await _server.Stop();
        }

        public static string CreateSpotifyLink(SearchResponse result) //for some reason ExternalUrls doesnt let you get the original link (Dictionary<string, string> is weird) so we make it ourself using Href
        {
            string[] splithref = result.Tracks.Items[0].Href.Split("/");
            return "https://open.spotify.com/track/" + splithref[splithref.Length - 1];
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            audioNameCheckList.Items.Clear();
        }
    }
}