using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_Rabota.FormsPC
{
    public partial class Config : Form
    {
        void LoadImage(string a)
        {
            var rec = WebRequest.Create(a);
            using (var res = rec.GetResponse())
            using (var stream = res.GetResponseStream())
                pictureBox1.Image = Bitmap.FromStream(stream);
        }
        public Config()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {

        }
    }
}
