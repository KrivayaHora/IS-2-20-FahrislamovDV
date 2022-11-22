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
using SqlKata;
using SqlKata.Execution;
using Kursovaya_Rabota.FormsDB;

namespace Kursovaya_Rabota
{
    public partial class ClientsV : Form
    {
        MySqlConnection ConnectStaff;
        public void GetClients()
        {
            dataGridView1.Rows.Clear();
            var DB = DBFGrid.DataBase();

            IEnumerable<ClientV> res = DB.Query("Clients").Get<ClientV>();

            foreach (var client in res)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    client.ID, client.FullName, client.Adress, client.Phone, client.Email
                });
            }
        }
        public void SearchCli()
        {
            dataGridView1.Rows.Clear();
            var DB = DBFGrid.DataBase();
            Query q = DB.Query("Clients");
            if (Search.Text.Trim().Length > 0)
            {
                q = q.Where("FullName", Search.Text.Trim());
            }
        }

        
        public ClientsV()
        {
            InitializeComponent();
        }

        private void ClientsView_Load(object sender, EventArgs e)
        {
            //ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            GetClients();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchCli();
        }

        private void RegB_Click(object sender, EventArgs e)
        {
            Form form = new RegisterFormC();
            form.ShowDialog();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            GetClients();
        }
    }
}
