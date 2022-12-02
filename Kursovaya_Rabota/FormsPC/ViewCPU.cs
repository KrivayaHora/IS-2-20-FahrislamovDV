using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kursovaya_Rabota
{
    public partial class ViewCPU : Form
    {
        MySqlConnection ConnectStaff;
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        BindingSource BindingS = new BindingSource();
        DataTable DT = new DataTable();
        public void GetCPU()
        {
            DT.Clear();
            string sqlview = "SELECT Items.ID AS `код`, Manufacture.title AS `Производитель`, Items.Title AS `Название`, Type.title AS `Тип товара`,Items.In_storage AS `На хранении`, Items.Price AS `Цена` FROM Items JOIN Type ON Items.Type_id = Type.id JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Type.id = 2";
            ConnectStaff.Open();

            MyDA.SelectCommand = new MySqlCommand(sqlview, ConnectStaff);
            MyDA.Fill(DT);

            BindingS.DataSource = DT;

            dataGridView1.DataSource = BindingS;
            ConnectStaff.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;


            dataGridView1.Columns[0].FillWeight = 20;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 15;
            dataGridView1.Columns[3].FillWeight = 15;
            dataGridView1.Columns[4].FillWeight = 15;
            dataGridView1.Columns[5].FillWeight = 15;

            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;
        }
        
        void ShowP(Panel p)
        {
            p.Height = p.Controls.OfType<Button>().Count() * 30 + 15;
        }
        public ViewCPU()
        {
            InitializeComponent();
        }

        private void ViewCPU_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            GetCPU();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PriceBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ManufBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SocketBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MemBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void CoreBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
