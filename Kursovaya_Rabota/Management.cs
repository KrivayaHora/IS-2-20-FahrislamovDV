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

namespace Kursovaya_Rabota.Project.Forms
{
    public partial class Managementform : Form
    {
        MySqlConnection ConnectStaff;
        Form activeform;
        void ChildForm(Form Child)
        {
            if(activeform != null)
            {
                activeform.Close();
            }
            activeform = Child;
            Child.TopLevel = false;
            this.IsMdiContainer = true;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            Desktop.Controls.Add(Child);
            Desktop.Tag = Child;
            Child.BringToFront();
            Child.Show();
        }
        public Managementform()
        {
            InitializeComponent();
        }
        private void Management_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        }
        private void ClientsButton_Click(object sender, EventArgs e)
        {
            ChildForm(new ClientsView());
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {

        }

        private void ComponentButton_Click(object sender, EventArgs e)
        {

        }

        private void StaffButton_Click(object sender, EventArgs e)
        {

        }

        private void Desktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
