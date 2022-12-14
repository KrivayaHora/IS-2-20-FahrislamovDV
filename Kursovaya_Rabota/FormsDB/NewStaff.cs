using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SqlKata;
using SqlKata.Execution;

namespace Kursovaya_Rabota
{
    public partial class Staff : Form
    {
        MySqlConnection ConnectStaff;
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable DT = new DataTable();
        BindingSource BS = new BindingSource();

        public void GetEmployee()
        {
            DT.Clear();
            string view = "SELECT Employee.ID as `Код`, Employee.FullName as `ФИО`, Employee.Email as `Электронная почта`, Employee.Phone as `Телефон`, Employee.Role as `Должность`, Employee.Login as `Логин`, Employee.`Password` as `Пароль` FROM Employee ";
            ConnectStaff.Open();

            da.SelectCommand = new MySqlCommand(view, ConnectStaff);
            da.Fill(DT);
            BS.DataSource = DT;
            dataGridView1.DataSource = BS;
            ConnectStaff.Close();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;
            dataGridView1.Columns[6].Visible = true;


            dataGridView1.Columns[0].FillWeight = 20;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 15;
            dataGridView1.Columns[3].FillWeight = 15;
            dataGridView1.Columns[4].FillWeight = 15;
            dataGridView1.Columns[5].FillWeight = 15;
            dataGridView1.Columns[6].FillWeight = 15;

            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
            GetEmployee();
        }
        
        private void Search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectStaff.Open();
                string search = $"SELECT Employee.ID as `Код`, Employee.FullName as `ФИО`, Employee.Email as `Электронная почта`, Employee.Phone as `Телефон`, Employee.Role as `Должность`, Employee.Login as `Логин`, Employee.`Password` as `Пароль` FROM Employee WHERE FullName = '" +Search.Text+"'";
                DT.Clear();
                da.SelectCommand = new MySqlCommand(search, ConnectStaff);
                da.Fill(DT);
                BS.DataSource = DT;
                dataGridView1.DataSource = BS;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                ConnectStaff.Close();
            }
        }

        private void RegB_Click(object sender, EventArgs e)
        {
            Form reg = new RegisterForm();
            reg.ShowDialog();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            GetEmployee();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
