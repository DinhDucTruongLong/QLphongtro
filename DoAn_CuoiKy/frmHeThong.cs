using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }
        

        private void tabQuanLyKhachPhong_Click(object sender, EventArgs e)
        {

        }

        private void tsbDanhSachHoaDon_Click(object sender, EventArgs e)
        {

          
                DanhsachHD frm = new DanhsachHD();
                frm.ShowDialog();

          

        }
      

        private void tsbNhapHoaDon_Click(object sender, EventArgs e)
        {

           
                NhapHD frm = new NhapHD();
                
                frm.ShowDialog();

          
        }

        private void tsbDanhSachDichVu_Click(object sender, EventArgs e)
        {

               DanhmucDV frm = new DanhmucDV();
               
                frm.ShowDialog();

         
        }

        private void tsbNhapHDDichVu_Click(object sender, EventArgs e)
        {

         
               HDdichvu frm = new HDdichvu();
             
                frm.ShowDialog();

        }
    }
}
