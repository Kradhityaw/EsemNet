namespace D1_KEVIND_RADHITYA_WICAKSONO
{
    partial class UCMasterPaket
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
            System.Windows.Forms.Label hargaPerJamLabel;
            System.Windows.Forms.Label iDJenisLabel;
            System.Windows.Forms.Label namaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.paketDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hargaPerJamNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDJenisComboBox = new System.Windows.Forms.ComboBox();
            this.jeniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            hargaPerJamLabel = new System.Windows.Forms.Label();
            iDJenisLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hargaPerJamNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jeniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hargaPerJamLabel
            // 
            hargaPerJamLabel.AutoSize = true;
            hargaPerJamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hargaPerJamLabel.Location = new System.Drawing.Point(39, 584);
            hargaPerJamLabel.Name = "hargaPerJamLabel";
            hargaPerJamLabel.Size = new System.Drawing.Size(148, 28);
            hargaPerJamLabel.TabIndex = 2;
            hargaPerJamLabel.Text = "Harga Per Jam:";
            // 
            // iDJenisLabel
            // 
            iDJenisLabel.AutoSize = true;
            iDJenisLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDJenisLabel.Location = new System.Drawing.Point(544, 460);
            iDJenisLabel.Name = "iDJenisLabel";
            iDJenisLabel.Size = new System.Drawing.Size(62, 28);
            iDJenisLabel.TabIndex = 4;
            iDJenisLabel.Text = "Jenis:";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            namaLabel.Location = new System.Drawing.Point(39, 460);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(70, 28);
            namaLabel.TabIndex = 6;
            namaLabel.Text = "Nama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Paket";
            // 
            // paketDataGridView
            // 
            this.paketDataGridView.AllowUserToAddRows = false;
            this.paketDataGridView.AllowUserToDeleteRows = false;
            this.paketDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paketDataGridView.AutoGenerateColumns = false;
            this.paketDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paketDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.paketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.JenisCol,
            this.hargaCol,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.paketDataGridView.DataSource = this.paketBindingSource;
            this.paketDataGridView.Location = new System.Drawing.Point(44, 107);
            this.paketDataGridView.Name = "paketDataGridView";
            this.paketDataGridView.ReadOnly = true;
            this.paketDataGridView.RowHeadersVisible = false;
            this.paketDataGridView.RowHeadersWidth = 72;
            this.paketDataGridView.RowTemplate.Height = 31;
            this.paketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paketDataGridView.Size = new System.Drawing.Size(955, 276);
            this.paketDataGridView.TabIndex = 2;
            this.paketDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.paketDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // JenisCol
            // 
            this.JenisCol.DataPropertyName = "IDJenis";
            this.JenisCol.HeaderText = "Jenis";
            this.JenisCol.MinimumWidth = 9;
            this.JenisCol.Name = "JenisCol";
            this.JenisCol.ReadOnly = true;
            // 
            // hargaCol
            // 
            this.hargaCol.DataPropertyName = "HargaPerJam";
            this.hargaCol.HeaderText = "HargaPerJam";
            this.hargaCol.MinimumWidth = 9;
            this.hargaCol.Name = "hargaCol";
            this.hargaCol.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Jeni";
            this.dataGridViewTextBoxColumn5.HeaderText = "Jeni";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Transaksis";
            this.dataGridViewTextBoxColumn6.HeaderText = "Transaksis";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // paketBindingSource
            // 
            this.paketBindingSource.DataSource = typeof(D1_KEVIND_RADHITYA_WICAKSONO.Paket);
            // 
            // hargaPerJamNumericUpDown
            // 
            this.hargaPerJamNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "HargaPerJam", true));
            this.hargaPerJamNumericUpDown.Enabled = false;
            this.hargaPerJamNumericUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaPerJamNumericUpDown.Location = new System.Drawing.Point(40, 632);
            this.hargaPerJamNumericUpDown.Name = "hargaPerJamNumericUpDown";
            this.hargaPerJamNumericUpDown.Size = new System.Drawing.Size(406, 42);
            this.hargaPerJamNumericUpDown.TabIndex = 3;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(D1_KEVIND_RADHITYA_WICAKSONO.Paket);
            // 
            // iDJenisComboBox
            // 
            this.iDJenisComboBox.DataSource = this.jeniBindingSource;
            this.iDJenisComboBox.DisplayMember = "Jenis";
            this.iDJenisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iDJenisComboBox.Enabled = false;
            this.iDJenisComboBox.FormattingEnabled = true;
            this.iDJenisComboBox.Location = new System.Drawing.Point(549, 508);
            this.iDJenisComboBox.Name = "iDJenisComboBox";
            this.iDJenisComboBox.Size = new System.Drawing.Size(358, 32);
            this.iDJenisComboBox.TabIndex = 5;
            this.iDJenisComboBox.ValueMember = "ID";
            // 
            // jeniBindingSource
            // 
            this.jeniBindingSource.DataSource = typeof(D1_KEVIND_RADHITYA_WICAKSONO.Jeni);
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Nama", true));
            this.namaTextBox.Enabled = false;
            this.namaTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaTextBox.Location = new System.Drawing.Point(44, 503);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(406, 42);
            this.namaTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(530, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hapus";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(692, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(854, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "Tambah";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(562, 621);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 53);
            this.button4.TabIndex = 11;
            this.button4.Text = "Batal";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(724, 621);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 53);
            this.button5.TabIndex = 12;
            this.button5.Text = "Simpan";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(549, 559);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 29);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Kosongkan Jenis";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UCMasterPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(hargaPerJamLabel);
            this.Controls.Add(this.hargaPerJamNumericUpDown);
            this.Controls.Add(iDJenisLabel);
            this.Controls.Add(this.iDJenisComboBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(this.paketDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "UCMasterPaket";
            this.Size = new System.Drawing.Size(1041, 888);
            this.Load += new System.EventHandler(this.UCMasterPaket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hargaPerJamNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jeniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource paketBindingSource;
        private System.Windows.Forms.DataGridView paketDataGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.NumericUpDown hargaPerJamNumericUpDown;
        private System.Windows.Forms.ComboBox iDJenisComboBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource jeniBindingSource;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
