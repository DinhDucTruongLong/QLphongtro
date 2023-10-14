namespace DoAn_CuoiKy
{
    partial class HDdichvu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdanhsachDV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clntenDv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lcnGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phòng:";
          
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(182, 62);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(100, 22);
            this.txtTenPhong.TabIndex = 1;
         
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(182, 107);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(100, 22);
            this.txtMaHD.TabIndex = 3;
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Hóa Đơn:";
        
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(547, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
          
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá Phòng:";
          
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông Tin Chi Tiết Hóa Đơn";
        
            // 
            // dgvdanhsachDV
            // 
            this.dgvdanhsachDV.AllowUserToAddRows = false;
            this.dgvdanhsachDV.AllowUserToDeleteRows = false;
            this.dgvdanhsachDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clntenDv,
            this.lcnGia,
            this.cln,
            this.clnThanhtien});
            this.dgvdanhsachDV.Location = new System.Drawing.Point(40, 42);
            this.dgvdanhsachDV.Name = "dgvdanhsachDV";
            this.dgvdanhsachDV.RowHeadersWidth = 51;
            this.dgvdanhsachDV.RowTemplate.Height = 24;
            this.dgvdanhsachDV.Size = new System.Drawing.Size(676, 153);
            this.dgvdanhsachDV.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdanhsachDV);
            this.groupBox1.Location = new System.Drawing.Point(26, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 251);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin các dịch vụ";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(547, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Loại Phòng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(206, 163);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(292, 22);
            this.txtTongTien.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng Tiền:";
            // 
            // clntenDv
            // 
            this.clntenDv.HeaderText = "Tên dịch vụ";
            this.clntenDv.MinimumWidth = 6;
            this.clntenDv.Name = "clntenDv";
            this.clntenDv.Width = 125;
            // 
            // lcnGia
            // 
            this.lcnGia.HeaderText = "Giá Dịch Vụ";
            this.lcnGia.MinimumWidth = 6;
            this.lcnGia.Name = "lcnGia";
            this.lcnGia.Width = 125;
            // 
            // cln
            // 
            this.cln.HeaderText = "Số Lượng";
            this.cln.MinimumWidth = 6;
            this.cln.Name = "cln";
            this.cln.Width = 125;
            // 
            // clnThanhtien
            // 
            this.clnThanhtien.HeaderText = "Thành tiền";
            this.clnThanhtien.MinimumWidth = 6;
            this.clnThanhtien.Name = "clnThanhtien";
            this.clnThanhtien.Width = 125;
            // 
            // HDdichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.label1);
            this.Name = "HDdichvu";
            this.Text = "HDdichvu";
            this.Load += new System.EventHandler(this.HDdichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvdanhsachDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntenDv;
        private System.Windows.Forms.DataGridViewTextBoxColumn lcnGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThanhtien;
    }
}