using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_Rabota.FormsDB
{
    public partial class RegisterFormC : Form
    {
        MySqlConnection ConnectStaff;
        public RegisterFormC()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectStaff.Open();

            string fio = FioRegBoxC.Text;
            string adress = AdressRegBoxC.Text;
            string phone = PhoneRegBoxC.Text;
            string email = EmailRegBoxC.Text;

            string sql = "INSERT INTO `Clients`(Fullname, Adress, Phone, Email) VALUES (@fio, @adress, @phone, @email)";

            MySqlCommand CMD = new MySqlCommand(sql, ConnectStaff);
            CMD.Parameters.Add("@fio", MySqlDbType.VarChar).Value = FioRegBoxC.Text;
            CMD.Parameters.Add("@adress", MySqlDbType.VarChar).Value = AdressRegBoxC.Text;
            CMD.Parameters.Add("@phone", MySqlDbType.VarChar).Value = PhoneRegBoxC.Text;
            CMD.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailRegBoxC.Text;

            if (CMD.ExecuteNonQuery() == 1)
                MessageBox.Show("Клиент добавлен");
            else
                MessageBox.Show("Ошибка добавления");

            ConnectStaff.Close();
        }

        private void RegisterFormC_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        }
    }
}
