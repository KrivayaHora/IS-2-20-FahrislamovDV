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
using SqlKata.Execution;

namespace Kursovaya_Rabota.FormsDB.Components
{
    public partial class Mother : Form
    {

        MySqlConnection ConnectStaff;
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        BindingSource BindingS = new BindingSource();
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        public void GetMother()
        {
            
            string sqlview = "SELECT Items.ID AS `код`, Manufacture.title AS `Производитель`, Items.Title AS `Название`, Type.title AS `Тип товара`,Items.In_storage AS `На хранении`, Items.Price AS `Цена` FROM Items JOIN Type ON Items.Type_id = Type.id JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Type.id = 1";
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
            dataGridView1.Columns[5].Visible = true;



            dataGridView1.Columns[0].FillWeight = 15;
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

            dataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ColumnHeadersVisible = true;
        }
        void Delete(int ID)
        {
            string sql = "DELETE FROM Items Where ID=" + ID;
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);

            
                ConnectStaff.Open();
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.DeleteCommand = ConnectStaff.CreateCommand();

                adapter.DeleteCommand.CommandText = sql;

                ConnectStaff.Close();
                GetMother();
            
        }
        public Mother()
        {
            InitializeComponent();
        }

        private void Mother_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            GetMother();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String select = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int ID = Convert.ToInt32(select);
            Delete(ID);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
