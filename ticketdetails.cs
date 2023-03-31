using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SV2AIR
{
    public partial class ticketdetails : Form
    {
        public ticketdetails()
        {
            InitializeComponent();
        }

        public string Value1 { get; set; }
        public string Value2 { get; set; }
        private void ticketdetails_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;
            // Int64 flightno = Int64.Parse(txtflightno.Text);
           
            //fidlabel.Text = Value1;

            //i code to diplay ticket id
            string a;
            int ab;
            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();
            String query1 = "select max(ticket_id) as ticket_id from ticket";
             //MessageBox.Show(query1);
            OracleCommand cmd = new OracleCommand(query1, con);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            a = dr["ticket_id"].ToString();
            ab = int.Parse(a);
            ab++;
            con.Dispose();
            txtticketid.Text = ab.ToString(); 
           
        }


        private void showdetailsbutton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;


            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();
            //i MessageBox.Show("Connectedtodatasource");
            String query = "select * from flights where flight_id =" + Value1 + "";
           //i  MessageBox.Show(query);
            OracleCommand cmd2 = new OracleCommand(query, con);
            OracleDataReader reader1;
            reader1 = cmd2.ExecuteReader();

            if (reader1.HasRows)
            {

                while (reader1.Read())
                {
                    String deptfrom = reader1["dept_from"].ToString();
                    departfromlabel.Text = deptfrom;

                    String deptdate = reader1["dept_time"].ToString();
                    deptdatelabel.Text = deptdate;

                    String arriveat = reader1["arrive_at"].ToString();
                    arriveatlabel.Text = arriveat;

                    String arrivedate = reader1["arrival_time"].ToString();
                    arrivedatelabel.Text = arrivedate;

                    String pri = reader1["price"].ToString();
                    pricelabel.Text = pri;


                }

            }
            else
            {
                MessageBox.Show("No Data In DataBase");
      }



            String query2 = "select * from passenger where user_id =" + Value2 + "";
          //i  MessageBox.Show(query2);
            OracleCommand cmd = new OracleCommand(query2, con);
            OracleDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    String pname = dr["first_name"].ToString();
                    pnamelabel.Text = pname;

                    String contact = dr["phone_no"].ToString();
                    pcontactlabel.Text = contact;

      
                }

            }
            else
            {
                MessageBox.Show("No Data In DataBase");
            }

        }


        private void paybutton_Click(object sender, EventArgs e)
        {
           

            string a;
            int ab;
            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();
            String query1 = "select max(ticket_id) as ticket_id from ticket";
           //i MessageBox.Show(query1);
            OracleCommand cmd = new OracleCommand(query1, con);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            a = dr["ticket_id"].ToString();
            ab = int.Parse(a);
            ab++;
          
            txtticketid.Text = ab.ToString();


            String query = "insert into ticket (ticket_id,user_id,flight_id)values(" + txtticketid.Text + ", " + Value2 + ", " + Value1 + ")";
           //i MessageBox.Show(query);
            OracleCommand cmd2 = new OracleCommand(query, con);
           

            int rowsUpdated = cmd2.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                MessageBox.Show("Record not inserted");
            }
            else
            {
                MessageBox.Show("Success!");
                printticket pt = new printticket();
                pt.Value1 = Value1;
                pt.Value2 = Value2;
                pt.Show();
                this.Hide();
               
                cancelbutton.Visible = true;
            }
            con.Dispose();

           
        
        }

        private void arriveatlabel_Click(object sender, EventArgs e)
        {

        }

        private void arrivedatelabel_Click(object sender, EventArgs e)
        {

        }

        private void pricelabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
