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

namespace Kursovaya_Rabota.FormsPC
{
    public partial class GPUView : Form
    {
        public GPUView()
        {
            InitializeComponent();
        }

        MySqlConnection ConnectStaff;
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        BindingSource BindingS = new BindingSource();
        DataTable DT = new DataTable();

        public void GetGPU()
        {
            string sqlview = "SELECT Items.ID AS `код`, Manufacture.title AS `Производитель`, Items.Title AS `Название`, Type.title AS `Тип товара`,Items.In_storage AS `На хранении`, Items.Price AS `Цена` FROM Items JOIN Type ON Items.Type_id = Type.id JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Type.id = 3";
            ConnectStaff.Open();

            MyDA.SelectCommand = new MySqlCommand(sqlview, ConnectStaff);
            MyDA.Fill(DT);

            BindingS.DataSource = DT;

            dataGridView1.DataSource = BindingS;
            ConnectStaff.Close();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;


            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[1].FillWeight = 15;
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GPUView_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            GetGPU();
            panelPrice.Visible = false;
            panelManuf.Visible = false;
            
            panelMem.Visible = false;
            panelSizeMem.Visible = false;
            panelBusBit.Visible = false;
        }

        private void PriceBtn_Click(object sender, EventArgs e)
        {
            if (panelPrice.Visible == false)
                panelPrice.Visible = true;
            else
                panelPrice.Visible = false;
        }

        private void ManufBtn_Click(object sender, EventArgs e)
        {
            if (panelManuf.Visible == false)
                panelManuf.Visible = true;
            else
                panelManuf.Visible = false;
        }

        private void SocketBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MemBtn_Click(object sender, EventArgs e)
        {
            if (panelMem.Visible == false)
                panelMem.Visible = true;
            else
                panelMem.Visible = false;
        }

        private void CoreBtn_Click(object sender, EventArgs e)
        {
            if (panelSizeMem.Visible == false)
                panelSizeMem.Visible = true;
            else
                panelSizeMem.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelBusBit.Visible == false)
                panelBusBit.Visible = true;
            else
                panelBusBit.Visible = false;
        }
    }
}
