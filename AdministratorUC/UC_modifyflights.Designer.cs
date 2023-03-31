namespace SV2AIR.AdministratorUC
{
    partial class UC_modifyflights
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_modifyflights));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtflightno = new Guna.UI2.WinForms.Guna2TextBox();
            this.submitbutton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbutton = new Guna.UI2.WinForms.Guna2Button();
            this.txtdt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.deptfromlabel = new System.Windows.Forms.Label();
            this.arrivalatlabel = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdeptdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update flight info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter flight no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter date of flight";
            // 
            // txtflightno
            // 
            this.txtflightno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtflightno.DefaultText = "";
            this.txtflightno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtflightno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtflightno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtflightno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtflightno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtflightno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtflightno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtflightno.Location = new System.Drawing.Point(270, 114);
            this.txtflightno.Name = "txtflightno";
            this.txtflightno.PasswordChar = '\0';
            this.txtflightno.PlaceholderText = "";
            this.txtflightno.SelectedText = "";
            this.txtflightno.Size = new System.Drawing.Size(397, 36);
            this.txtflightno.TabIndex = 6;
            this.txtflightno.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // submitbutton
            // 
            this.submitbutton.BorderRadius = 15;
            this.submitbutton.BorderThickness = 1;
            this.submitbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitbutton.FillColor = System.Drawing.Color.Firebrick;
            this.submitbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.submitbutton.ForeColor = System.Drawing.Color.White;
            this.submitbutton.Location = new System.Drawing.Point(261, 224);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(180, 45);
            this.submitbutton.TabIndex = 7;
            this.submitbutton.Text = "submit";
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backbutton);
            this.panel1.Controls.Add(this.txtdt);
            this.panel1.Controls.Add(this.txtat);
            this.panel1.Controls.Add(this.deptfromlabel);
            this.panel1.Controls.Add(this.arrivalatlabel);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(28, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 336);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // backbutton
            // 
            this.backbutton.BorderRadius = 15;
            this.backbutton.BorderThickness = 1;
            this.backbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backbutton.FillColor = System.Drawing.Color.Firebrick;
            this.backbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.White;
            this.backbutton.HoverState.FillColor = System.Drawing.Color.White;
            this.backbutton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.backbutton.Location = new System.Drawing.Point(27, 288);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(180, 45);
            this.backbutton.TabIndex = 15;
            this.backbutton.Text = "back";
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // txtdt
            // 
            this.txtdt.Checked = true;
            this.txtdt.FillColor = System.Drawing.Color.Salmon;
            this.txtdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdt.Location = new System.Drawing.Point(214, 177);
            this.txtdt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(373, 36);
            this.txtdt.TabIndex = 10;
            this.txtdt.Value = new System.DateTime(2022, 12, 17, 15, 58, 1, 64);
            // 
            // txtat
            // 
            this.txtat.Checked = true;
            this.txtat.FillColor = System.Drawing.Color.Salmon;
            this.txtat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtat.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtat.Location = new System.Drawing.Point(213, 238);
            this.txtat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtat.Name = "txtat";
            this.txtat.Size = new System.Drawing.Size(374, 36);
            this.txtat.TabIndex = 11;
            this.txtat.Value = new System.DateTime(2022, 12, 17, 15, 58, 1, 64);
            // 
            // deptfromlabel
            // 
            this.deptfromlabel.AutoSize = true;
            this.deptfromlabel.BackColor = System.Drawing.Color.White;
            this.deptfromlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptfromlabel.Location = new System.Drawing.Point(209, 47);
            this.deptfromlabel.Name = "deptfromlabel";
            this.deptfromlabel.Size = new System.Drawing.Size(126, 20);
            this.deptfromlabel.TabIndex = 12;
            this.deptfromlabel.Text = "_____________";
            // 
            // arrivalatlabel
            // 
            this.arrivalatlabel.AutoSize = true;
            this.arrivalatlabel.BackColor = System.Drawing.Color.White;
            this.arrivalatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalatlabel.Location = new System.Drawing.Point(210, 95);
            this.arrivalatlabel.Name = "arrivalatlabel";
            this.arrivalatlabel.Size = new System.Drawing.Size(126, 20);
            this.arrivalatlabel.TabIndex = 11;
            this.arrivalatlabel.Text = "_____________";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Firebrick;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(373, 288);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "UPDATE";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtprice
            // 
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Location = new System.Drawing.Point(213, 135);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "enter the price";
            this.txtprice.SelectedText = "";
            this.txtprice.Size = new System.Drawing.Size(200, 36);
            this.txtprice.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Departure time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Arrival time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Arrival at";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Departure from";
            // 
            // txtdeptdate
            // 
            this.txtdeptdate.Checked = true;
            this.txtdeptdate.FillColor = System.Drawing.Color.Salmon;
            this.txtdeptdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdeptdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdeptdate.Location = new System.Drawing.Point(270, 161);
            this.txtdeptdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdeptdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdeptdate.Name = "txtdeptdate";
            this.txtdeptdate.Size = new System.Drawing.Size(397, 36);
            this.txtdeptdate.TabIndex = 9;
            this.txtdeptdate.Value = new System.DateTime(2022, 12, 17, 15, 58, 1, 64);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(321, 22);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(346, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 10;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UC_modifyflights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.txtdeptdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.txtflightno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_modifyflights";
            this.Size = new System.Drawing.Size(714, 631);
            this.Load += new System.EventHandler(this.UC_modifyflights_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button submitbutton;
        private Guna.UI2.WinForms.Guna2TextBox txtflightno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label arrivalatlabel;
        private System.Windows.Forms.Label deptfromlabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdeptdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdt;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtat;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2Button backbutton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
