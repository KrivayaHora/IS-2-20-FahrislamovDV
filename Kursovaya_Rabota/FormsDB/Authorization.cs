using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using System.Threading;
using Kursovaya_Rabota.Project.Forms;
using Kursovaya_Rabota.FormsDB;

namespace Kursovaya_Rabota
{
    public partial class Autorization : MetroForm
    {
        Thread T1;
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
        public void RoleUsers()
        {

            string UserLG = LoginBox.Text;
            string sql = "SELECT `Role` FROM Employee WHERE `Login` = @LG";
            MySqlParameter Par = new MySqlParameter("LG", UserLG);

            MySqlCommand command = new MySqlCommand(sql, ConnectStaff);
            command.Parameters.Add(Par);

            string Role = command.ExecuteScalar().ToString();

            switch (Role)
            {
                case "Администратор":
                     void Management1(object obj)
                     {
                        Application.Run(new Managementform());
                     }
                    this.Close();
                    T1 = new Thread(Management1);
                    T1.SetApartmentState(ApartmentState.STA);
                    T1.Start();
                    break;
                case "Сборщик":
                    void Employee(object obj)
                    {
                        Application.Run(new Employee());
                    }
                    this.Close();
                    T1 = new Thread(Employee);
                    T1.SetApartmentState(ApartmentState.STA);
                    T1.Start();
                    break;
                default:
                    MessageBox.Show("Пользователь неопознан");
                    this.Close();
                    break;
            }
        }
        MySqlConnection ConnectStaff;
        public Autorization()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ConnectStaff.Open();
            string sql = $"SELECT * FROM `Employee` WHERE `Login`= @LB AND `Password`= @PB";

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand(sql, ConnectStaff);
            cmd.Parameters.Add("@LB", MySqlDbType.VarChar).Value = LoginBox.Text;
            cmd.Parameters.Add("@PB", MySqlDbType.VarChar).Value = sha256(PasswordBox.Text);
           
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                RoleUsers();
            }
            else
                MessageBox.Show("Неверные данные");

            ConnectStaff.Close();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
