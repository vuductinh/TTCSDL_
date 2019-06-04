using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_thi_cap_chu_chi_CNTT
{
    public partial class DanhsachHD : Form
    {
        Quan_li_thi_chung_chi_CNTTEntities dta = new Quan_li_thi_chung_chi_CNTTEntities();
        string query_danhsachHD = "select hd.MaHD,hd.Ten N'Tên',hd.Ghichu N'Ghi chú' from dbo.HoiDong hd";
        string query_thanhvienHD = "select gv.STT, gv.MaGV, gv.Hoten N'Họ và tên',gv.Ngaysinh N'Ngày sinh',gv.Capbac N'Cấp bậc',dt.Nhiemvu N'Nhiệm vụ',hd.Ghichu N'Ghi chú' from dbo.DotThi dt inner join dbo.GiaoVien gv on gv.MaGV = dt.MaGV inner join dbo.HoiDong hd on dt.MaHD = hd.MaHD";
        public DanhsachHD()
        {
            InitializeComponent();
            lb_thongtin.Text = "Danh sách thành viên hội đồng";
            dataGridView1.DataSource = Dataconection.Danhsach(query_thanhvienHD).Tables[0];
            biding();
        }
        private void biding()
        {
            tb_stt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "STT", true, DataSourceUpdateMode.Never));
            tb_ma.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaGV", true, DataSourceUpdateMode.Never));
            tb_hoten.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Họ và tên", true, DataSourceUpdateMode.Never));
            dt_ngaysinh.DataBindings.Add(new Binding("Value", dataGridView1.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never));
            cb_capbac.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Cấp bậc", true, DataSourceUpdateMode.Never));
            cb_nhiemvu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Nhiệm vụ", true, DataSourceUpdateMode.Never));
            tb_ghichu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Ghi chú", true, DataSourceUpdateMode.Never));
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Visible = false;
            f.ShowDialog();
        }
        
        private void bt_them_Click(object sender, EventArgs e)
        {
            ThemGiaoVien f = new ThemGiaoVien();
            this.Visible = false;
            f.ShowDialog();
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            XoaGv f = new XoaGv();
            this.Visible = false;
            f.ShowDialog();
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            SuaThongtinGV f = new SuaThongtinGV();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
