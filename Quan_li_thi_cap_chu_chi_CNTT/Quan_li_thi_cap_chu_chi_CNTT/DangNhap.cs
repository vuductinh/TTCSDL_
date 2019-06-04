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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        void kiemtra()
        {
            if(tb_name.Text=="admin"&&tb_password.Text=="1")
            {
                Home f = new Home();
                this.Visible = false;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
        }
        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            kiemtra();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
