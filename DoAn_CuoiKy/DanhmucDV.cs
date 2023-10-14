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
    public partial class DanhmucDV : Form
    {
        public DanhmucDV()
        {
            InitializeComponent();
        }
        QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        private void themDVvaodgv(List<DICHVU> listDV)
        {
            dataGridView1.Rows.Clear();
            foreach (var s in listDV)
            {
                int i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = s.MaDV;
                dataGridView1.Rows[i].Cells[1].Value = s.TenDV;
                dataGridView1.Rows[i].Cells[2].Value = s.Gia;
            }
        }

        public void xoa()
        {
            textBoxMaDV.Text = "";
            textBoxTenDV.Text = "";
            textBoxGiaDV.Text = "";

        }

        private void DanhmucDV_Load(object sender, EventArgs e)
        {
            try
            {
                context = new QuanLyPhongTroContextDB();
                List<DICHVU> dICHVUs = context.DICHVUs.ToList();
                themDVvaodgv(dICHVUs);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBoxMaDV.Text = (string)dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBoxTenDV.Text = (string)dataGridView1.Rows[i].Cells[1].Value;
            textBoxGiaDV.Text = (string)dataGridView1.Rows[i].Cells[2].Value.ToString();

        }
        private void themDVmoi(int ID)
        {
            DICHVU insert = context.DICHVUs.FirstOrDefault(s => s.MaDV == ID);

            if (insert == null)//nếu chưa có thì thêm vào vào cơ sở dữ liệu
            {
                DICHVU s = new DICHVU()
                {
                    MaDV = int.Parse(textBoxMaDV.Text),
                    TenDV = textBoxTenDV.Text,
                    Gia = decimal.Parse(textBoxGiaDV.Text),
                };
                context.DICHVUs.Add(s);// thêm sinh viên vào cơ sở dữ liệu của  đố tượng context
                context.SaveChanges();// lưu sinh viên vào cơ sở dư liêuj của context.
                MessageBox.Show("thêm dịch vụ mới  thành công", "Thông Báo", MessageBoxButtons.OK);
                xoa();// xóa dữ liệu nhập vào sau khi thêm sinh viên thành công.
            }
            else
            {
                MessageBox.Show("Dịch vụ đã tồn tại", "Thông báo");
            }
        }

        private bool TenDichVuDaTonTai(string tenDichVu)
        {
            // Thực hiện truy vấn để kiểm tra tên dịch vụ đã tồn tại chưa
            var dichVu = context.DICHVUs.FirstOrDefault(dv => dv.TenDV == tenDichVu);
            return (dichVu != null);
        }
        private void buttonThemDV_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxMaDV.Text == "" || textBoxTenDV.Text == "" || textBoxGiaDV.Text == "")
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    if (int.Parse(textBoxGiaDV.Text) < 0)
                        MessageBox.Show("Nhập lại số tiền !", "Thông báo", MessageBoxButtons.OK);
                    if (TenDichVuDaTonTai(textBoxTenDV.Text))
                    {
                        MessageBox.Show("Tên dịch vụ đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        themDVmoi(int.Parse(textBoxMaDV.Text));
                        DanhmucDV_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private void SuaDV(int ID)
        {
            DICHVU sua = context.DICHVUs.FirstOrDefault(x => x.MaDV == ID);
            if (sua != null)
            {
                sua.MaDV = int.Parse(textBoxMaDV.Text);
                sua.TenDV = textBoxTenDV.Text;
                sua.Gia = decimal.Parse(textBoxGiaDV.Text);
                context.SaveChanges();
                MessageBox.Show("cập nhật thông tin dịch vụ thành công", " thông báo ", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("dịch vụ không tồn tại", " thông báo", MessageBoxButtons.OK);
        }

        private void buttonSuaDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMaDV.Text == "" || textBoxTenDV.Text == "" || textBoxGiaDV.Text == "")
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    if (int.Parse(textBoxGiaDV.Text) < 0)
                        MessageBox.Show("Nhập lại số tiền !", "Thông báo", MessageBoxButtons.OK);

                    else
                    {
                        SuaDV(int.Parse(textBoxMaDV.Text));
                        DanhmucDV_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
      
        private void xoaDV(int ID)
        {
            DICHVU xoa = context.DICHVUs.FirstOrDefault(x => x.MaDV == ID);
            if (xoa != null)
            {
                DialogResult result = MessageBox.Show("bạn có muốn xóa không? ", " thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    context.DICHVUs.Remove(xoa);//khi có control remove thì sẽ xóa luôn đói tượng đại diện xoa
                    context.SaveChanges();// lưu lại thông tin trong danh sách sinh viên

                    MessageBox.Show("xóa dịch vụ thành công", "  thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonXoaDV_Click(object sender, EventArgs e)
        {
            xoaDV(int.Parse(textBoxMaDV.Text));
            DanhmucDV_Load(sender, e);
        }


        private void DanhmucDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)&& char.IsControl(e.KeyChar)&&char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("chỉ nhập số", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void textBoxTenDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("chỉ nhập chữ", "Thông báo", MessageBoxButtons.OK);
            }

        }
    }
}
