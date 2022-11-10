using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;
using System.Collections.Specialized;
using System.Collections;




namespace POSandInventorySystem
{
    
    public partial class FormSplashScreen : Form
    {
        private int tempHeight = 0, tempWidth = 0;
        private int FixHeight = 1600, FixWidth = 900;

        public FormSplashScreen()
        {
            //------------------< Form_Init() >------------------

            InitializeComponent();
            Screen Srn = Screen.PrimaryScreen;
            tempHeight = Srn.Bounds.Width;
            tempWidth = Srn.Bounds.Height;



            CResolution ChangeRes = new CResolution(FixHeight, FixWidth);
            //------------------</ Form_Init() >------------------
            timer1.Enabled = true;
        }
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            progressBar1.Value = time;
            if (time == 100)
            {
                timer1.Enabled = false;
                var form = new Form1();
                form.Show();
                this.Hide();
                time = 0;
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
