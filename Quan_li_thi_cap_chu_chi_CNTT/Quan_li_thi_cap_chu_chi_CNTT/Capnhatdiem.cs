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
    public partial class Capnhatdiem : Form
    {
        Quan_li_thi_chung_chi_CNTTEntities dt = new Quan_li_thi_chung_chi_CNTTEntities();
        public Capnhatdiem()
        {
            InitializeComponent();
        }
        private void add()
        {
            BaiThi bt = new BaiThi();
            KetQua kq = new KetQua();
            bt.SBD = tb_sbd.Text;
            bt.MaBT = tb_mabt.Text;
            dt.BaiThis.Add(bt);
            kq.MaHD = tb_mahd.Text;
            kq.MaBT = tb_mabt.Text;
            kq.DiemLT = Convert.ToInt32(tb_diemlt.Text);
            kq.Diem_word = Convert.ToInt32(tb_diemword.Text);
            kq.Diem_ppt = Convert.ToInt32(tb_diemppt.Text);
            kq.Diem_excel = Convert.ToInt32(tb_diemexcel.Text);
            dt.KetQuas.Add(kq);
            dt.SaveChanges();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (tb_mabt.Text != "" && tb_mahd.Text != "" && tb_sbd.Text != "")
            {
                if (Dataconection.IsNumber(tb_diemlt.Text) == true && Dataconection.IsNumber(tb_diemword.Text) == true && Dataconection.IsNumber(tb_diemexcel.Text) == true && Dataconection.IsNumber(tb_diemppt.Text) == true)
                {
                    add();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                    MessageBox.Show("Điểm thi phải là dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("bạn chưa điền thông tin");
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            QuanliDiem f = new QuanliDiem();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
