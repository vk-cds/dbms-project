using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static SV2AIR.DataSet1;
using System.Runtime.InteropServices;

namespace SV2AIR.AdministratorUC
{
    public partial class UC_modifyflights : UserControl
    {
        public UC_modifyflights()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_modifyflights_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {

            Int64 flightno = Int64.Parse(txtflightno.Text);
            String deptdate = txtdeptdate.Text;

            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();

            //i   MessageBox.Show("Connectedtodatasource");
            String query = "select * from flights where flight_id =" + flightno + "and dept_time='" + deptdate + "'";
           //i MessageBox.Show(query);
            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataReader reader1;
            reader1 = cmd.ExecuteReader();

            if (reader1.HasRows)
            {
                panel1.Visible = true;
                while (reader1.Read())
                {
                    String deptfrom = reader1["dept_from"].ToString();
                    deptfromlabel.Text = deptfrom;
                    String arriveat = reader1["arrive_at"].ToString();
                    arrivalatlabel.Text = arriveat;

                }
               
            }
            else
            {
                MessageBox.Show("No Data In DataBase");
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Int64 flightno = Int64.Parse(txtflightno.Text);
            String deptdate = txtdeptdate.Text;

            String price = txtprice.Text;
            String dept_tim = txtdt.Text;
            String arrtim = txtat.Text;
            panel1.Visible = true;
            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();

           //i MessageBox.Show("Connectedtodatasource");
            String query = "update flights set price='" + price + "' ,  dept_time='"+dept_tim +"' ,arrival_time='"+arrtim+ "'  where  flight_id = " + flightno + " and dept_time='" + deptdate + "'  ";
           //i MessageBox.Show(query);
           
           OracleCommand cmd = new OracleCommand(query, con);
            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                MessageBox.Show("Record not inserted");
            }
            else
            {
                MessageBox.Show("Success!");
            }

            Form2_1 f2 = new Form2_1();
            f2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form2_1 frdash = new Form2_1();
            frdash.Show();
            this.Hide();
        }
    }
}
