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
using MetroFramework.Controls;
using MaterialSkin.Controls;

namespace Kursovaya_Rabota
{
    public partial class NewComponent : Form
    {
        MySqlConnection Connect = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        public NewComponent()
        {
            InitializeComponent();
        }

        private void NewComponent_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
