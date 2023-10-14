using DoAn_CuoiKy.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
    public partial class DanhsachHD : Form
    {
        public DanhsachHD()
        {
            InitializeComponent();
        }
         QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        // thêm thông tin CSDL vào dgvdanhdsach

        private void themlistSVvaogrid( List<HOADON> listHD)
        {
           
            dgvDanhsachHD.Rows.Clear();
            
            foreach (var S in listHD)
            {
                int index = dgvDanhsachHD.Rows.Add();
                dgvDanhsachHD.Rows[index].Cells[0].Value = S.MaPhong;

                dgvDanhsachHD.Rows[index].Cells[1].Value = S.NgayLapHD;
                dgvDanhsachHD.Rows[index].Cells[2].Value = S.TongTien;
                dgvDanhsachHD.Rows[index].Cells[3].Value = S.TrangThai;
            }  
        }

        private void DanhsachHD_Load(object sender, EventArgs e)
        {
            try
            {
                context = new QuanLyPhongTroContextDB();
                
                List<HOADON> listHD = context.HOADONs.ToList();
                themlistSVvaogrid( listHD);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        // hàm này để xác định là đã thanh toán hay chưa.

        private void dgvDSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvDanhsachHD.Rows[e.RowIndex].Cells[e.ColumnIndex];

                long ID = long.Parse(dgvDanhsachHD.Rows[e.RowIndex].Cells[0].Value.ToString());
                HOADON ph = context.HOADONs.FirstOrDefault(s => s.MaPhong == ID);

                if (ph != null)
                {
                    int doiGIaTri = (int)ph.TrangThai;
                    int newValue = doiGIaTri == 0 ? 1 : 0;
                    ph.TrangThai = newValue;
                    context.SaveChanges();

                    dgvDanhsachHD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue == 1;
                }

               // MessageBox.Show("Đã đã thanh toán thành công", "Xác nhận", MessageBoxButtons.OK);
            }
        }
    
       
        private void buttonthanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dgvDanhsachHD.CurrentCell.RowIndex;
                  
                int selectedID = int.Parse(dgvDanhsachHD.Rows[selectedRowIndex].Cells[0].Value.ToString());

                HOADON i = context.HOADONs.FirstOrDefault(b => b.MaPhong == selectedID);
                if (i != null && i.TrangThai != 1)
                {
                    DialogResult result = MessageBox.Show("xác nhận thanh toán", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        i.TrangThai = 1;
                        context.SaveChanges();
                        DanhsachHD_Load(sender, e); // Tải lại danh sách hóa đơn sau khi đã thanh toán
                    }
                }
                else
                {
                    MessageBox.Show("Hóa đơn đã được thanh toán", "thông báo");
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonxemCT_Click(object sender, EventArgs e)
        {
            if (dgvDanhsachHD.SelectedRows.Count >0)
            {
                // Lấy hóa đơn được chọn
               DataGridViewRow selectedrow = dgvDanhsachHD.SelectedRows[0];
                // Lấy giá trị của cột đầu tiên (cột chứa mã hóa đơn)
                int maHoaDon = Convert.ToInt32(selectedrow.Cells["TenPhong"].Value);
                // Hiển thị thông tin chi tiết của hóa đơn trong giao diện hoặc hộp thoại mới
                HDdichvu chiTietHoaDonForm = new HDdichvu(maHoaDon);
                chiTietHoaDonForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết!", "Thông báo", MessageBoxButtons.OK);
            }
            //HDdichvu frm = new HDdichvu();
            //frm.ShowDialog();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dgvDanhsachHD.CurrentCell.RowIndex;

                int selectedID = int.Parse(dgvDanhsachHD.Rows[selectedRowIndex].Cells[0].Value.ToString());

                HOADON i = context.HOADONs.FirstOrDefault(b => b.MaPhong == selectedID);
                if (i != null && i.TrangThai == 1)
                {
                    DialogResult result = MessageBox.Show("xác nhận thanh Xóa hóa đơn", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        context.HOADONs.Remove(i);
                        context.SaveChanges();
                        DanhsachHD_Load(sender, e); // Tải lại danh sách hóa đơn sau khi đã thanh toán
                    }
                }
                else
                {
                    MessageBox.Show("Hóa đơn đã được thanh toán", "thông báo");
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
     
