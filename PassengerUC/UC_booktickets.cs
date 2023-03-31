using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;
using static SV2AIR.DataSet1;
using System.Net.NetworkInformation;

namespace SV2AIR.PassengerUC
{
    public partial class UC_booktickets : UserControl
    {
        public UC_booktickets()
        {
            InitializeComponent();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void searchbutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            String from = txtfrom.Text;
            String to = txtto.Text;
            String depart_on = txtdeparton.Text;

            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();

             //i MessageBox.Show("Connectedtodatasource");
            String query = "select * from flights where dept_from='"+from+"'  and arrive_at='"+ to+"' and dept_time='"+ depart_on + "'   ";
           //i  MessageBox.Show(query);
            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                datagrid.AutoGenerateColumns = true;
                DataTable dataTable = new DataTable();
                dataTable.Load(reader1);
                datagrid.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }


            con.Dispose();







        }

        private void UC_booktickets_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
           // uC_customerbookregister1.Visible = false;
           //i uC_ticketdetails1.Visible = false;
        }


        

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string Value1 { get; set; }


        private void bookbutton_Click(object sender, EventArgs e)
        {

            String fno = txtflightno.Text;
            Value1 = fno;

          //  MessageBox.Show(Value1);
            customereg cr = new customereg();

            cr.Show();
            cr.Value2 = fno;
            this.Hide();
                
        }

        private void txtflightno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
