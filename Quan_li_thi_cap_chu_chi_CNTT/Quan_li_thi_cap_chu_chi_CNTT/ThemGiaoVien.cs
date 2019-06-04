using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_thi_cap_chu_chi_CNTT
{
    public partial class ThemGiaoVien : Form
    {
        Quan_li_thi_chung_chi_CNTTEntities dta = new Quan_li_thi_chung_chi_CNTTEntities();
        private string capbac, tendot, nhiemvu, ngaythi;

        private void cb_capbac_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            capbac = combo.SelectedItem.ToString();
        }

        private void cb_nhiemvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            nhiemvu = combo.SelectedItem.ToString();
        }

        private void cb_ngaythi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            ngaythi = combo.SelectedItem.ToString();
        }

        private void cb_tendot_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            tendot = combo.SelectedItem.ToString();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DanhsachHD f = new DanhsachHD();
            this.Visible = false;
            f.ShowDialog();
        }

        public ThemGiaoVien()
        {
            InitializeComponent();
        }
        private void add()
        {
            GiaoVien gv = new GiaoVien();
            DotThi dt = new DotThi();
            gv.MaGV = tb_ma.Text;
            dt.MaGV = tb_ma.Text;
            gv.Hoten = tb_hoten.Text;
            gv.Ngaysinh = dt_ngaysinh.Value;
            gv.SDT = tb_sdt.Text;
            gv.CMT = tb_cmt.Text;
            gv.Gioitinh = tb_gioitinh.Text;
            gv.Capbac = capbac;
            dt.MaGV = tb_ma.Text;
            dt.MaHD = tb_mahd.Text;
            dt.Nhiemvu = nhiemvu;
            dt.Tendot = tendot;
            dt.Ngaythi = Convert.ToDateTime(ngaythi);
            dta.GiaoViens.Add(gv);
            dta.DotThis.Add(dt);
            dta.SaveChanges();
        }
       
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Dataconection.IsNumber(tb_cmt.Text) == true && Dataconection.IsNumber(tb_sdt.Text) == true)
                {
                    add();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Chứng minh thư hoặc số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
