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
using Kursovaya_Rabota.FormsPC;
using Kursovaya_Rabota.FormsDB.Components;

namespace Kursovaya_Rabota
{
    public partial class NewComponent : Form

    {
        MySqlConnection ConnectStaff;

        Form activeform;
        void ChildForm(Form Child)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            panel4.Controls.Add(Child);
            panel4.Tag = Child;
            Child.BringToFront();
            Child.Show();
        }

        public NewComponent()
        {
            InitializeComponent();
        }

        private void NewComponent_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Selector.Text == "Материнская плата")
            {
                ChildForm(new Mother());
            }
            else if(Selector.Text == "Видеокарта")
            {
                ChildForm(new GPUView());
            }
        }
    }
}
