namespace SV2AIR.PassengerUC
{
    partial class UC_booktickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_booktickets));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdeparton = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dataSet2 = new SV2AIR.DataSet2();
            this.fLIGHTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTSTableAdapter = new SV2AIR.DataSet2TableAdapters.FLIGHTSTableAdapter();
            this.searchbutton = new Guna.UI2.WinForms.Guna2Button();
            this.fLIGHTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtflightno = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.fLIGHTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTFROMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVEATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookbutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTSBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Ticket";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "To";
            // 
            // txtfrom
            // 
            this.txtfrom.BackColor = System.Drawing.Color.Transparent;
            this.txtfrom.BorderRadius = 18;
            this.txtfrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtfrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtfrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtfrom.ItemHeight = 30;
            this.txtfrom.Items.AddRange(new object[] {
            "bahrain",
            "Dubai",
            "London",
            "Germany",
            "Srilanka",
            "Mumbai",
            "Goa"});
            this.txtfrom.Location = new System.Drawing.Point(69, 119);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(233, 36);
            this.txtfrom.TabIndex = 33;
            // 
            // txtto
            // 
            this.txtto.BackColor = System.Drawing.Color.Transparent;
            this.txtto.BorderRadius = 18;
            this.txtto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtto.ItemHeight = 30;
            this.txtto.Items.AddRange(new object[] {
            "bahrain",
            "Dubai",
            "London",
            "Germany",
            "Srilanka",
            "Mumbai",
            "Goa"});
            this.txtto.Location = new System.Drawing.Point(396, 119);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(233, 36);
            this.txtto.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Depart on ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtdeparton
            // 
            this.txtdeparton.BackColor = System.Drawing.Color.Transparent;
            this.txtdeparton.BorderRadius = 20;
            this.txtdeparton.Checked = true;
            this.txtdeparton.FillColor = System.Drawing.Color.Firebrick;
            this.txtdeparton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeparton.ForeColor = System.Drawing.SystemColors.Control;
            this.txtdeparton.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdeparton.Location = new System.Drawing.Point(69, 204);
            this.txtdeparton.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdeparton.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdeparton.Name = "txtdeparton";
            this.txtdeparton.Size = new System.Drawing.Size(323, 45);
            this.txtdeparton.TabIndex = 36;
            this.txtdeparton.Value = new System.DateTime(2022, 12, 17, 23, 21, 43, 579);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fLIGHTSBindingSource
            // 
            this.fLIGHTSBindingSource.DataMember = "FLIGHTS";
            this.fLIGHTSBindingSource.DataSource = this.dataSet2;
            // 
            // fLIGHTSTableAdapter
            // 
            this.fLIGHTSTableAdapter.ClearBeforeFill = true;
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Transparent;
            this.searchbutton.BorderRadius = 19;
            this.searchbutton.BorderThickness = 1;
            this.searchbutton.CheckedState.FillColor = System.Drawing.Color.LightCoral;
            this.searchbutton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.searchbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchbutton.FillColor = System.Drawing.Color.IndianRed;
            this.searchbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.searchbutton.ForeColor = System.Drawing.Color.White;
            this.searchbutton.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.searchbutton.HoverState.ForeColor = System.Drawing.Color.White;
            this.searchbutton.Location = new System.Drawing.Point(449, 204);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(180, 45);
            this.searchbutton.TabIndex = 39;
            this.searchbutton.Text = "Search";
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // fLIGHTSBindingSource1
            // 
            this.fLIGHTSBindingSource1.DataMember = "FLIGHTS";
            this.fLIGHTSBindingSource1.DataSource = this.dataSet2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Enter flight no to select flight :";
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
            this.txtflightno.Location = new System.Drawing.Point(380, 190);
            this.txtflightno.Name = "txtflightno";
            this.txtflightno.PasswordChar = '\0';
            this.txtflightno.PlaceholderText = "";
            this.txtflightno.SelectedText = "";
            this.txtflightno.Size = new System.Drawing.Size(200, 36);
            this.txtflightno.TabIndex = 42;
            this.txtflightno.TextChanged += new System.EventHandler(this.txtflightno_TextChanged);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.datagrid);
            this.panel1.Controls.Add(this.bookbutton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtflightno);
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 350);
            this.panel1.TabIndex = 44;
            // 
            // datagrid
            // 
            this.datagrid.AutoGenerateColumns = false;
            this.datagrid.BackgroundColor = System.Drawing.Color.White;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fLIGHTIDDataGridViewTextBoxColumn,
            this.dEPTFROMDataGridViewTextBoxColumn,
            this.dEPTTIMEDataGridViewTextBoxColumn,
            this.aRRIVEATDataGridViewTextBoxColumn,
            this.aRRIVALTIMEDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn});
            this.datagrid.DataSource = this.fLIGHTSBindingSource2;
            this.datagrid.Location = new System.Drawing.Point(31, 3);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(657, 150);
            this.datagrid.TabIndex = 45;
            // 
            // fLIGHTIDDataGridViewTextBoxColumn
            // 
            this.fLIGHTIDDataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_ID";
            this.fLIGHTIDDataGridViewTextBoxColumn.HeaderText = "FLIGHT_ID";
            this.fLIGHTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fLIGHTIDDataGridViewTextBoxColumn.Name = "fLIGHTIDDataGridViewTextBoxColumn";
            this.fLIGHTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dEPTFROMDataGridViewTextBoxColumn
            // 
            this.dEPTFROMDataGridViewTextBoxColumn.DataPropertyName = "DEPT_FROM";
            this.dEPTFROMDataGridViewTextBoxColumn.HeaderText = "DEPT_FROM";
            this.dEPTFROMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEPTFROMDataGridViewTextBoxColumn.Name = "dEPTFROMDataGridViewTextBoxColumn";
            this.dEPTFROMDataGridViewTextBoxColumn.Width = 125;
            // 
            // dEPTTIMEDataGridViewTextBoxColumn
            // 
            this.dEPTTIMEDataGridViewTextBoxColumn.DataPropertyName = "DEPT_TIME";
            this.dEPTTIMEDataGridViewTextBoxColumn.HeaderText = "DEPT_TIME";
            this.dEPTTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEPTTIMEDataGridViewTextBoxColumn.Name = "dEPTTIMEDataGridViewTextBoxColumn";
            this.dEPTTIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aRRIVEATDataGridViewTextBoxColumn
            // 
            this.aRRIVEATDataGridViewTextBoxColumn.DataPropertyName = "ARRIVE_AT";
            this.aRRIVEATDataGridViewTextBoxColumn.HeaderText = "ARRIVE_AT";
            this.aRRIVEATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aRRIVEATDataGridViewTextBoxColumn.Name = "aRRIVEATDataGridViewTextBoxColumn";
            this.aRRIVEATDataGridViewTextBoxColumn.Width = 125;
            // 
            // aRRIVALTIMEDataGridViewTextBoxColumn
            // 
            this.aRRIVALTIMEDataGridViewTextBoxColumn.DataPropertyName = "ARRIVAL_TIME";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.HeaderText = "ARRIVAL_TIME";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aRRIVALTIMEDataGridViewTextBoxColumn.Name = "aRRIVALTIMEDataGridViewTextBoxColumn";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // fLIGHTSBindingSource2
            // 
            this.fLIGHTSBindingSource2.DataMember = "FLIGHTS";
            this.fLIGHTSBindingSource2.DataSource = this.dataSet2;
            // 
            // bookbutton
            // 
            this.bookbutton.BorderRadius = 19;
            this.bookbutton.BorderThickness = 1;
            this.bookbutton.CheckedState.FillColor = System.Drawing.Color.LightCoral;
            this.bookbutton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bookbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookbutton.FillColor = System.Drawing.Color.IndianRed;
            this.bookbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bookbutton.ForeColor = System.Drawing.Color.White;
            this.bookbutton.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.bookbutton.HoverState.ForeColor = System.Drawing.Color.White;
            this.bookbutton.Location = new System.Drawing.Point(253, 267);
            this.bookbutton.Name = "bookbutton";
            this.bookbutton.Size = new System.Drawing.Size(180, 45);
            this.bookbutton.TabIndex = 44;
            this.bookbutton.Text = "Book";
            this.bookbutton.Click += new System.EventHandler(this.bookbutton_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 87);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // UC_booktickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.txtdeparton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "UC_booktickets";
            this.Size = new System.Drawing.Size(718, 631);
            this.Load += new System.EventHandler(this.UC_booktickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTSBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox txtfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox txtto;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdeparton;
        private System.Windows.Forms.BindingSource fLIGHTSBindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.FLIGHTSTableAdapter fLIGHTSTableAdapter;
        private Guna.UI2.WinForms.Guna2Button searchbutton;
        private System.Windows.Forms.BindingSource fLIGHTSBindingSource1;
        private Guna.UI2.WinForms.Guna2TextBox txtflightno;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button bookbutton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTFROMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVEATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fLIGHTSBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox1;
        //   private UC_customerbookregister uC_customerbookregister1;
    }
}
