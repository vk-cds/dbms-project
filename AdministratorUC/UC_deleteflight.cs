using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Text;
using System.Windows.Forms;

namespace SV2AIR.AdministratorUC
{
    public partial class UC_deleteflight : UserControl
    {
        public UC_deleteflight()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Int64 flightno = Int64.Parse(txtflightno.Text);
            

            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();

            //i   MessageBox.Show("Connectedtodatasource");
            String query = "select * from flights where flight_id =" + flightno +  "";
           //i MessageBox.Show(query);
            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataReader reader1;
            reader1 = cmd.ExecuteReader();

            if (reader1.HasRows)
            {
              
                while (reader1.Read())
                {
                    String deptfrom = reader1["dept_from"].ToString();
                    deptfromlabel.Text = deptfrom;

                    String deptdate = reader1["dept_time"].ToString();
                    deptdatelabel.Text = deptdate;
                    
                    String arriveat = reader1["arrive_at"].ToString();
                    arrivalatlabel.Text = arriveat;

                    String arrivedate = reader1["arrival_time"].ToString();
                    arrivaldatelabel.Text = arrivedate;

                    String pri = reader1["price"].ToString();
                    pricelabel.Text = pri;


                }

            }
            else
            {
                MessageBox.Show("No Data In DataBase");
            }

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            Int64 flightno = Int64.Parse(txtflightno.Text);
            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();
            String query = "DELETE from flights where flight_id=" + flightno + " ";
            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataReader reader1;
            reader1 = cmd.ExecuteReader();
           

                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0)
                {
                MessageBox.Show("Success!");
            }
                else
                {
                   
                MessageBox.Show("Record not deleted");
            }
                con.Dispose();
            
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form2_1 frdash = new Form2_1();
            frdash.Show();
            this.Hide();
        }

        private void UC_deleteflight_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
