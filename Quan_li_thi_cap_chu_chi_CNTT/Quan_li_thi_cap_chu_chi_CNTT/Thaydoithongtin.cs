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
    public partial class Thaydoithongtin : Form
    {
        private string nhucau, trinhdo, gioitinh, thuochv;
        public Thaydoithongtin()
        {
            InitializeComponent();
        }
        private void bt_thaydoi_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(Dataconection.conection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select *from dbo.ThiSinh where SBD =@ma", connection);
                    command.Parameters.AddWithValue("@ma", tb_ma.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        suathongtin();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("mã không tồn tại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("vui lòng nhập mã thí sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Quanlithisinhdnagki f = new Quanlithisinhdnagki();
            this.Visible = false;
            f.ShowDialog();
        }

        string showRadio(string a, Panel pl)
        {
            RadioButton radio = null;
            foreach (RadioButton item in pl.Controls)
            {
                if (item != null)
                    if (item.Checked)
                    {
                        radio = item;
                        break;
                    }
            }
            if (radio != null)
            {
                a = radio.Text;
            }
            return a;
        }
        private string showCheckbox(string a, Panel pl)
        {
            CheckBox radio = null;
            foreach (CheckBox item in pl.Controls)
            {
                if (item != null)
                    if (item.Checked)
                    {
                        radio = item;
                        break;
                    }
            }
            if (radio != null)
            {
                a = radio.Text;

            }
            return a;
        }
        private void suathongtin()
        {
            string luachon = showRadio(gioitinh, panelgioitinh);
            string luachon2 = showRadio(thuochv, panelhocvien);
            string luachon3 = showRadio(nhucau, panelnhucau);
            string luachon4 = showCheckbox(trinhdo, paneltrinhdo);
            string query_thaydoi = "exec dbo._thaydoithongtinDK '" + tb_ma.Text + "','" + tb_mail.Text + "',N'" + tb_hoten.Text + "','" + dt_ngaysinh.Value + "',N'" + luachon + "','" + tb_cmt.Text + "','" + tb_sdt.Text + "',N'" + luachon3 + "',N'" + luachon2 + "',N'" + luachon4 + "'";
            Dataconection.sua(query_thaydoi); 
        }
    }
}
