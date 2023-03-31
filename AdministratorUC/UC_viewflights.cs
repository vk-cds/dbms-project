using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Text;
using System.Windows.Forms;
using static SV2AIR.DataSet1;

namespace SV2AIR.AdministratorUC
{
    public partial class UC_viewflights : UserControl
    {
       
        public UC_viewflights()
        {
            InitializeComponent();
        }

        private void UC_viewflights_Load(object sender, EventArgs e)
        {
          
            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();
          
            String query = "select * from flights ";
            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                DataTable dataTable = new DataTable();
                dataTable.Load(dr);
                dataviewflights.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("Invalid Login");
            }


            con.Dispose();
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form2_1 frdash = new Form2_1();
            frdash.Show();
            this.Hide();
        }

        private void dataviewflights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
