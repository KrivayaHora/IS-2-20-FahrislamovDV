using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kursovaya_Rabota
{
    public partial class ManagementForm : MetroForm
    {
        MySqlConnection ConnectStaff;
        public ManagementForm()
        {
            InitializeComponent();
        }
        private void OpenChild()
        {

        }
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");

        }
        private void ManageEmp_Click(object sender, EventArgs e)
        {
            Staff newStaff = new Staff();
            newStaff.ShowDialog();
        }
        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            PcBuild pcBuild = new PcBuild();
            pcBuild.Show();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientsView clientsView = new ClientsView();
            clientsView.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PcBuild pcBuild = new PcBuild();
            pcBuild.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewComponent f1 = new NewComponent();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff newStaff = new Staff();
            newStaff.ShowDialog();
        }
    }
}
