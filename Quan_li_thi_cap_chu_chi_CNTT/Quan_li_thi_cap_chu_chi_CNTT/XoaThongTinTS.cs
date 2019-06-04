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
    public partial class XoaThongTinTS : Form
    {
        public XoaThongTinTS()
        {
            InitializeComponent();
        }
        private void xoa()
        {
            if (tb_ma.Text != "")
            {
                using (SqlConnection connection= new SqlConnection(Dataconection.conection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select*from dbo.ThiSinh where SBD=@ma", connection);
                    command.Parameters.AddWithValue("@ma", tb_ma.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.Read()==true)
                    {
                        Dataconection.sua("dbo.XoaThiSinh '" + tb_ma.Text + "'");
                        MessageBox.Show("Xóa thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Quanlithisinhdnagki f = new Quanlithisinhdnagki();
                        this.Visible = false;
                        f.ShowDialog();
                    }
                    else
                        MessageBox.Show("Mã không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                    
            }
            else
                MessageBox.Show("vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Quanlithisinhdnagki f = new Quanlithisinhdnagki();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
