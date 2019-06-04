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
    public partial class FormXacNhan : Form
    { 
        Quan_li_thi_chung_chi_CNTTEntities dt = new Quan_li_thi_chung_chi_CNTTEntities();
        string query_dsxacnhan = "select ts.STT ,ts.SBD N'Mã thí sinh',ts.HoTen N'Họ và tên',ts.Ngaysinh N'Ngày sinh',ts.Gioitinh N'Giới tính',ts.SDT,ts.CMT,xn.Daxacnhan N'Xác nhận' from dbo.ThiSinh ts left join dbo.XacNhan xn on ts.SBD = xn.SBD";
        public FormXacNhan()
        {
            InitializeComponent();
            dataGridView1.DataSource =Dataconection.Danhsach(query_dsxacnhan).Tables[0];
        }
        void xacnhan()
        {
            XacNhan xn = new XacNhan();
            xn.Daxacnhan =true;
            xn.SBD = tb_ma.Text;
            dt.XacNhans.Add(xn);
            dt.SaveChanges();
        }
        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("bạn chưa điền thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                string query = "select *from dbo.ThiSinh ts join dbo.ChitietDK ct on ts.SBD=ct.SBD and ts.SBD=@ma";
                using (SqlConnection connection = new SqlConnection(Dataconection.conection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ma", tb_ma.Text);
                    SqlDataReader adapter = command.ExecuteReader();
                    if (adapter.Read() == true)
                    {
                        var model = from p in dt.ThiSinhs where (p.SBD == tb_ma.Text) select p.HoTen;
                        foreach(string item in model)
                        {
                            tb_hoten.Text = item;
                        }
                        Dataconection.sua("exec dbo._Xacnhan '"+tb_ma.Text+"'");
                        MessageBox.Show("Đã xác nhận!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thí sinh không tồn tai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection.Close();
                }
            }
            dataGridView1.DataSource =Dataconection.Danhsach(query_dsxacnhan).Tables[0];
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
