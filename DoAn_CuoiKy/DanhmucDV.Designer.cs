namespace DoAn_CuoiKy
{
    partial class DanhmucDV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clntenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clngia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonXoaDV = new System.Windows.Forms.Button();
            this.buttonSuaDV = new System.Windows.Forms.Button();
            this.buttonThemDV = new System.Windows.Forms.Button();
            this.textBoxTenDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGiaDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaDV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln,
            this.clntenDV,
            this.clngia});
            this.dataGridView1.Location = new System.Drawing.Point(34, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(442, 321);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cln
            // 
            this.cln.HeaderText = "Mã dịch vụ";
            this.cln.MinimumWidth = 6;
            this.cln.Name = "cln";
            this.cln.Width = 125;
            // 
            // clntenDV
            // 
            this.clntenDV.HeaderText = "Tên dịch vụ";
            this.clntenDV.MinimumWidth = 6;
            this.clntenDV.Name = "clntenDV";
            this.clntenDV.Width = 125;
            // 
            // clngia
            // 
            this.clngia.HeaderText = "Giá dịch vụ";
            this.clngia.MinimumWidth = 6;
            this.clngia.Name = "clngia";
            this.clngia.Width = 125;
            // 
            // buttonXoaDV
            // 
            this.buttonXoaDV.BackColor = System.Drawing.Color.Silver;
            this.buttonXoaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaDV.Location = new System.Drawing.Point(444, 119);
            this.buttonXoaDV.Name = "buttonXoaDV";
            this.buttonXoaDV.Size = new System.Drawing.Size(105, 38);
            this.buttonXoaDV.TabIndex = 7;
            this.buttonXoaDV.Text = "Xóa";
            this.buttonXoaDV.UseVisualStyleBackColor = false;
            this.buttonXoaDV.Click += new System.EventHandler(this.buttonXoaDV_Click);
            // 
            // buttonSuaDV
            // 
            this.buttonSuaDV.BackColor = System.Drawing.Color.Silver;
            this.buttonSuaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaDV.Location = new System.Drawing.Point(248, 119);
            this.buttonSuaDV.Name = "buttonSuaDV";
            this.buttonSuaDV.Size = new System.Drawing.Size(105, 38);
            this.buttonSuaDV.TabIndex = 6;
            this.buttonSuaDV.Text = "Sửa";
            this.buttonSuaDV.UseVisualStyleBackColor = false;
            this.buttonSuaDV.Click += new System.EventHandler(this.buttonSuaDV_Click);
            // 
            // buttonThemDV
            // 
            this.buttonThemDV.BackColor = System.Drawing.Color.Silver;
            this.buttonThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemDV.Location = new System.Drawing.Point(61, 119);
            this.buttonThemDV.Name = "buttonThemDV";
            this.buttonThemDV.Size = new System.Drawing.Size(105, 38);
            this.buttonThemDV.TabIndex = 5;
            this.buttonThemDV.Text = "Thêm";
            this.buttonThemDV.UseVisualStyleBackColor = false;
            this.buttonThemDV.Click += new System.EventHandler(this.buttonThemDV_Click);
            // 
            // textBoxTenDV
            // 
            this.textBoxTenDV.Location = new System.Drawing.Point(130, 110);
            this.textBoxTenDV.Name = "textBoxTenDV";
            this.textBoxTenDV.Size = new System.Drawing.Size(172, 27);
            this.textBoxTenDV.TabIndex = 10;
            this.textBoxTenDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTenDV_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Giá dịch vụ";
            // 
            // textBoxGiaDV
            // 
            this.textBoxGiaDV.Location = new System.Drawing.Point(130, 171);
            this.textBoxGiaDV.Name = "textBoxGiaDV";
            this.textBoxGiaDV.Size = new System.Drawing.Size(172, 27);
            this.textBoxGiaDV.TabIndex = 12;
            this.textBoxGiaDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DanhmucDV_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã dịch vụ";
            // 
            // textBoxMaDV
            // 
            this.textBoxMaDV.Location = new System.Drawing.Point(130, 52);
            this.textBoxMaDV.Name = "textBoxMaDV";
            this.textBoxMaDV.Size = new System.Drawing.Size(172, 27);
            this.textBoxMaDV.TabIndex = 14;
            this.textBoxMaDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DanhmucDV_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxMaDV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxGiaDV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxTenDV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(503, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 317);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Danh Sách Thông Tin Dịch Vụ";
            // 
            // DanhmucDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonXoaDV);
            this.Controls.Add(this.buttonSuaDV);
            this.Controls.Add(this.buttonThemDV);
            this.Name = "DanhmucDV";
            this.Text = "DanhmucDV";
            this.Load += new System.EventHandler(this.DanhmucDV_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DanhmucDV_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonXoaDV;
        private System.Windows.Forms.Button buttonSuaDV;
        private System.Windows.Forms.Button buttonThemDV;
        private System.Windows.Forms.TextBox textBoxTenDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGiaDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngia;
        private System.Windows.Forms.Label label4;
    }
}