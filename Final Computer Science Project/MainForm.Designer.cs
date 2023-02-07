using System.Runtime.CompilerServices;

namespace Final_Computer_Science_Project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
      //  private void InitializeComponent(Color mcolor, Color bcolor)
        private void InitializeComponent()
        {
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.audioNameCheckList = new System.Windows.Forms.CheckedListBox();
            this.selectedAddButton = new System.Windows.Forms.Button();
            this.allAddButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.spotifyAccountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(49, 84);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(302, 23);
            this.directoryTextBox.TabIndex = 0;
            this.directoryTextBox.Text = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory to search:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(368, 84);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // audioNameCheckList
            // 
            this.audioNameCheckList.FormattingEnabled = true;
            this.audioNameCheckList.Location = new System.Drawing.Point(623, 22);
            this.audioNameCheckList.Name = "audioNameCheckList";
            this.audioNameCheckList.Size = new System.Drawing.Size(147, 400);
            this.audioNameCheckList.TabIndex = 4;
            // 
            // selectedAddButton
            // 
            this.selectedAddButton.Location = new System.Drawing.Point(49, 210);
            this.selectedAddButton.Name = "selectedAddButton";
            this.selectedAddButton.Size = new System.Drawing.Size(97, 61);
            this.selectedAddButton.TabIndex = 5;
            this.selectedAddButton.Text = "Search and add selected to playlist";
            this.selectedAddButton.UseVisualStyleBackColor = true;
            this.selectedAddButton.Click += new System.EventHandler(this.selectedAddButton_Click);
            // 
            // allAddButton
            // 
            this.allAddButton.Location = new System.Drawing.Point(152, 210);
            this.allAddButton.Name = "allAddButton";
            this.allAddButton.Size = new System.Drawing.Size(96, 61);
            this.allAddButton.TabIndex = 6;
            this.allAddButton.Text = "Search and add all to playlist";
            this.allAddButton.UseVisualStyleBackColor = true;
            this.allAddButton.Click += new System.EventHandler(this.allAddButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(49, 399);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(254, 210);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(96, 61);
            this.openButton.TabIndex = 11;
            this.openButton.Text = "Open selected with Spotify";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(542, 399);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(307, 399);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(75, 23);
            this.settingButton.TabIndex = 13;
            this.settingButton.Text = "Settings";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(356, 210);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(96, 61);
            this.exportButton.TabIndex = 14;
            this.exportButton.Text = "Export selected (text file of links)";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(49, 113);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(109, 23);
            this.browseButton.TabIndex = 15;
            this.browseButton.Text = "Browse local files";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // spotifyAccountLabel
            // 
            this.spotifyAccountLabel.AutoSize = true;
            this.spotifyAccountLabel.Location = new System.Drawing.Point(130, 403);
            this.spotifyAccountLabel.Name = "spotifyAccountLabel";
            this.spotifyAccountLabel.Size = new System.Drawing.Size(80, 15);
            this.spotifyAccountLabel.TabIndex = 16;
            this.spotifyAccountLabel.Text = "Not logged in";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spotifyAccountLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.allAddButton);
            this.Controls.Add(this.selectedAddButton);
            this.Controls.Add(this.audioNameCheckList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryTextBox);
            this.Name = "MainForm";
            this.Text = "Music Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        void UpdateColours()
        {
            searchButton.BackColor = bcolor;
            selectedAddButton.BackColor = bcolor;
            allAddButton.BackColor = bcolor;
            loginButton.BackColor = bcolor;
            openButton.BackColor = bcolor;
            clearButton.BackColor = bcolor;
            settingButton.BackColor = bcolor;
            exportButton.BackColor = bcolor;
            browseButton.BackColor = bcolor;
            this.BackColor = mcolor;
        }

        public TextBox directoryTextBox;
        public Label label1;
        public Button searchButton;
        public CheckedListBox audioNameCheckList;
        public Button selectedAddButton;
        public Button allAddButton;
        public Button loginButton;
        public Button openButton;
        public Button clearButton;
        public Button settingButton;
        public Button exportButton;
        private Button browseButton;
        private Label spotifyAccountLabel;
    }
}