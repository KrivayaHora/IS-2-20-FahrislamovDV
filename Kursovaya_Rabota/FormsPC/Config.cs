using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using SqlKata.Execution;
using static Humanizer.In;
using System.Data;

namespace Kursovaya_Rabota.FormsPC
{
    public partial class Config : Form
    {
        MySqlConnection ConnectStaff;
        string priceCPU;
        string priceMother;
        string priceGPU;
        string priceHDD;
        string priceSSD;
        string priceRAM;
        string priceBody;
        string priceCFB;
        string pricePS;
        string priceCooler;
        string Result;
        void LoadImage(string a, PictureBox pictureBox)
        {
            var rec = WebRequest.Create(a);
            using (var res = rec.GetResponse())
            using (var stream = res.GetResponseStream())
                pictureBox.Image = Bitmap.FromStream(stream);
        }
        void CPUcfg()
        {
            string URL;
            string name;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 2";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                priceCPU = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                CPUString.Text = name;
                CPUPrice.Text = priceCPU;
                LoadImage(URL, pictureBox1);
            }
            ConnectStaff.Close();
        }
        
        void Mothercfg()
        {
            string URL;
            string name;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 1";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                priceMother = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                MotherString.Text = name;
                MotherPrice.Text = priceMother;
                LoadImage(URL, pictureBox2);
            }
            ConnectStaff.Close();
        }
        void GPUcfg()
        {
            string URL;
            string name;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 3";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                priceGPU = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                GPUString.Text = name;
                GPUPrice.Text = priceGPU;
                LoadImage(URL, pictureBox3);
            }
            ConnectStaff.Close();
        }
        void HDDcfg()
        {
            string URL;
            string name;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 6";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                priceHDD = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                HDDString.Text = name;
                HDDPrice.Text = priceHDD;
                LoadImage(URL, pictureBox4);
            }
            ConnectStaff.Close();
        }
        void SSDcfg()
        {
            string URL;
            string name;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 5";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                priceSSD = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                SSDString.Text = name;
                SSDPrice.Text = priceSSD;
                LoadImage(URL, pictureBox5);
            }
            ConnectStaff.Close();
        }
        void RAMcfg()
        {
            string URL;
            string name;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 7";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                priceRAM = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                RAMString.Text = name;
                RAMPrice.Text = priceRAM;
                LoadImage(URL, pictureBox6);
            }
            ConnectStaff.Close();
        }
        void Bodycfg()
        {
            string URL;
            string name;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 9";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                priceBody = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                BodyString.Text = name;
                BodyPrice.Text = priceBody;
                LoadImage(URL, pictureBox7);
            }
            ConnectStaff.Close();
        }
        void CFBcfg()
        {
            string URL;
            string name;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 10";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                priceCFB = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                BFString.Text = name;
                BFPrice.Text = priceCFB;
                LoadImage(URL, pictureBox8);
            }

            ConnectStaff.Close();
        }
        void PScfg()
        {
            string URL;
            string name;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 4";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                pricePS = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                PSString.Text = name;
                PSPrice.Text = pricePS;
                LoadImage(URL, pictureBox9);
            }
            ConnectStaff.Close();
        }
        void Coolercfg()
        {
            string URL;
            string name;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 8";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                priceCooler = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                CoolerString.Text = name;
                CoolerPrice.Text = priceCooler;
                LoadImage(URL, pictureBox10);
            }
            ConnectStaff.Close();
        }
        void PriceResult()
        {
            Convert.ToInt32(priceCPU);
            Convert.ToInt32(pricePS);
            Convert.ToInt32(priceCooler);
            Convert.ToInt32(priceGPU);
            Convert.ToInt32(priceHDD);
            Convert.ToInt32(priceSSD);
            Convert.ToInt32(priceRAM);
            Convert.ToInt32(priceBody);
            Convert.ToInt32(priceCFB);
            Convert.ToInt32(Result);
            int res = Convert.ToInt32(priceCPU) + Convert.ToInt32(pricePS) + Convert.ToInt32(priceCooler) + Convert.ToInt32(priceGPU) + Convert.ToInt32(priceHDD) + Convert.ToInt32(priceSSD) + Convert.ToInt32(priceRAM) + Convert.ToInt32(priceBody) + Convert.ToInt32(priceCFB);
            Result = res.ToString();
            string rub = "Рублей";
            label2.Text = "Итоговая сумма: "+ " " + Result + " " + rub;
        }
        void loadComboBoxEmployees()
        {
            DataTable dataTable = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            ConnectStaff.Open();
            dataTable.Columns.Add(new DataColumn("ID", System.Type.GetType("System.String")));
            dataTable.Columns.Add(new DataColumn("FullName", System.Type.GetType("System.String")));

            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "ID";

            string sql = "SELECT Employee.ID, Employee.FullName FROM Employee";
            cmd.CommandText = sql;
            cmd.Connection = ConnectStaff;

            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["ID"] = reader[0].ToString();
                    dataRow["Fullname"] = reader[1].ToString();
                    dataTable.Rows.Add(dataRow);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectStaff.Close();
            }
        }
        void loadComboBoxClients()
        {
            DataTable dataTable = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            ConnectStaff.Open();
            dataTable.Columns.Add(new DataColumn("ID", System.Type.GetType("System.String")));
            dataTable.Columns.Add(new DataColumn("FullName", System.Type.GetType("System.String")));

            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = "FullName";
            comboBox2.ValueMember = "ID";

            string sql = "SELECT Clients.ID, Clients.FullName FROM Clients";
            cmd.CommandText = sql;
            cmd.Connection = ConnectStaff;

            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["ID"] = reader[0].ToString();
                    dataRow["Fullname"] = reader[1].ToString();
                    dataTable.Rows.Add(dataRow);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectStaff.Close();
            }
        }
        public Config()
        {
            InitializeComponent();
        }
        private void Config_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            CPUcfg();
            Mothercfg();
            GPUcfg();
            HDDcfg();
            SSDcfg();
            RAMcfg();
            Bodycfg();
            CFBcfg();
            PScfg();
            Coolercfg();
            PriceResult();
            loadComboBoxEmployees();
            loadComboBoxClients();
        }

        private void DeleteALL_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectStaff.Open();
                string sqlDelete = "DELETE FROM Cfg";
                MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, ConnectStaff);
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Очистка прошла успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Очистить не удалось, ошибка:"+ex.Message,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectStaff.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

}
