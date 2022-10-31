namespace Final_Computer_Science_Project
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.audioNameCheckList = new System.Windows.Forms.CheckedListBox();
            this.selectedAddButton = new System.Windows.Forms.Button();
            this.allAddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "These buttons use the top result in the search";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allAddButton);
            this.Controls.Add(this.selectedAddButton);
            this.Controls.Add(this.audioNameCheckList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox directoryTextBox;
        private Label label1;
        private Button searchButton;
        private CheckedListBox audioNameCheckList;
        private Button selectedAddButton;
        private Button allAddButton;
        private Label label2;
        private Button loginButton;
        private Button openButton;
        private Button clearButton;
    }
}