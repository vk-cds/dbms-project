using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Types;
using System.Windows.Forms;
using SV2AIR;

namespace SV2AIR.AdministratorUC
{
    public partial class UC_addflights : UserControl
    {
        public UC_addflights()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Int64 flightid = Int64.Parse(txtflightno.Text);
            String deptfrom = txtdepartfrom.Text;
            String deptdate = txtdeptdate.Text;
            String arriveat = txtarriveat.Text;
            String arrivedate = txtarrivedate.Text;
            String price = txtprice.Text;

            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
           
                con.Open();
               
                //i MessageBox.Show("Connectedtodatasource");
            String query  = "insert into flights(flight_id,dept_from,dept_time,arrive_at,arrival_time,price) values("+flightid+" , '"+deptfrom+"' , '"+deptdate+"' ,'"+arriveat+"' ,'"+arrivedate+"' ,'"+price+" ')" ;
            // MessageBox.Show(query);
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


          // txtflightno.Clear();
          //  txtdepartfrom.Clear();
          // txtdeptdate.Clear();
            Form2_1 f2 = new Form2_1();
           f2.Show();
            this.Hide();

            con.Dispose();
            }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            Form2_1 frdash = new Form2_1();
            frdash.Show();
            this.Hide();


        }
    }
    }





