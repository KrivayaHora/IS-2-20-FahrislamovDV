﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SqlKata;
using SqlKata.Execution;

namespace Kursovaya_Rabota
{
    public partial class Staff : Form
    {
        MySqlConnection ConnectStaff;
        public void GetEmployee()
        {
            dataGridView1.Rows.Clear();
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
        public void SearchEmp()
        {
            dataGridView1.Rows.Clear();
            var DB = DBFGrid.DataBase();
            Query q = DB.Query("Employee");
            if (Search.Text.Trim().Length > 0)
            {
                q = q.Where("FullName", Search.Text.Trim());
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
        
        private void Search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void RegB_Click(object sender, EventArgs e)
        {
            Form reg = new RegisterForm();
            reg.ShowDialog();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            GetEmployee();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}