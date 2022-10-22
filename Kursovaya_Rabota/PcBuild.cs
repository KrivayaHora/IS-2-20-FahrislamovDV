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

namespace Kursovaya_Rabota
{
    public partial class PcBuild : MetroForm
    {
        public PcBuild()
        {
            InitializeComponent();
        }
        MySqlConnection ConnectStaff;
        private void PcBuild_Load(object sender, EventArgs e)
        {
            ConnectStaff = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        }

        private void PcBuild_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
