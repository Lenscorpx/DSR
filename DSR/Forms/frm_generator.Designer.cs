namespace DSR.Forms
{
    partial class frm_generator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_generator));
            this.label1 = new System.Windows.Forms.Label();
            this._Client_List = new System.Windows.Forms.ListBox();
            this.dtgrid_generator = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._dt_stop_hour = new System.Windows.Forms.DateTimePicker();
            this._dt_start_hour = new System.Windows.Forms.DateTimePicker();
            this._txt_id_client = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._dt_manning_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this._txt_receipts = new System.Windows.Forms.TextBox();
            this._txt_id_rec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_generator)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 14);
            this.label1.TabIndex = 106;
            this.label1.Text = "CLIENT LIST (Choose a client)";
            // 
            // _Client_List
            // 
            this._Client_List.BackColor = System.Drawing.Color.Black;
            this._Client_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Client_List.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Client_List.ForeColor = System.Drawing.Color.DodgerBlue;
            this._Client_List.FormattingEnabled = true;
            this._Client_List.ItemHeight = 15;
            this._Client_List.Location = new System.Drawing.Point(12, 28);
            this._Client_List.Name = "_Client_List";
            this._Client_List.Size = new System.Drawing.Size(240, 197);
            this._Client_List.TabIndex = 105;
            this._Client_List.SelectedIndexChanged += new System.EventHandler(this._Client_List_SelectedIndexChanged);
            // 
            // dtgrid_generator
            // 
            this.dtgrid_generator.AllowUserToAddRows = false;
            this.dtgrid_generator.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgrid_generator.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrid_generator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_generator.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrid_generator.BackgroundColor = System.Drawing.Color.Black;
            this.dtgrid_generator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_generator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrid_generator.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_generator.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrid_generator.EnableHeadersVisualStyles = false;
            this.dtgrid_generator.GridColor = System.Drawing.Color.White;
            this.dtgrid_generator.Location = new System.Drawing.Point(12, 265);
            this.dtgrid_generator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgrid_generator.Name = "dtgrid_generator";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_generator.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgrid_generator.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgrid_generator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_generator.Size = new System.Drawing.Size(860, 251);
            this.dtgrid_generator.TabIndex = 104;
            this.dtgrid_generator.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_generator_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this._dt_stop_hour);
            this.groupBox1.Controls.Add(this._dt_start_hour);
            this.groupBox1.Controls.Add(this._txt_id_client);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._dt_manning_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txt_receipts);
            this.groupBox1.Controls.Add(this._txt_id_rec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(258, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 213);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generator\'s Informations";
            // 
            // _dt_stop_hour
            // 
            this._dt_stop_hour.CalendarMonthBackground = System.Drawing.Color.Black;
            this._dt_stop_hour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._dt_stop_hour.Location = new System.Drawing.Point(105, 139);
            this._dt_stop_hour.Name = "_dt_stop_hour";
            this._dt_stop_hour.Size = new System.Drawing.Size(200, 23);
            this._dt_stop_hour.TabIndex = 114;
            // 
            // _dt_start_hour
            // 
            this._dt_start_hour.CalendarMonthBackground = System.Drawing.Color.Black;
            this._dt_start_hour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._dt_start_hour.Location = new System.Drawing.Point(105, 112);
            this._dt_start_hour.Name = "_dt_start_hour";
            this._dt_start_hour.Size = new System.Drawing.Size(200, 23);
            this._dt_start_hour.TabIndex = 113;
            // 
            // _txt_id_client
            // 
            this._txt_id_client.BackColor = System.Drawing.Color.Black;
            this._txt_id_client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txt_id_client.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._txt_id_client.Enabled = false;
            this._txt_id_client.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txt_id_client.ForeColor = System.Drawing.Color.White;
            this._txt_id_client.Location = new System.Drawing.Point(104, 58);
            this._txt_id_client.Margin = new System.Windows.Forms.Padding(2);
            this._txt_id_client.Name = "_txt_id_client";
            this._txt_id_client.Size = new System.Drawing.Size(201, 23);
            this._txt_id_client.TabIndex = 112;
            this._txt_id_client.TextChanged += new System.EventHandler(this._txt_id_client_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 110;
            this.label10.Text = "CLIENT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 108;
            this.label8.Text = "DATE";
            // 
            // _dt_manning_date
            // 
            this._dt_manning_date.CalendarMonthBackground = System.Drawing.Color.Black;
            this._dt_manning_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dt_manning_date.Location = new System.Drawing.Point(104, 85);
            this._dt_manning_date.Name = "_dt_manning_date";
            this._dt_manning_date.Size = new System.Drawing.Size(200, 23);
            this._dt_manning_date.TabIndex = 107;
            this._dt_manning_date.ValueChanged += new System.EventHandler(this._dt_manning_date_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 104;
            this.label2.Text = "REC ID.";
            // 
            // _txt_receipts
            // 
            this._txt_receipts.BackColor = System.Drawing.Color.White;
            this._txt_receipts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txt_receipts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._txt_receipts.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txt_receipts.ForeColor = System.Drawing.Color.Black;
            this._txt_receipts.Location = new System.Drawing.Point(104, 167);
            this._txt_receipts.Margin = new System.Windows.Forms.Padding(2);
            this._txt_receipts.Name = "_txt_receipts";
            this._txt_receipts.Size = new System.Drawing.Size(201, 23);
            this._txt_receipts.TabIndex = 101;
            // 
            // _txt_id_rec
            // 
            this._txt_id_rec.BackColor = System.Drawing.Color.Black;
            this._txt_id_rec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txt_id_rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._txt_id_rec.Enabled = false;
            this._txt_id_rec.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txt_id_rec.ForeColor = System.Drawing.Color.White;
            this._txt_id_rec.Location = new System.Drawing.Point(104, 30);
            this._txt_id_rec.Margin = new System.Windows.Forms.Padding(2);
            this._txt_id_rec.Name = "_txt_id_rec";
            this._txt_id_rec.Size = new System.Drawing.Size(201, 23);
            this._txt_id_rec.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 98;
            this.label4.Text = "START HOUR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 99;
            this.label5.Text = "STOP HOUR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 100;
            this.label6.Text = "RECEIPTS";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(736, 230);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(136, 30);
            this.btn_delete.TabIndex = 115;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_update.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(594, 230);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(136, 30);
            this.btn_update.TabIndex = 114;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.Transparent;
            this.btn_insert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_insert.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_insert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(452, 230);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(136, 31);
            this.btn_insert.TabIndex = 113;
            this.btn_insert.Text = "ADD";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DSR.Properties.Resources.electro_group;
            this.pictureBox1.Location = new System.Drawing.Point(580, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // frm_generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._Client_List);
            this.Controls.Add(this.dtgrid_generator);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_generator";
            this.Opacity = 0.96D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator ";
            this.Load += new System.EventHandler(this.frm_generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_generator)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox _Client_List;
        private System.Windows.Forms.DataGridView dtgrid_generator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txt_id_client;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker _dt_manning_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txt_receipts;
        private System.Windows.Forms.TextBox _txt_id_rec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DateTimePicker _dt_stop_hour;
        private System.Windows.Forms.DateTimePicker _dt_start_hour;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}