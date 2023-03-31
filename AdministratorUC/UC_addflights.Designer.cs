namespace SV2AIR.AdministratorUC
{
    partial class UC_addflights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_addflights));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdepartfrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtarriveat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtdeptdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtarrivedate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtflightno = new Guna.UI2.WinForms.Guna2TextBox();
            this.backbutton = new Guna.UI2.WinForms.Guna2Button();
            this.addbutton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Flights";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depart From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arrival Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departure Name";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Arrive at";
            // 
            // txtdepartfrom
            // 
            this.txtdepartfrom.BackColor = System.Drawing.Color.Transparent;
            this.txtdepartfrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtdepartfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtdepartfrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdepartfrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdepartfrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtdepartfrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtdepartfrom.ItemHeight = 30;
            this.txtdepartfrom.Items.AddRange(new object[] {
            "bahrain",
            "Dubai",
            "London",
            "Germany",
            "Srilanka",
            "Mumbai",
            "Goa"});
            this.txtdepartfrom.Location = new System.Drawing.Point(47, 212);
            this.txtdepartfrom.Name = "txtdepartfrom";
            this.txtdepartfrom.Size = new System.Drawing.Size(224, 36);
            this.txtdepartfrom.TabIndex = 7;
            // 
            // txtarriveat
            // 
            this.txtarriveat.BackColor = System.Drawing.Color.Transparent;
            this.txtarriveat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtarriveat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtarriveat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtarriveat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtarriveat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtarriveat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtarriveat.ItemHeight = 30;
            this.txtarriveat.Items.AddRange(new object[] {
            "bahrain",
            "Dubai",
            "London",
            "Germany",
            "Srilanka",
            "Mumbai",
            "Goa"});
            this.txtarriveat.Location = new System.Drawing.Point(47, 315);
            this.txtarriveat.Name = "txtarriveat";
            this.txtarriveat.Size = new System.Drawing.Size(224, 36);
            this.txtarriveat.TabIndex = 8;
            // 
            // txtdeptdate
            // 
            this.txtdeptdate.Checked = true;
            this.txtdeptdate.FillColor = System.Drawing.Color.Salmon;
            this.txtdeptdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdeptdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdeptdate.Location = new System.Drawing.Point(310, 221);
            this.txtdeptdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdeptdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdeptdate.Name = "txtdeptdate";
            this.txtdeptdate.Size = new System.Drawing.Size(364, 36);
            this.txtdeptdate.TabIndex = 9;
            this.txtdeptdate.Value = new System.DateTime(2022, 12, 17, 12, 2, 15, 883);
            // 
            // txtarrivedate
            // 
            this.txtarrivedate.Checked = true;
            this.txtarrivedate.FillColor = System.Drawing.Color.Salmon;
            this.txtarrivedate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtarrivedate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtarrivedate.Location = new System.Drawing.Point(310, 315);
            this.txtarrivedate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtarrivedate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtarrivedate.Name = "txtarrivedate";
            this.txtarrivedate.Size = new System.Drawing.Size(364, 36);
            this.txtarrivedate.TabIndex = 10;
            this.txtarrivedate.Value = new System.DateTime(2022, 12, 17, 12, 2, 15, 883);
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
            this.txtprice.Location = new System.Drawing.Point(47, 424);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "";
            this.txtprice.SelectedText = "";
            this.txtprice.Size = new System.Drawing.Size(200, 36);
            this.txtprice.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Flight no";
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
            this.txtflightno.Location = new System.Drawing.Point(205, 107);
            this.txtflightno.Name = "txtflightno";
            this.txtflightno.PasswordChar = '\0';
            this.txtflightno.PlaceholderText = "";
            this.txtflightno.SelectedText = "";
            this.txtflightno.Size = new System.Drawing.Size(200, 36);
            this.txtflightno.TabIndex = 13;
            // 
            // backbutton
            // 
            this.backbutton.BorderRadius = 19;
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
            this.backbutton.Location = new System.Drawing.Point(47, 492);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(180, 45);
            this.backbutton.TabIndex = 14;
            this.backbutton.Text = "back";
            this.backbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.BorderRadius = 19;
            this.addbutton.BorderThickness = 1;
            this.addbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addbutton.FillColor = System.Drawing.Color.Firebrick;
            this.addbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.HoverState.FillColor = System.Drawing.Color.White;
            this.addbutton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.addbutton.Location = new System.Drawing.Point(276, 492);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(180, 45);
            this.addbutton.TabIndex = 15;
            this.addbutton.Text = "add flight";
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 76);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // UC_addflights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.txtflightno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtarrivedate);
            this.Controls.Add(this.txtdeptdate);
            this.Controls.Add(this.txtarriveat);
            this.Controls.Add(this.txtdepartfrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_addflights";
            this.Size = new System.Drawing.Size(718, 631);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox txtarriveat;
        private Guna.UI2.WinForms.Guna2ComboBox txtdepartfrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtarrivedate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdeptdate;
        private Guna.UI2.WinForms.Guna2Button addbutton;
        private Guna.UI2.WinForms.Guna2Button backbutton;
        private Guna.UI2.WinForms.Guna2TextBox txtflightno;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
