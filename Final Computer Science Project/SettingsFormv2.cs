using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Computer_Science_Project
{
    public partial class SettingsFormv2 : Form
    {
        public Color mcolor, bcolor;
        public int malpha, mred, mblue, mgreen, balpha, bred, bblue, bgreen;
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
        //8 = *wav
        //9 = *m4a
        //10 = *mp3
        //any higher than this will be extra extentions for now

        public SettingsFormv2()
        {
            MainForm _ = new MainForm();
            mcolor = _.mcolor;
            bcolor = _.bcolor;
            InitializeComponent();
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
            settings[6] = "bblue=" + bcolor.B.ToString();
            settings[7] = "bgreen=" + bcolor.G.ToString();
            File.Delete(settingsConfigPath);
            File.WriteAllLines(settingsConfigPath, settings);

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
            settings[2] = "mblue=" + mcolor.B.ToString();
            settings[3] = "mgreen=" + mcolor.G.ToString();
            File.Delete(settingsConfigPath);
            File.WriteAllLines(settingsConfigPath, settings);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
