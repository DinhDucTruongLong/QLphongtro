using DoAn_CuoiKy.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlTypes;

namespace DoAn_CuoiKy
{
    public partial class NhapHD : Form
    {
        public NhapHD()
        {
            InitializeComponent();

        }
        QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        List<MALOAIPHONG> MALOAIPHONGs = new List<MALOAIPHONG>();
 

     
        private void themphongvaocombobox(List<PHONG> PHONGs)
        {
 
            this.comboBoxphong.DataSource = PHONGs;
            this.comboBoxphong.DisplayMember = "MaPhong";
            this.comboBoxphong.ValueMember = "MaPhong";
        }
        private void themloaiphongcombobox()
        {
      
            this.cbbloaiphong.DataSource = MALOAIPHONGs;
            //chỉ định tên của của khoa ở trong list 
            this.cbbloaiphong.DisplayMember = "TenLoaiPhong";
            // lấy giá trị của mã khoa = valuemenber
            this.cbbloaiphong.ValueMember = "MaLoaiphong";
            //Lấy giá trị của đơn giá.


        }
        private void themcomboboxDV(List<DICHVU> listDV)
        {
            this.comboBoxDichvu.DataSource = listDV;
            this.comboBoxDichvu.ValueMember = "TenDV";
            this.comboBoxDichvu.DisplayMember = "MaDV";

        }



        private void NhapHD_Load(object sender, EventArgs e)
        {
            try
            {
                context = new QuanLyPhongTroContextDB();
                //truy vấn ds từ cở sở dữ liệu = khoas
                MALOAIPHONGs = context.MALOAIPHONGs.ToList();
                themloaiphongcombobox();// điền dữ liệu từ listkhoa và combobox.
                List<PHONG> pHONGs = context.PHONGs.ToList();
                themphongvaocombobox(pHONGs);
                List<DICHVU> DV = context.DICHVUs.ToList();
                themcomboboxDV(DV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


      
        private void capnhat(DateTime ngayDung)
        {
            int ID = Convert.ToInt32(dataGridViewDSdichvu.CurrentRow.Cells[1].Value);
            CT_DICHVU capnhat = context.CT_DICHVU.FirstOrDefault(x => x.MaDV == ID);
            if (capnhat != null)
            {
                capnhat.NgayDung = ngayDung;
                context.SaveChanges();
            }
        }
        private int TienDien()
        {
            int tieuthudien = 0;
            if (textBoxchisodiencu.Text != "" && textBoxchisodienmoi.Text != "" && Convert.ToInt32(textBoxchisodienmoi.Text) > Convert.ToInt32(textBoxchisodiencu.Text))
            {
                tieuthudien = Convert.ToInt32(textBoxchisodienmoi.Text) - Convert.ToInt32(textBoxchisodiencu.Text);
                textBoxchisotieuthudien.Text = tieuthudien.ToString();
               
            }
           int tongtiendien = tieuthudien * 1500;
           // textBoxTongtiendien.Text = tongtiendien.ToString();
           return tongtiendien;
        }
        private int TienNuoc()
        {
            int tieuthunuoc = 0;
            if (textBoxchisonuoccu.Text != "" && textBoxchisonuocmoi.Text != "" && Convert.ToInt32(textBoxchisonuocmoi.Text) > Convert.ToInt32(textBoxchisonuoccu.Text))
            {
                tieuthunuoc = Convert.ToInt32(textBoxchisonuocmoi.Text) - Convert.ToInt32(textBoxchisonuoccu.Text);
                textboxchisotieuthunuoc.Text = tieuthunuoc.ToString();
            }
            int tongtiennuoc = tieuthunuoc * 3000;
            return tongtiennuoc;
        }

        private void buttonluuvatieptuc_Click(object sender, EventArgs e)
        {
            
            textBoxTongtiendien.Text = TienDien().ToString();
            textBoxTongtiennuoc.Text = TienNuoc().ToString();
         

            context.SaveChanges();

        }


        private decimal TongtienDV()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dataGridViewDSdichvu.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[3] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    decimal giaDV = Convert.ToDecimal(row.Cells[0].Value);

                    tongTien += giaDV;
                }
            }

            return tongTien;
        }





        private void buttonHuy_Click(object sender, EventArgs e)
        {

        }



        private void cbbloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbloaiphong.SelectedItem != null)
            {
                MALOAIPHONG selectedLoaiPhong = (MALOAIPHONG)cbbloaiphong.SelectedItem;
                // Lấy giá trị của thuộc tính DonGia từ đối tượng selectedLoaiPhong
                string donGia = selectedLoaiPhong.DonGia.ToString();
                // Gán giá trị của thuộc tính DonGia vào textBoxgiaphong
                textBoxgiaphong.Text = donGia;

            }
        }

        private void dataGridViewDSdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                // Kiểm tra chỉ mục của cột chứa giá trị thời gian
                if (rowIndex == -1)
                {
                    // Truy cập giá trị thời gian trong ô được nhấp chuột
                    if (dataGridViewDSdichvu.Rows[rowIndex].Cells[columnIndex].Value is DateTime thoiGian)
                    {
                        dateTimePickerDangki.Value = thoiGian;
                    }
                }

                context.SaveChanges();


            }
        }

        private void buttonDongHD_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textboxchisotieuthunuoc_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkedDV(int ID)
        {
            CT_DICHVU checkedDV = context.CT_DICHVU.FirstOrDefault(s => s.MaDV == ID);
            if (checkedDV == null)
            {
                CT_DICHVU s = new CT_DICHVU();

                context.CT_DICHVU.Add(s);
                context.SaveChanges();
                MessageBox.Show("thêm thành công", "thông báo", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("đã chọn", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void dataGridViewDSdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridViewDSdichvu.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value == null || !(bool)cell.Value)
                {
                    // Ô checkbox chưa được checked
                    cell.Value = true;

                    int ID = int.Parse(dataGridViewDSdichvu.Rows[e.RowIndex].Cells[3].Value.ToString());
                    CT_DICHVU CTDV = context.CT_DICHVU.FirstOrDefault(s => s.MaDV == ID);

                    if (CTDV != null)
                    {
                        int doiGT = (int)CTDV.TinhTrang;
                        int newValue = doiGT == 0 ? 1 : 0;
                        CTDV.SoLuong = newValue;


                        // Hiển thị thông báo xác nhận
                        MessageBox.Show("Đã thay đổi thành công", "Xác nhận", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    // Ô checkbox đã được checked
                    cell.Value = false;

                }
              
                context.SaveChanges();


            }
        }

        
      
    }
}
