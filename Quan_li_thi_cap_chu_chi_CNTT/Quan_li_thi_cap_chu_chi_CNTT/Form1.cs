using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_thi_cap_chu_chi_CNTT
{
    public partial class Home : Form
    {
        Quan_li_thi_chung_chi_CNTTEntities data = new Quan_li_thi_chung_chi_CNTTEntities();
        string query_danhsachhd = "select gv.STT,gv.Hoten N'Họ và tên',gv.Capbac N'Cấp bậc',dt.Nhiemvu N'Nhiệm vụ',hd.Ghichu N'Ghi chú' from dbo.DotThi dt inner join dbo.GiaoVien gv on gv.MaGV = dt.MaGV inner join dbo.HoiDong hd on dt.MaHD = hd.MaHD order by gv.STT";
        string query_danhsachthutien = "select ts.STT,ts.HoTen N'Họ và tên',ts.Ngaysinh N'Ngày sinh',ts.CMT,lp.Nhucau N'Nhu cầu',lp.ThuocHV N'Thuộc học viện',lp.Trinhdo N'Trình độ',lp.Giatien N'Giá tiền' from dbo.ThiSinh ts inner join LePhi lp on ts.Maluachon = lp.Maluachon join dbo.XacNhan xn on ts.SBD=xn.SBD order by ts.STT";
        string query_danhsachduthi = "select ts.STT, ts.SBD,ts.HoTen N'Họ và tên',ts.Ngaysinh N'Ngày sinh',ts.CMT from dbo.ThiSinh ts inner join dbo.XacNhan xn on ts.SBD=xn.SBD order by ts.STT";
        string query_diem = "select kq.STT, ts.SBD,ts.HoTen N'Họ và tên',ts.CMT,kq.DiemLT N'Điểm lí thuyết',(kq.Diem_word+kq.Diem_excel+kq.Diem_ppt)/3 N'Điểm thực hành' from dbo.BaiThi bt join dbo.ThiSinh ts on ts.SBD = bt.SBD join dbo.KetQua kq on kq.MaBT = bt.MaBT order by ts.STT";
        string query_thubai = "select kq.STT,ts.SBD,ts.HoTen N'Họ và tên',ts.CMT,kq.DiemLT N'Điểm lí thuyết',Kq.Diem_word N'Điểm word',kq.Diem_excel N'Điểm excel',kq.Diem_ppt N'Điểm ppt' from dbo.BaiThi bt join dbo.ThiSinh ts on ts.SBD = bt.SBD join dbo.KetQua kq on kq.MaBT = bt.MaBT order by ts.STT";
        //string query_thisinhdangki = "select *from dbo.Danhsachdangki()";
        string query_thisinhdangki = "select ts.STT,ct.Email,ts.HoTen N'Họ và tên',ts.Ngaysinh N'Ngày sinh',ts.Gioitinh N'Giới tính',ts.CMT ,ts.SDT, lp.Nhucau N'Nhu cầu',lp.ThuocHV N'Thuộc học viện',lp.Trinhdo N'Trình độ'from dbo.ThiSinh ts inner join dbo.ChitietDK ct on ts.SBD = ct.SBD inner join dbo.LePhi lp on lp.Maluachon = ts.Maluachon order by ts.STT";
        string query_danhsachcap = "select ts.HoTen N'Họ tên',ts.Ngaysinh N'Ngày sinh',ts.CMT,lp.ThuocHV N'Thuộc học viện',cc.Sovanbang N'Số văn bằng',cc.Sovaoso N'Số vào sổ',cc.Tenchungchi N'Tên chứng chỉ' from dbo.ThiSinh ts inner join dbo.LePhi lp on ts.Maluachon= lp.Maluachon inner join dbo.CapChungChi cc on ts.SBD= cc.SBD";

        public Home()
        {
            InitializeComponent();
            lb_thongtin.Text = "Danh sách thí sinh đăng kí";
            dataGridView1.DataSource = Dataconection.Danhsach(query_thisinhdangki).Tables[0];
        }
        
        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            switch(result)
            {
                case DialogResult.OK:
                    Application.Exit();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
        private void danhSáchThíSinhĐăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlithisinhdnagki f = new Quanlithisinhdnagki();
            this.Visible = false;
            f.ShowDialog();
        }

        private void danhSáchHộiđồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhsachHD f = new DanhsachHD();
            this.Visible = false;
            f.ShowDialog();
        }
        private void danhSáchdiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanliDiem f = new QuanliDiem();
            this.Visible = false;
            f.ShowDialog();
        }

        private void danhSáchdựthiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_thongtin.Text = "Danh sách dự thi";
            dataGridView1.DataSource = Dataconection.Danhsach(query_danhsachduthi).Tables[0];
        }

        private void danhSáchthubaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_thongtin.Text = "Danh sách thu bài";
            dataGridView1.DataSource = Dataconection.Danhsach(query_thubai).Tables[0];
        }

        private void danhSáchCấpChứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapVanBang f = new CapVanBang();
            this.Visible = false;
            f.ShowDialog();
        }
        private void danhsachthutienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Dataconection.Danhsach(query_danhsachthutien).Tables[0];
        }

        private void xácNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXacNhan f = new FormXacNhan();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
