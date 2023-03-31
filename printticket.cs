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

namespace SV2AIR
{
    public partial class printticket : Form
    {
        public printticket()
        {
            InitializeComponent();
        }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        private void printticket_Load(object sender, EventArgs e)
        {

            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();
            //i MessageBox.Show("Connectedtodatasource");
            String query = "select * from flights where flight_id ='" + Value1 + "' ";
         
             // MessageBox.Show(query);
            OracleCommand cmd2 = new OracleCommand(query, con);
            OracleDataReader reader1;
            reader1 = cmd2.ExecuteReader();

            if (reader1.HasRows)
            {

                while (reader1.Read())
                {
                    //depart from
                    
                    //pass
                    String deptfrom = reader1["dept_from"].ToString();
                    dept.Text = deptfrom;
                    //ticket
                    String deptfro = reader1["dept_from"].ToString();
                    departure.Text = deptfro;



                    ///departure date
                    //pass
                    String deptdate1 = reader1["dept_time"].ToString();
                    ddate.Text = deptdate1;
                    //ticket
                    String deptdat = reader1["dept_time"].ToString();
                    deptdate.Text = deptdat;



                    //arrive at

                    //ticket
                    String arriveat = reader1["arrive_at"].ToString();
                    arrival.Text = arriveat;

                    //pass
                    String arrive1 = reader1["arrive_at"].ToString();
                    arrive.Text = arrive1;

                }

            }
            else
            {
                MessageBox.Show("No Data In DataBase");
            }





            String query2 = "select * from passenger where user_id ='" + Value2 + "'";
            //i  MessageBox.Show(query2);
            OracleCommand cmd = new OracleCommand(query2, con);
            OracleDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                while (dr.Read())
                {//ticket
                    String pname = dr["first_name"].ToString();
                    firstname.Text = pname;

                  //  pass
                    String pname1 = dr["first_name"].ToString();
                    fname.Text = pname1;

                    //ticket
                    String lname2 = dr["last_name"].ToString();
                    lastname.Text = lname2;

                    //  pass
                    String lname3 = dr["last_name"].ToString();
                    lname.Text = lname3;



                }

            }
            else
            {
                MessageBox.Show("No Data In DataBase");
            }

        }

        private void lastname_Click(object sender, EventArgs e)
        {

        }
    }
}
