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

namespace Kursovaya_Rabota
{
    public partial class Staff : Form
    {
        MySqlConnection ConnectStaff;
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        BindingSource BindingS = new BindingSource();
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        string ID_selected_rows = "0";
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
        public void GetClients()
        {
            string sqlview = "SELECT ID AS `Код`, Fullname AS `Полное имя`, Phone AS `Контактный номер`, Login AS `Логин`, Password AS `Пароль`, Email AS `Адрес электронной почты` FROM Employee";
            ConnectStaff.Open();

            MyDA.SelectCommand = new MySqlCommand(sqlview, ConnectStaff);
            MyDA.Fill(DT);

            BindingS.DataSource = DT;

            dataGridView1.DataSource = BindingS;
            ConnectStaff.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;


            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[1].FillWeight = 40;
            dataGridView1.Columns[2].FillWeight = 15;
            dataGridView1.Columns[3].FillWeight = 15;
            dataGridView1.Columns[4].FillWeight = 15;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;
        }
        public Staff()
        {
            InitializeComponent();
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            GetClients();
        }
        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
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
