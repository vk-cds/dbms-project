namespace SV2AIR
{
    partial class printticket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printticket));
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.deptdate = new System.Windows.Forms.Label();
            this.departure = new System.Windows.Forms.Label();
            this.arrival = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.ddate = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.Label();
            this.arrive = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(47, 272);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(44, 16);
            this.firstname.TabIndex = 1;
            this.firstname.Text = "label1";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(129, 272);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(44, 16);
            this.lastname.TabIndex = 2;
            this.lastname.Text = "label2";
            this.lastname.Click += new System.EventHandler(this.lastname_Click);
            // 
            // deptdate
            // 
            this.deptdate.AutoSize = true;
            this.deptdate.Location = new System.Drawing.Point(468, 282);
            this.deptdate.Name = "deptdate";
            this.deptdate.Size = new System.Drawing.Size(44, 16);
            this.deptdate.TabIndex = 3;
            this.deptdate.Text = "label3";
            // 
            // departure
            // 
            this.departure.AutoSize = true;
            this.departure.Location = new System.Drawing.Point(118, 342);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(44, 16);
            this.departure.TabIndex = 4;
            this.departure.Text = "label4";
            // 
            // arrival
            // 
            this.arrival.AutoSize = true;
            this.arrival.Location = new System.Drawing.Point(412, 342);
            this.arrival.Name = "arrival";
            this.arrival.Size = new System.Drawing.Size(44, 16);
            this.arrival.TabIndex = 5;
            this.arrival.Text = "label5";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(696, 272);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(44, 16);
            this.fname.TabIndex = 6;
            this.fname.Text = "label6";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(783, 272);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(44, 16);
            this.lname.TabIndex = 7;
            this.lname.Text = "label7";
            // 
            // ddate
            // 
            this.ddate.AutoSize = true;
            this.ddate.Location = new System.Drawing.Point(696, 342);
            this.ddate.Name = "ddate";
            this.ddate.Size = new System.Drawing.Size(44, 16);
            this.ddate.TabIndex = 8;
            this.ddate.Text = "label8";
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.Location = new System.Drawing.Point(725, 421);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(44, 16);
            this.dept.TabIndex = 9;
            this.dept.Text = "label9";
            // 
            // arrive
            // 
            this.arrive.AutoSize = true;
            this.arrive.Location = new System.Drawing.Point(869, 421);
            this.arrive.Name = "arrive";
            this.arrive.Size = new System.Drawing.Size(51, 16);
            this.arrive.TabIndex = 10;
            this.arrive.Text = "label10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // printticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 625);
            this.Controls.Add(this.arrive);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.ddate);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.arrival);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.deptdate);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "printticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "printticket";
            this.Load += new System.EventHandler(this.printticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label deptdate;
        private System.Windows.Forms.Label departure;
        private System.Windows.Forms.Label arrival;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label ddate;
        private System.Windows.Forms.Label dept;
        private System.Windows.Forms.Label arrive;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}