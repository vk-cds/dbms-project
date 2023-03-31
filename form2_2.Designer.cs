namespace SV2AIR
{
    partial class form2_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form2_2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelbutton = new Guna.UI2.WinForms.Guna2Button();
            this.button5 = new Guna.UI2.WinForms.Guna2Button();
            this.bookbutton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_booktickets1 = new SV2AIR.PassengerUC.UC_booktickets();
            this.uC_cancelTicket1 = new SV2AIR.PassengerUC.UC_cancelTicket();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.cancelbutton);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.bookbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 631);
            this.panel1.TabIndex = 1;
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.Transparent;
            this.cancelbutton.BorderRadius = 12;
            this.cancelbutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cancelbutton.CheckedState.FillColor = System.Drawing.Color.LightCoral;
            this.cancelbutton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.cancelbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelbutton.FillColor = System.Drawing.SystemColors.ControlLight;
            this.cancelbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.ForeColor = System.Drawing.Color.Black;
            this.cancelbutton.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.cancelbutton.HoverState.ForeColor = System.Drawing.Color.White;
            this.cancelbutton.Location = new System.Drawing.Point(63, 437);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(180, 45);
            this.cancelbutton.TabIndex = 8;
            this.cancelbutton.Text = "Cancel Ticket";
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BorderRadius = 12;
            this.button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button5.CheckedState.FillColor = System.Drawing.Color.LightCoral;
            this.button5.CheckedState.ForeColor = System.Drawing.Color.White;
            this.button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button5.FillColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.button5.HoverState.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(63, 521);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "Logout";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bookbutton
            // 
            this.bookbutton.BackColor = System.Drawing.Color.Transparent;
            this.bookbutton.BorderRadius = 12;
            this.bookbutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bookbutton.CheckedState.FillColor = System.Drawing.Color.LightCoral;
            this.bookbutton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bookbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookbutton.FillColor = System.Drawing.SystemColors.ControlLight;
            this.bookbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookbutton.ForeColor = System.Drawing.Color.Black;
            this.bookbutton.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.bookbutton.HoverState.ForeColor = System.Drawing.Color.White;
            this.bookbutton.Location = new System.Drawing.Point(63, 355);
            this.bookbutton.Name = "bookbutton";
            this.bookbutton.Size = new System.Drawing.Size(180, 45);
            this.bookbutton.TabIndex = 3;
            this.bookbutton.Text = "Book Tickets";
            this.bookbutton.Click += new System.EventHandler(this.bookbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passenger";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_booktickets1);
            this.panel2.Controls.Add(this.uC_cancelTicket1);
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 628);
            this.panel2.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_booktickets1
            // 
            this.uC_booktickets1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.uC_booktickets1.BackColor = System.Drawing.Color.White;
            this.uC_booktickets1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_booktickets1.Location = new System.Drawing.Point(-2, 0);
            this.uC_booktickets1.Name = "uC_booktickets1";
            this.uC_booktickets1.Size = new System.Drawing.Size(718, 631);
            this.uC_booktickets1.TabIndex = 4;
            this.uC_booktickets1.Value1 = null;
            // 
            // uC_cancelTicket1
            // 
            this.uC_cancelTicket1.Location = new System.Drawing.Point(-2, 0);
            this.uC_cancelTicket1.Name = "uC_cancelTicket1";
            this.uC_cancelTicket1.Size = new System.Drawing.Size(718, 631);
            this.uC_cancelTicket1.TabIndex = 3;
            // 
            // form2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "form2_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form2_2";
            this.Load += new System.EventHandler(this.form2_2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button cancelbutton;
        private Guna.UI2.WinForms.Guna2Button button5;
        private Guna.UI2.WinForms.Guna2Button bookbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PassengerUC.UC_booktickets uC_booktickets1;
        private PassengerUC.UC_cancelTicket uC_cancelTicket1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        //private PassengerUC.UC_printtick uC_printtick1;
        //   private PassengerUC.UC_printticket uC_printticket1;
        //  private PassengerUC.UC_updateticket uC_updateticket1;
        // private PassengerUC.UC_register uC_register1;
    }
}