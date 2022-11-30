using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Final_Computer_Science_Project
{
    public partial class SettingsFormv2 : Form
    {
        public Color mcolor, bcolor;
        public int malpha, mred, mblue, mgreen, balpha, bred, bblue, bgreen;
        public List<string> extensions = new List<string>();

        public static string settingsConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "musicfinder.cfg");
        //config line index references:
        //0 = malpha
        //1 = mred
        //2 = mgreen
        //3 = mblue
        //4 = balpha
        //5 = bred
        //6 = bgreen
        //7 = bblue
        //8 = cclientID (configclientID)
        //9 = cclientSecret (configclientSecret)
        //10 = *.wav
        //11 = *.m4a
        //12 = *.mp3
        //any higher than this will be extra extentions for now
        //('!' at the end of extension to show it is checked)

        public SettingsFormv2()
        {
            MainForm _ = new MainForm();
            mcolor = _.mcolor;
            bcolor = _.bcolor;

            InitializeComponent();
            ChangeMColour();
            ChangeBColour();
            ReadAndAddExtensions();
        }

        private void bcolorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.AllowFullOpen = true;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                bcolor = dlg.Color;
            }

            ChangeBColour();

            string[] settings = File.ReadAllLines(settingsConfigPath);
            settings[4] = "balpha=" + bcolor.A.ToString();
            settings[5] = "bred=" + bcolor.R.ToString();
            settings[6] = "bgreen=" + bcolor.G.ToString();
            settings[7] = "bblue=" + bcolor.B.ToString();
            File.Delete(settingsConfigPath);
            File.WriteAllLines(settingsConfigPath, settings);

        }

        private void clientIDTextbox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void clientSecretTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateClientButton_Click(object sender, EventArgs e)
        {
            string[] settings = File.ReadAllLines(settingsConfigPath);
            if (clientIDTextbox.Text == "" || clientSecretTextbox.Text == "" || clientIDTextbox.Text == settings[8] || clientSecretTextbox.Text == settings[9])
            {
                MessageBox.Show("Textboxes left blank or one or more boxes unedited, no changes made");
            }
            else
            {
                settings[8] = clientIDTextbox.Text;
                settings[9] = clientSecretTextbox.Text;
                File.Delete(settingsConfigPath);
                File.WriteAllLines(settingsConfigPath, settings);
                MessageBox.Show("Updated");
            }
            
        }

        private void openSpotifyDashboardButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://developer.spotify.com/dashboard/applications") { UseShellExecute = true }); //new .net version needs this UseShellExecute thing (thanks stack overflow)
            MessageBox.Show("Create a new application and paste both the clientID and client secret into this application to make the creation of playlists work");
        }

        private void mcolorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.AllowFullOpen = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mcolor = dlg.Color;
            }

            ChangeMColour();

            string[] settings = File.ReadAllLines(settingsConfigPath);
            settings[0] = "malpha=" + mcolor.A.ToString();
            settings[1] = "mred=" + mcolor.R.ToString();
            settings[2] = "mgreen=" + mcolor.G.ToString();
            settings[3] = "mblue=" + mcolor.B.ToString();
            File.Delete(settingsConfigPath);
            File.WriteAllLines(settingsConfigPath, settings);
        }

        private void ReadAndAddExtensions()
        {
            string[] settings = File.ReadAllLines(settingsConfigPath);

            for (int i = 10; i < settings.Length; i++)
                extensions.Add(settings[i]);

            extensionsCheckedListBox.Items.Clear();

            for (int i = 0; i < extensions.Count; i++)
            {
                if (extensions[i][extensions[i].Length - 1] == '!')
                {
                    extensionsCheckedListBox.Items.Add(extensions[i].Split('!')[0]);
                    extensionsCheckedListBox.SetItemChecked(i, true);
                }
                else
                {
                    extensionsCheckedListBox.Items.Add(extensions[i]);
                }
            }
            UpdateClientTextboxes(settings);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            MainForm reset = new MainForm();
            reset.ResetConfigFile();
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] settings = File.ReadAllLines(settingsConfigPath);

            for(int i = 8; i < settings.Length; i++)
            {
                if (extensionsCheckedListBox.GetItemChecked(i - 8))
                    settings[i] = extensionsCheckedListBox.Items[i - 8] + "!";
                else
                    settings[i] = extensionsCheckedListBox.Items[i - 8].ToString();
            }

            File.Delete(settingsConfigPath);
            File.WriteAllLines(settingsConfigPath, settings);
        }

        private void addExtensionButton_Click(object sender, EventArgs e)
        {
            if (extensionTextBox.Text[0] != '.')
                MessageBox.Show("Please start the extension with a '.'");
            else
                extensionsCheckedListBox.Items.Add("*" + extensionTextBox.Text);

            string[] line = new string[] { "*" + extensionTextBox.Text };
            File.AppendAllLines(settingsConfigPath, line);
        }

        private void confirmExtensionsButton_Click(object sender, EventArgs e) //just in case it doesnt call checkedListBox1_SelectedIndexChanged (happens sometimes)
        {
            string[] settings = File.ReadAllLines(settingsConfigPath);

            for (int i = 8; i < settings.Length; i++)
            {
                if (extensionsCheckedListBox.GetItemChecked(i - 8))
                    settings[i] = extensionsCheckedListBox.Items[i - 8] + "!";
                else
                    settings[i] = extensionsCheckedListBox.Items[i - 8].ToString();
            }

            File.Delete(settingsConfigPath);
            File.WriteAllLines(settingsConfigPath, settings);
        }
    }
}
