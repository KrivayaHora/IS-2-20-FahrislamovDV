using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SqlKata.Execution;

namespace Kursovaya_Rabota
{
    public partial class Staff : Form
    {
        MySqlConnection ConnectStaff;
        public void GetEmployee()
        {
            var DB = DBFGrid.DataBase();
            IEnumerable<EmployeeView> res = DB.Query("Employee").Get<EmployeeView>();

            foreach(var emp in res)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    emp.ID, emp.FullName, emp.Phone, emp.Login, emp.Password, emp.Phone, emp.Role
                });
            } 
        }
        public Staff()
        {
            InitializeComponent();
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            //ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            GetEmployee();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
    }
}
