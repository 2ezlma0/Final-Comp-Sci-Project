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
            this.mcolorButton.BackColor = bcolor;
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
            this.bcolorButton.BackColor = bcolor;
            this.bcolorButton.Click += new System.EventHandler(this.bcolorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Close the settings window to apply these changes to the main window";
            // 
            // SettingsFormv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.BackColor = mcolor;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bcolorButton);
            this.Controls.Add(this.mcolorButton);
            this.Name = "SettingsFormv2";
            this.Text = "SettingsFormv2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void ChangeBColour()
        {
            mcolorButton.BackColor = bcolor;
            bcolorButton.BackColor = bcolor;
        }

        void ChangeMColour()
        {
            this.BackColor = mcolor;
        }
        #endregion

        private Button mcolorButton;
        private Button bcolorButton;
        private ColorDialog mainColorDialog;
        private ColorDialog buttonColorDialog;
        private Label label1;
    }
}