using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;

namespace Kursovaya_Rabota
{
    public partial class ManagementForm : MetroForm
    {
        MySqlConnection ConnectStaff;
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            NewComponent f1 = new NewComponent();
            f1.Show();
        }

        private void ManageEmp_Click(object sender, EventArgs e)
        {
            RegistrationForm f1 = new RegistrationForm();
            f1.Show();
        }
    }
}
