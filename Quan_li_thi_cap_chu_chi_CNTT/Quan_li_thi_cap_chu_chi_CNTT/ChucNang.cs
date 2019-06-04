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
    public partial class ChucNang : Form
    {
        public ChucNang()
        {
            InitializeComponent();
        }

        private void bt_quanli_hoidong_Click(object sender, EventArgs e)
        {
            DanhsachHD f = new DanhsachHD();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_quanli_diem_Click(object sender, EventArgs e)
        {
            QuanliDiem f = new QuanliDiem();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_quanli_vanbang_Click(object sender, EventArgs e)
        {
            CapVanBang f = new CapVanBang();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_trove_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
