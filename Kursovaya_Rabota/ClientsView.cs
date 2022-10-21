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
using MetroFramework.Forms;
using MaterialSkin.Controls;

namespace Kursovaya_Rabota
{
    public partial class ClientsView : MetroForm
    {
        MySqlConnection ConnectStaff;
        public ClientsView()
        {
            InitializeComponent();
        }

        private void ClientsView_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
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
    }
}
