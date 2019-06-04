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
    public partial class CapVanBang : Form
    {
        Quan_li_thi_chung_chi_CNTTEntities dt = new Quan_li_thi_chung_chi_CNTTEntities();
        string tenchungchi;
        string query_danhsachcap = "select ts.HoTen N'Họ tên',ts.Ngaysinh N'Ngày sinh',ts.CMT,lp.ThuocHV N'Thuộc học viện',cc.Sovanbang N'Số văn bằng',cc.Sovaoso N'Số vào sổ',cc.Tenchungchi N'Tên chứng chỉ' from dbo.ThiSinh ts inner join dbo.LePhi lp on ts.Maluachon= lp.Maluachon inner join dbo.CapChungChi cc on ts.SBD= cc.SBD";
        public CapVanBang()
        {
            InitializeComponent();
            dt_danhsach.DataSource = Dataconection.Danhsach(query_danhsachcap).Tables[0];
        }
        void add()
        {
            CapChungChi cc = new CapChungChi();
            cc.MaHD = tb_mahd.Text;
            cc.SBD = tb_sbd.Text;
            cc.Tenchungchi =tenchungchi;
            cc.Ngaycap = dt_ngaycap.Value;
            cc.Sovanbang = Convert.ToInt32(tb_sovanbang.Text);
            cc.Sovaoso = Convert.ToInt32(tb_sovaoso.Text);
            dt.CapChungChis.Add(cc);
            dt.SaveChanges();
        }
        private void bt_cap_Click(object sender, EventArgs e)
        {
            if (tb_mahd.Text != "" && tb_sbd.Text != "")
            {
                string query = "kiemtra @sbd,@mahd";
                using (SqlConnection connection=new SqlConnection(Dataconection.conection))
                {
                     connection.Open();
                     SqlCommand command = new SqlCommand(query, connection);
                     command.Parameters.AddWithValue("@sbd", tb_sbd.Text);
                     command.Parameters.AddWithValue("@mahd", tb_mahd.Text);
                     SqlDataReader reader = command.ExecuteReader();
                     if (reader.Read()==true)
                     {
                        if (Dataconection.IsNumber(tb_sovanbang.Text) == true && Dataconection.IsNumber(tb_sovaoso.Text) == true)
                        {
                            add();
                            MessageBox.Show("Cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dt_danhsach.DataSource = Dataconection.Danhsach(query_danhsachcap).Tables[0];
                        }
                        else MessageBox.Show("Số văn bằng hoặc số vào sổ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                     else
                            MessageBox.Show("SBD hoặc MaHD không tồn tại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        connection.Close();
                }
            }
            else
                MessageBox.Show("bạn chưa điền thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Visible = false;
            f.ShowDialog();
        }

        private void cb_tenchungchi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            tenchungchi = combo.SelectedItem.ToString();
        }
    }
}
