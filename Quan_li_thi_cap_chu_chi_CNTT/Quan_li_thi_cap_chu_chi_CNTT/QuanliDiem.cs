using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_thi_cap_chu_chi_CNTT
{
    public partial class QuanliDiem : Form
    {
        string query_dsdiem = "select kq.STT, ts.SBD,ts.HoTen N'Họ và tên',ts.CMT,kq.DiemLT N'Điểm lí thuyết',Kq.Diem_word N'Điểm word',kq.Diem_excel N'Điểm excel',kq.Diem_ppt N'Điểm ppt' from dbo.BaiThi bt join dbo.ThiSinh ts on ts.SBD=bt.SBD join dbo.KetQua kq on kq.MaBT= bt.MaBT order by STT";
        public QuanliDiem()
        {
            InitializeComponent();
            dt_danhsachdiem.DataSource = Dataconection.Danhsach(query_dsdiem).Tables[0];
            biding();
        }
        private void biding()
        {
            tb_stt.DataBindings.Add(new Binding("Text", dt_danhsachdiem.DataSource, "STT", true, DataSourceUpdateMode.Never));
            tb_sbd.DataBindings.Add(new Binding("Text", dt_danhsachdiem.DataSource, "SBD", true, DataSourceUpdateMode.Never));
            tb_hoten.DataBindings.Add(new Binding("Text", dt_danhsachdiem.DataSource, "Họ và tên", true, DataSourceUpdateMode.Never));
            tb_cmt.DataBindings.Add(new Binding("Text", dt_danhsachdiem.DataSource, "CMT", true, DataSourceUpdateMode.Never));
            tb_diemlt.DataBindings.Add(new Binding("Text", dt_danhsachdiem.DataSource, "Điểm lí thuyết", true, DataSourceUpdateMode.Never));
            tb_diemword.DataBindings.Add(new Binding("Text", dt_danhsachdiem.DataSource, "Điểm word", true, DataSourceUpdateMode.Never));
            tb_diemexcel.DataBindings.Add(new Binding("Text", dt_danhsachdiem.DataSource, "Điểm excel", true, DataSourceUpdateMode.Never));
            tb_diemppt.DataBindings.Add(new Binding("Text", dt_danhsachdiem.DataSource, "Điểm ppt", true, DataSourceUpdateMode.Never));
        }
        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            Capnhatdiem f = new Capnhatdiem();
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
