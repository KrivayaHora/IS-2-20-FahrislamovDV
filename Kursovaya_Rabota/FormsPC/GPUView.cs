using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
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
        void LoadImage(string a)
        {
            var rec = WebRequest.Create(a);
            using (var res = rec.GetResponse())
            using (var stream = res.GetResponseStream())
                pictureBox1.Image = Bitmap.FromStream(stream);
        }
        public void GetGPU()
        {
            string sqlview = "SELECT Items.ID AS `код`, Manufacture.title AS `Производитель`, Items.Title AS `Название`, Type.title AS `Тип товара`, Items.Price AS `Цена` FROM Items JOIN Type ON Items.Type_id = Type.id JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Type.id = 3";
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
        private void GPUView_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            GetGPU();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string chip;
                    string sizemem;
                    string busmem;
                    string typemem;
                    string freq;
                    string video;

                    string Name;

                    ConnectStaff.Open();
                    string sqlSocket = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 30 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmd1 = new MySqlCommand(sqlSocket, ConnectStaff);
                    chip = cmd1.ExecuteScalar().ToString();
                    label12.Text = chip;

                    string sqlchipset = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 31 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdchipset = new MySqlCommand(sqlchipset, ConnectStaff);
                    sizemem = cmdchipset.ExecuteScalar().ToString();
                    label14.Text = sizemem;

                    string sqltypemem = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 32 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdtypemem = new MySqlCommand(sqltypemem, ConnectStaff);
                    busmem = cmdtypemem.ExecuteScalar().ToString();
                    label15.Text = busmem;

                    string sqlssdm = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 33 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdThread = new MySqlCommand(sqlssdm, ConnectStaff);
                    typemem = cmdThread.ExecuteScalar().ToString();
                    label17.Text = typemem;

                    string sqlsata = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 34 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdTDP = new MySqlCommand(sqlsata, ConnectStaff);
                    freq = cmdTDP.ExecuteScalar().ToString();
                    label16.Text = freq;

                    string sqlvideo = "SELECT Properties_value.`Value` FROM Properties_value WHERE Properties_value.Property_ID = 35 AND Properties_value.Item_ID = " + id;
                    MySqlCommand cmdvideo = new MySqlCommand(sqlvideo, ConnectStaff);
                    video = cmdvideo.ExecuteScalar().ToString();
                    label13.Text = video;

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
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    ConnectStaff.Open();
                    string sql = $"INSERT INTO `Cfg`(Item_ID) VALUES (@ID)";
                    MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
                    cmd.Parameters.Add("ID", MySqlDbType.VarChar).Value = id;
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Добавлено в сборку", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Код ошибки:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    ConnectStaff.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
