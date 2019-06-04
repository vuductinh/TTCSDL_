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
    public partial class Quanlithisinhdnagki : Form
    {
        private string query_danhsachdk = "select *from dbo.Danhsachdangki()";
        public Quanlithisinhdnagki()
        {
            InitializeComponent();
            dt_danhsachthisinh.DataSource = Dataconection.Danhsach(query_danhsachdk).Tables[0];
            biding();
        }
        private void biding()
        {
            tb_email.DataBindings.Add(new Binding("Text", dt_danhsachthisinh.DataSource, "Email", true, DataSourceUpdateMode.Never));
            tb_hoten.DataBindings.Add(new Binding("Text", dt_danhsachthisinh.DataSource, "Họ và tên", true, DataSourceUpdateMode.Never));
            dt_ngaysinh.DataBindings.Add(new Binding("Value", dt_danhsachthisinh.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never));
            tb_gioitinh.DataBindings.Add(new Binding("Text", dt_danhsachthisinh.DataSource, "Giới tính", true, DataSourceUpdateMode.Never));
            tb_cmt.DataBindings.Add(new Binding("Text", dt_danhsachthisinh.DataSource, "CMT", true, DataSourceUpdateMode.Never));
            tb_sdt.DataBindings.Add(new Binding("Text", dt_danhsachthisinh.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            tb_nhucau.DataBindings.Add(new Binding("Text", dt_danhsachthisinh.DataSource, "Nhu cầu", true, DataSourceUpdateMode.Never));
            tb_hocvien.DataBindings.Add(new Binding("Text", dt_danhsachthisinh.DataSource, "Thuộc học viện", true, DataSourceUpdateMode.Never));
            tb_trinhdo.DataBindings.Add(new Binding("Text", dt_danhsachthisinh.DataSource, "Trình độ", true, DataSourceUpdateMode.Never));
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            Thaydoithongtin f = new Thaydoithongtin();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            XoaThongTinTS f = new XoaThongTinTS();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
