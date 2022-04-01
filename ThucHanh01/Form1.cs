using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh01
{
    public partial class Form1 : Form
    {
        int pos = 0;
        
        public Form1()
        {
            InitializeComponent();
            this.Icon = new Icon("logoicon.ico");
        }

        public Form1(int sothutu)
        {
            InitializeComponent();
            mediaTrailer.settings.autoStart = true;
            mediaTrailer.URL = "trim-trailer\\" + sothutu + ".mp4";
            pos = sothutu;
        }

        private void mediaTrailer_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_MouseClick(object sender, MouseEventArgs e)
        {
            FormInfo frm = new FormInfo(pos);
            frm.Show();
            this.Hide();
            mediaTrailer.close();

        }
    }
}
