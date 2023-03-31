namespace SV2AIR.AdministratorUC
{
    partial class UC_viewflights
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_viewflights));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backbutton = new Guna.UI2.WinForms.Guna2Button();
            this.dataviewflights = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fLIGHTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTFROMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVEATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new SV2AIR.DataSet2();
            this.fLIGHTSTableAdapter = new SV2AIR.DataSet2TableAdapters.FLIGHTSTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewflights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Flights";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.backbutton.Location = new System.Drawing.Point(238, 474);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(180, 45);
            this.backbutton.TabIndex = 16;
            this.backbutton.Text = "back";
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // dataviewflights
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataviewflights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataviewflights.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataviewflights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataviewflights.ColumnHeadersHeight = 18;
            this.dataviewflights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataviewflights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fLIGHTIDDataGridViewTextBoxColumn,
            this.dEPTFROMDataGridViewTextBoxColumn,
            this.dEPTTIMEDataGridViewTextBoxColumn,
            this.aRRIVEATDataGridViewTextBoxColumn,
            this.aRRIVALTIMEDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn});
            this.dataviewflights.DataSource = this.fLIGHTSBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataviewflights.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataviewflights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataviewflights.Location = new System.Drawing.Point(66, 233);
            this.dataviewflights.Name = "dataviewflights";
            this.dataviewflights.RowHeadersVisible = false;
            this.dataviewflights.RowHeadersWidth = 51;
            this.dataviewflights.RowTemplate.Height = 24;
            this.dataviewflights.Size = new System.Drawing.Size(637, 150);
            this.dataviewflights.TabIndex = 17;
            this.dataviewflights.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataviewflights.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataviewflights.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataviewflights.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataviewflights.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataviewflights.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataviewflights.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataviewflights.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataviewflights.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataviewflights.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataviewflights.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataviewflights.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataviewflights.ThemeStyle.HeaderStyle.Height = 18;
            this.dataviewflights.ThemeStyle.ReadOnly = false;
            this.dataviewflights.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataviewflights.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataviewflights.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataviewflights.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataviewflights.ThemeStyle.RowsStyle.Height = 24;
            this.dataviewflights.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataviewflights.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataviewflights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataviewflights_CellContentClick);
            // 
            // fLIGHTIDDataGridViewTextBoxColumn
            // 
            this.fLIGHTIDDataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_ID";
            this.fLIGHTIDDataGridViewTextBoxColumn.HeaderText = "FLIGHT_ID";
            this.fLIGHTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fLIGHTIDDataGridViewTextBoxColumn.Name = "fLIGHTIDDataGridViewTextBoxColumn";
            // 
            // dEPTFROMDataGridViewTextBoxColumn
            // 
            this.dEPTFROMDataGridViewTextBoxColumn.DataPropertyName = "DEPT_FROM";
            this.dEPTFROMDataGridViewTextBoxColumn.HeaderText = "DEPT_FROM";
            this.dEPTFROMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEPTFROMDataGridViewTextBoxColumn.Name = "dEPTFROMDataGridViewTextBoxColumn";
            // 
            // dEPTTIMEDataGridViewTextBoxColumn
            // 
            this.dEPTTIMEDataGridViewTextBoxColumn.DataPropertyName = "DEPT_TIME";
            this.dEPTTIMEDataGridViewTextBoxColumn.HeaderText = "DEPT_TIME";
            this.dEPTTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEPTTIMEDataGridViewTextBoxColumn.Name = "dEPTTIMEDataGridViewTextBoxColumn";
            // 
            // aRRIVEATDataGridViewTextBoxColumn
            // 
            this.aRRIVEATDataGridViewTextBoxColumn.DataPropertyName = "ARRIVE_AT";
            this.aRRIVEATDataGridViewTextBoxColumn.HeaderText = "ARRIVE_AT";
            this.aRRIVEATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aRRIVEATDataGridViewTextBoxColumn.Name = "aRRIVEATDataGridViewTextBoxColumn";
            // 
            // aRRIVALTIMEDataGridViewTextBoxColumn
            // 
            this.aRRIVALTIMEDataGridViewTextBoxColumn.DataPropertyName = "ARRIVAL_TIME";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.HeaderText = "ARRIVAL_TIME";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aRRIVALTIMEDataGridViewTextBoxColumn.Name = "aRRIVALTIMEDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // fLIGHTSBindingSource
            // 
            this.fLIGHTSBindingSource.DataMember = "FLIGHTS";
            this.fLIGHTSBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fLIGHTSTableAdapter
            // 
            this.fLIGHTSTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // UC_viewflights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataviewflights);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label1);
            this.Name = "UC_viewflights";
            this.Size = new System.Drawing.Size(718, 631);
            this.Load += new System.EventHandler(this.UC_viewflights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewflights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button backbutton;
        private Guna.UI2.WinForms.Guna2DataGridView dataviewflights;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTFROMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVEATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fLIGHTSBindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.FLIGHTSTableAdapter fLIGHTSTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
