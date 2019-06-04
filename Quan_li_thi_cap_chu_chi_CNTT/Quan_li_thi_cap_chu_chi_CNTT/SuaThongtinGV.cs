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
    public partial class SuaThongtinGV : Form
    {
        Quan_li_thi_chung_chi_CNTTEntities dt = new Quan_li_thi_chung_chi_CNTTEntities();
        private string tendot, capbac, nhiemvu, ngaythi,tengv;

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text != null)
            {
                using (SqlConnection connection = new SqlConnection(Dataconection.conection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select *from dbo.GiaoVien where MaGV=@ma", connection);
                    command.Parameters.AddWithValue("@ma", tb_ma.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        load();
                    }
                    else
                        MessageBox.Show("Mã không tồn tại!");
                    connection.Close();
                }
            }
            else
                MessageBox.Show("bạn chưa nhập mã");
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DanhsachHD f = new DanhsachHD();
            this.Visible = false;
            f.ShowDialog();
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

        private void cb_nhiemvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            nhiemvu = combo.SelectedItem.ToString();
        }

        private void cb_capbac_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            capbac = combo.SelectedItem.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            sua();
        }

        public SuaThongtinGV()
        {
            InitializeComponent();
        }
        private void load()
        {
            var model = from p in dt.GiaoViens where (p.MaGV == tb_ma.Text) select p.Hoten;
            foreach (string item in model)
            {
                groupBox1.Text = "Những thông tin có thể sửa của giáo viên: " + item;
            }
        }
        private void sua()
        {
            if (tb_mahd.Text != "")
            {
                if (Dataconection.IsNumber(tb_sdt.Text) == true)
                {
                    Dataconection.sua("exec dbo.Update_HD" + "'" + tb_ma.Text + "'," + "'" + tb_sdt.Text + "'," + "'" + tb_mahd.Text + "'," + "N'" + capbac + "'," + "N'" + nhiemvu + "'," + "'" + ngaythi + "'" + ",N'" + tendot + "'");
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
