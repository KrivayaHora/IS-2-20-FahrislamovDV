using Kursovaya_Rabota.FormsPC;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kursovaya_Rabota.FormsDB
{
    public partial class Employee : Form
    {
        MySqlConnection ConnectStaff;
        Form activeform;
        public Employee()
        {
            InitializeComponent();
        }
        void ChildForm(Form Child)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = Child;
            Child.TopLevel = false;
            this.IsMdiContainer = true;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            panel4.Controls.Add(Child);
            panel4.Tag = Child;
            Child.BringToFront();
            Child.Show();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        }
        private void Cfg_Click(object sender, EventArgs e)
        {
            ChildForm(new Config());
            label2.Text = "Вкладка сборки";
        }
        private void ConfigButton_Click(object sender, EventArgs e)
        {
            ChildForm(new PcBuild());
            label2.Text = "Вкладка конфигуратор";
        }
    }
}
