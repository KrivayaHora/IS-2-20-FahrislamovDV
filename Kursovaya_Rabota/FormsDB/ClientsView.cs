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
    public partial class ClientsView : Form
    {
        MySqlConnection ConnectStaff;
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        BindingSource BindingS = new BindingSource();
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        string ID_selected_rows = "0";
        public void GetClients()
        {
            string sqlview = "SELECT ID AS `Код`, Fullname AS `Полное имя`, Adress AS `Адрес проживания`, Phone AS `Контактный номер`, Email AS `Адрес электронной почты` FROM Clients";
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
        public ClientsView()
        {
            InitializeComponent();
        }

        private void ClientsView_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            GetClients();
        }

        

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
