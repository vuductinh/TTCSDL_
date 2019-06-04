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
    public partial class XoaGv : Form
    {
        public XoaGv()
        {
            InitializeComponent();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text != "")
            {
                Dataconection.sua("exec XoaGV '" + tb_ma.Text + "'");
                MessageBox.Show("Xóa thành công giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhsachHD f = new DanhsachHD();
                this.Visible = false;
                f.ShowDialog();
            }
            else
                MessageBox.Show("Bạn phải điền thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            DanhsachHD f = new DanhsachHD();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
