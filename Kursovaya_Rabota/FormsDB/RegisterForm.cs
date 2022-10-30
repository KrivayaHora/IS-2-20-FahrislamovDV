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

namespace Kursovaya_Rabota
{
    public partial class RegisterForm : Form
    {
        MySqlConnection ConnectStaff;
        static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectStaff.Open();

            string fio = FIOBox.Text;
            string phone = PhoneBox.Text;
            string reglog = LoginBox.Text;
            string passlog = PassBox.Text;
            string email = EmailBox.Text;

            string sql = "INSERT INTO `Employee`(Fullname, Phone, Login, Password, Email, Role) VALUES (@fio, @phone, @reglog, @passlog, @email, @role)";

            MySqlCommand CMD = new MySqlCommand(sql, ConnectStaff);
            CMD.Parameters.Add("@fio", MySqlDbType.VarChar).Value = FIOBox.Text;
            CMD.Parameters.Add("@phone", MySqlDbType.VarChar).Value = PhoneBox.Text;
            CMD.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailBox.Text;
            CMD.Parameters.Add("@reglog", MySqlDbType.VarChar).Value = LoginBox.Text;
            CMD.Parameters.Add("@passlog", MySqlDbType.VarChar).Value = sha256(PassBox.Text);
            CMD.Parameters.Add("@role", MySqlDbType.VarChar).Value = RoleBox.Text;

            if (CMD.ExecuteNonQuery() == 1)
                MessageBox.Show("Пользователь добавлен");
            else
                MessageBox.Show("Ошибка добавления");
            ConnectStaff.Close();
        }
    }
}
