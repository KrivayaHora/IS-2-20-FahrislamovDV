using System;
using System.Data;
using System.Drawing;
using System.Net;
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
        void LoadImage(string a)
        {
            var rec = WebRequest.Create(a);
            using (var res = rec.GetResponse())
            using (var stream = res.GetResponseStream())
                pictureBox1.Image = Bitmap.FromStream(stream);
        }
        public void GetCPU()
        {
            DT.Clear();
            string sqlview = "SELECT Items.ID AS `код`, Manufacture.title AS `Производитель`, Items.Title AS `Название`, Type.title AS `Тип товара`, Items.Price AS `Цена` FROM Items JOIN Type ON Items.Type_id = Type.id JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Type.id = 2";
            ConnectStaff.Open();

            MyDA.SelectCommand = new MySqlCommand(sqlview, ConnectStaff);
            MyDA.Fill(DT);

            BindingS.DataSource = DT;

            dataGridView1.DataSource = BindingS;
            ConnectStaff.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = false;
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string socket;
                    string since;
                    string freq;
                    string core;
                    string thread;
                    string tdp;
                    string typemem;
                    string Name;

                    ConnectStaff.Open();
                    string sqlSocket = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 20 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmd1 = new MySqlCommand(sqlSocket, ConnectStaff);
                    socket = cmd1.ExecuteScalar().ToString();
                    label12.Text = socket;

                    string sqlfreq = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 21 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdFreq = new MySqlCommand(sqlfreq, ConnectStaff);
                    freq = cmdFreq.ExecuteScalar().ToString();
                    label14.Text = freq;

                    string sqlCore = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 22 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdCore = new MySqlCommand(sqlCore, ConnectStaff);
                    core = cmdCore.ExecuteScalar().ToString();
                    label15.Text = core;

                    string sqlThread = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 23 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdThread = new MySqlCommand(sqlThread, ConnectStaff);
                    thread = cmdThread.ExecuteScalar().ToString();
                    label17.Text = thread;

                    string sqlTDP = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 24 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdTDP = new MySqlCommand(sqlTDP, ConnectStaff);
                    tdp = cmdTDP.ExecuteScalar().ToString();
                    label16.Text = tdp;

                    string sqlMem = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 25 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdMem = new MySqlCommand(sqlMem, ConnectStaff);
                    typemem = cmdMem.ExecuteScalar().ToString();
                    label19.Text = typemem;

                    string sqlSince = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 26 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdSince = new MySqlCommand(sqlSince, ConnectStaff);
                    since = cmdSince.ExecuteScalar().ToString();
                    label13.Text = since;

                    string sqlImage = "SELECT Items.URLphoto FROM Items where Items.ID = " + id;
                    MySqlCommand cmdpic = new MySqlCommand(sqlImage, ConnectStaff);
                    string pic = cmdpic.ExecuteScalar().ToString();
                    LoadImage(pic);

                    string sqlName = "SELECT Items.Title FROM Items where Items.ID = " + id;
                    MySqlCommand cmdName = new MySqlCommand(sqlName, ConnectStaff);
                    Name = cmdName.ExecuteScalar().ToString();
                    label1.Text = Name;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ConnectStaff.Close();
                }
            }
        }

       
    }
}
