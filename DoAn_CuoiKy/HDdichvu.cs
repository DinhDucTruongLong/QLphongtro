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

namespace DoAn_CuoiKy
{
    public partial class HDdichvu : Form
    {
        public HDdichvu(int mahoadon)
        {
            InitializeComponent();
        }
        QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();

        private void themDVvaoform(List<CT_DICHVU> listCTDV,  List<DICHVU> listDV)
        {
           
            dgvdanhsachDV.Rows.Clear();
            foreach (var S in listDV)
            {
                int index = dgvdanhsachDV.Rows.Add();
                dgvdanhsachDV.Rows[index].Cells[0].Value = S.TenDV;
                dgvdanhsachDV.Rows[index].Cells[1].Value = S.Gia;
               
                CT_DICHVU CTDV = listCTDV.FirstOrDefault( b =>b.MaDV == S.MaDV );
                if( CTDV != null )
                {
                    dgvdanhsachDV.Rows[index].Cells[2].Value = CTDV.SoLuong;
                }
            }
            
        }

        private void HDdichvu_Load(object sender, EventArgs e)
        {
           
            List<DICHVU> listDV = context.DICHVUs.ToList();
            List<CT_DICHVU> listCTDV = context.CT_DICHVU.ToList();
            themDVvaoform(listCTDV, listDV);
 
        }

        
    }
}
