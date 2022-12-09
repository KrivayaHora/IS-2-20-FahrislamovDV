using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using SqlKata.Execution;
using static Humanizer.In;

namespace Kursovaya_Rabota.FormsPC
{
    public partial class Config : Form
    {
        MySqlConnection ConnectStaff;
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
            string price;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 2";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                price = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                CPUString.Text = name;
                CPUPrice.Text = price;
                LoadImage(URL, pictureBox1);
            }
            ConnectStaff.Close();
        }

        void Mothercfg()
        {
            
            string URL;
            string name;
            string price;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 1";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                price = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                MotherString.Text = name;
                MotherPrice.Text = price;
                LoadImage(URL, pictureBox2);
            }
            ConnectStaff.Close();
        }
        void GPUcfg()
        {
            
            string URL;
            string name;
            string price;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 3";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                price = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                GPUString.Text = name;
                GPUPrice.Text = price;
                LoadImage(URL, pictureBox3);
            }
            ConnectStaff.Close();
        }
        void HDDcfg()
        {
            
            string URL;
            string name;
            string price;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 6";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                price = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                HDDString.Text = name;
                HDDPrice.Text = price;
                LoadImage(URL, pictureBox4);
            }
            ConnectStaff.Close();
        }
        void SSDcfg()
        {
            string URL;
            string name;
            string price;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 5";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                price = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                SSDString.Text = name;
                SSDPrice.Text = price;
                LoadImage(URL, pictureBox5);
            }
            ConnectStaff.Close();
        }
        void RAMcfg()
        {
           
            string URL;
            string name;
            string price;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 7";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                price = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                RAMString.Text = name;
                RAMPrice.Text = price;
                LoadImage(URL, pictureBox6);
            }
            ConnectStaff.Close();
        }
        void Bodycfg()
        {
           
            string URL;
            string name;
            string price;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 9";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                price = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                BodyString.Text = name;
                BodyPrice.Text = price;
                LoadImage(URL, pictureBox7);
            }
            ConnectStaff.Close();
        }
        void CFBcfg()
        {
            
            string URL;
            string name;
            string price;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 10";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                price = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                BFString.Text = name;
                BFPrice.Text = price;
                LoadImage(URL, pictureBox8);
            }
            ConnectStaff.Close();
        }
        void PScfg()
        {
            
            string URL;
            string name;
            string price;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 4";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                price = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                PSString.Text = name;
                PSPrice.Text = price;
                LoadImage(URL, pictureBox9);
            }
            ConnectStaff.Close();
        }
        void Coolercfg()
        {
            
            string URL;
            string name;
            string price;
            string manuf;
            ConnectStaff.Open();

            string sql = "SELECT Cfg.ID AS `Код`, Items.Title, Items.Price, Manufacture.title AS `Производитель`, Items.URLphoto FROM Cfg JOIN Items ON Cfg.Item_ID = Items.ID JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 8";
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader[1].ToString();
                price = reader[2].ToString();
                manuf = reader[3].ToString();
                URL = reader[4].ToString();
                name = manuf + " " + name;
                CoolerString.Text = name;
                CoolerPrice.Text = price;
                LoadImage(URL, pictureBox10);
            }
            ConnectStaff.Close();
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
        }

        private void DeleteALL_Click(object sender, EventArgs e)
        {

        }
    }

}
