namespace Final_Computer_Science_Project
{
    partial class SettingsFormv2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mcolorButton = new System.Windows.Forms.Button();
            this.bcolorButton = new System.Windows.Forms.Button();
            this.mainColorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonColorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.extensionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addExtensionButton = new System.Windows.Forms.Button();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.confirmExtensionsButton = new System.Windows.Forms.Button();
            this.clientSecretTextbox = new System.Windows.Forms.TextBox();
            this.clientIDTextbox = new System.Windows.Forms.TextBox();
            this.updateClientButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openSpotifyDashboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mcolorButton
            // 
            this.mcolorButton.Location = new System.Drawing.Point(12, 383);
            this.mcolorButton.Name = "mcolorButton";
            this.mcolorButton.Size = new System.Drawing.Size(173, 55);
            this.mcolorButton.TabIndex = 0;
            this.mcolorButton.Text = "Main Colour";
            this.mcolorButton.UseVisualStyleBackColor = true;
            this.mcolorButton.Click += new System.EventHandler(this.mcolorButton_Click);
            // 
            // bcolorButton
            // 
            this.bcolorButton.Location = new System.Drawing.Point(213, 383);
            this.bcolorButton.Name = "bcolorButton";
            this.bcolorButton.Size = new System.Drawing.Size(171, 55);
            this.bcolorButton.TabIndex = 1;
            this.bcolorButton.Text = "Button Colour";
            this.bcolorButton.UseVisualStyleBackColor = true;
            this.bcolorButton.Click += new System.EventHandler(this.bcolorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Close the settings window to apply these changes to the main window";
            // 
            // extensionsCheckedListBox
            // 
            this.extensionsCheckedListBox.FormattingEnabled = true;
            this.extensionsCheckedListBox.Location = new System.Drawing.Point(11, 38);
            this.extensionsCheckedListBox.Name = "extensionsCheckedListBox";
            this.extensionsCheckedListBox.Size = new System.Drawing.Size(145, 256);
            this.extensionsCheckedListBox.TabIndex = 3;
            this.extensionsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // addExtensionButton
            // 
            this.addExtensionButton.Location = new System.Drawing.Point(108, 300);
            this.addExtensionButton.Name = "addExtensionButton";
            this.addExtensionButton.Size = new System.Drawing.Size(48, 24);
            this.addExtensionButton.TabIndex = 4;
            this.addExtensionButton.Text = "Add";
            this.addExtensionButton.UseVisualStyleBackColor = true;
            this.addExtensionButton.Click += new System.EventHandler(this.addExtensionButton_Click);
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Location = new System.Drawing.Point(12, 300);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(91, 23);
            this.extensionTextBox.TabIndex = 5;
            this.extensionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(240, 38);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(144, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset Settings";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // confirmExtensionsButton
            // 
            this.confirmExtensionsButton.Location = new System.Drawing.Point(12, 329);
            this.confirmExtensionsButton.Name = "confirmExtensionsButton";
            this.confirmExtensionsButton.Size = new System.Drawing.Size(144, 45);
            this.confirmExtensionsButton.TabIndex = 7;
            this.confirmExtensionsButton.Text = "Confirm Checked Extensions";
            this.confirmExtensionsButton.UseVisualStyleBackColor = true;
            this.confirmExtensionsButton.Click += new System.EventHandler(this.confirmExtensionsButton_Click);
            // 
            // clientSecretTextbox
            // 
            this.clientSecretTextbox.Location = new System.Drawing.Point(240, 300);
            this.clientSecretTextbox.Name = "clientSecretTextbox";
            this.clientSecretTextbox.Size = new System.Drawing.Size(144, 23);
            this.clientSecretTextbox.TabIndex = 8;
            this.clientSecretTextbox.TextChanged += new System.EventHandler(this.clientSecretTextbox_TextChanged);
            // 
            // clientIDTextbox
            // 
            this.clientIDTextbox.Location = new System.Drawing.Point(240, 246);
            this.clientIDTextbox.Name = "clientIDTextbox";
            this.clientIDTextbox.Size = new System.Drawing.Size(144, 23);
            this.clientIDTextbox.TabIndex = 9;
            this.clientIDTextbox.TextChanged += new System.EventHandler(this.clientIDTextbox_TextChanged);
            // 
            // updateClientButton
            // 
            this.updateClientButton.Location = new System.Drawing.Point(240, 329);
            this.updateClientButton.Name = "updateClientButton";
            this.updateClientButton.Size = new System.Drawing.Size(144, 45);
            this.updateClientButton.TabIndex = 10;
            this.updateClientButton.Text = "Update Client ID and Secret";
            this.updateClientButton.UseVisualStyleBackColor = true;
            this.updateClientButton.Click += new System.EventHandler(this.updateClientButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "client ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "client secret";
            // 
            // openSpotifyDashboardButton
            // 
            this.openSpotifyDashboardButton.Location = new System.Drawing.Point(240, 158);
            this.openSpotifyDashboardButton.Name = "openSpotifyDashboardButton";
            this.openSpotifyDashboardButton.Size = new System.Drawing.Size(144, 57);
            this.openSpotifyDashboardButton.TabIndex = 13;
            this.openSpotifyDashboardButton.Text = "    Spotify Dashboard       (for setting up clientID and secret)";
            this.openSpotifyDashboardButton.UseVisualStyleBackColor = true;
            this.openSpotifyDashboardButton.Click += new System.EventHandler(this.openSpotifyDashboardButton_Click);
            // 
            // SettingsFormv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.openSpotifyDashboardButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateClientButton);
            this.Controls.Add(this.clientIDTextbox);
            this.Controls.Add(this.clientSecretTextbox);
            this.Controls.Add(this.confirmExtensionsButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(this.addExtensionButton);
            this.Controls.Add(this.extensionsCheckedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bcolorButton);
            this.Controls.Add(this.mcolorButton);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsFormv2";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        void ChangeBColour()
        {
            mcolorButton.BackColor = bcolor;
            bcolorButton.BackColor = bcolor;
            addExtensionButton.BackColor = bcolor;
            confirmExtensionsButton.BackColor = bcolor;
            resetButton.BackColor = bcolor;
            updateClientButton.BackColor = bcolor;
            openSpotifyDashboardButton.BackColor = bcolor;
        }

        void ChangeMColour()
        {
            this.BackColor = mcolor;
        }

        void UpdateClientTextboxes(string[] settings)
        {
            clientIDTextbox.Text = settings[8];
            clientSecretTextbox.Text = settings[9];
        }

        private Button mcolorButton;
        private Button bcolorButton;
        private ColorDialog mainColorDialog;
        private ColorDialog buttonColorDialog;
        private Label label1;
        private CheckedListBox extensionsCheckedListBox;
        private Button addExtensionButton;
        private TextBox extensionTextBox;
        private Button resetButton;
        private Button confirmExtensionsButton;
        private TextBox clientSecretTextbox;
        private TextBox clientIDTextbox;
        private Button updateClientButton;
        private Label label2;
        private Label label3;
        private Button openSpotifyDashboardButton;
    }
}