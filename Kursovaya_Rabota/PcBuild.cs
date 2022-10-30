using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;

namespace Kursovaya_Rabota
{
    public partial class PcBuild : Form
    {
        MySqlConnection ConnectStaff;
        Form activeform;
        void ChildForm(Form Child)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            panel2.Controls.Add(Child);
            panel2.Tag = Child;
            Child.BringToFront();
            Child.Show();
        }
        public PcBuild()
        {
            InitializeComponent();
        }
        private void PcBuild_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        }

        private void PcBuild_Leave(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm(new ViewCPU());
        }
    }
}
