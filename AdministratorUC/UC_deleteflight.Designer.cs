namespace SV2AIR.AdministratorUC
{
    partial class UC_deleteflight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_deleteflight));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtflightno = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonsubmit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbutton = new Guna.UI2.WinForms.Guna2Button();
            this.pricelabel = new System.Windows.Forms.Label();
            this.deptdatelabel = new System.Windows.Forms.Label();
            this.arrivaldatelabel = new System.Windows.Forms.Label();
            this.deptfromlabel = new System.Windows.Forms.Label();
            this.arrivalatlabel = new System.Windows.Forms.Label();
            this.deletebutton = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delete Flights";
            // 
            // txtflightno
            // 
            this.txtflightno.BorderRadius = 15;
            this.txtflightno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtflightno.DefaultText = "";
            this.txtflightno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtflightno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtflightno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtflightno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtflightno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtflightno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtflightno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtflightno.Location = new System.Drawing.Point(190, 139);
            this.txtflightno.Name = "txtflightno";
            this.txtflightno.PasswordChar = '\0';
            this.txtflightno.PlaceholderText = "";
            this.txtflightno.SelectedText = "";
            this.txtflightno.Size = new System.Drawing.Size(200, 36);
            this.txtflightno.TabIndex = 3;
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.BorderRadius = 15;
            this.buttonsubmit.BorderThickness = 1;
            this.buttonsubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonsubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonsubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonsubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonsubmit.FillColor = System.Drawing.Color.Firebrick;
            this.buttonsubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonsubmit.ForeColor = System.Drawing.Color.White;
            this.buttonsubmit.Location = new System.Drawing.Point(442, 139);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(142, 36);
            this.buttonsubmit.TabIndex = 4;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backbutton);
            this.panel1.Controls.Add(this.pricelabel);
            this.panel1.Controls.Add(this.deptdatelabel);
            this.panel1.Controls.Add(this.arrivaldatelabel);
            this.panel1.Controls.Add(this.deptfromlabel);
            this.panel1.Controls.Add(this.arrivalatlabel);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(32, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 336);
            this.panel1.TabIndex = 9;
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
            this.backbutton.Location = new System.Drawing.Point(99, 291);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(159, 42);
            this.backbutton.TabIndex = 16;
            this.backbutton.Text = "Back";
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.BackColor = System.Drawing.Color.White;
            this.pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel.Location = new System.Drawing.Point(257, 213);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(126, 20);
            this.pricelabel.TabIndex = 15;
            this.pricelabel.Text = "_____________";
            // 
            // deptdatelabel
            // 
            this.deptdatelabel.AutoSize = true;
            this.deptdatelabel.BackColor = System.Drawing.Color.White;
            this.deptdatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptdatelabel.Location = new System.Drawing.Point(257, 75);
            this.deptdatelabel.Name = "deptdatelabel";
            this.deptdatelabel.Size = new System.Drawing.Size(378, 20);
            this.deptdatelabel.TabIndex = 14;
            this.deptdatelabel.Text = "_________________________________________";
            // 
            // arrivaldatelabel
            // 
            this.arrivaldatelabel.AutoSize = true;
            this.arrivaldatelabel.BackColor = System.Drawing.Color.White;
            this.arrivaldatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivaldatelabel.Location = new System.Drawing.Point(264, 154);
            this.arrivaldatelabel.Name = "arrivaldatelabel";
            this.arrivaldatelabel.Size = new System.Drawing.Size(378, 20);
            this.arrivaldatelabel.TabIndex = 13;
            this.arrivaldatelabel.Text = "_________________________________________";
            // 
            // deptfromlabel
            // 
            this.deptfromlabel.AutoSize = true;
            this.deptfromlabel.BackColor = System.Drawing.Color.White;
            this.deptfromlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptfromlabel.Location = new System.Drawing.Point(49, 75);
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
            this.arrivalatlabel.Location = new System.Drawing.Point(49, 154);
            this.arrivalatlabel.Name = "arrivalatlabel";
            this.arrivalatlabel.Size = new System.Drawing.Size(126, 20);
            this.arrivalatlabel.TabIndex = 11;
            this.arrivalatlabel.Text = "_____________";
            // 
            // deletebutton
            // 
            this.deletebutton.BorderRadius = 15;
            this.deletebutton.BorderThickness = 1;
            this.deletebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deletebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deletebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deletebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deletebutton.FillColor = System.Drawing.Color.Firebrick;
            this.deletebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.deletebutton.ForeColor = System.Drawing.Color.White;
            this.deletebutton.Location = new System.Drawing.Point(388, 291);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(164, 42);
            this.deletebutton.TabIndex = 9;
            this.deletebutton.Text = "Delete";
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Departure date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Arrival date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Arrival at";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Depart from";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UC_deleteflight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.txtflightno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_deleteflight";
            this.Size = new System.Drawing.Size(718, 631);
            this.Load += new System.EventHandler(this.UC_deleteflight_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtflightno;
        private Guna.UI2.WinForms.Guna2Button buttonsubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label deptdatelabel;
        private System.Windows.Forms.Label arrivaldatelabel;
        private System.Windows.Forms.Label deptfromlabel;
        private System.Windows.Forms.Label arrivalatlabel;
        private Guna.UI2.WinForms.Guna2Button deletebutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button backbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
