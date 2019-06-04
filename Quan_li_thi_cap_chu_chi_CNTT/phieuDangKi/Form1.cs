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
namespace phieuDangKi
{
    public partial class PhieuDangKi : Form
    {
        Quan_li_thi_chung_chi_CNTTEntities dt = new Quan_li_thi_chung_chi_CNTTEntities();
        public PhieuDangKi()
        {
            InitializeComponent();
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
        string showCheckbox(string a, Panel pl)
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
        public static bool Test_Email(string input)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(input))
                return (true);
            else
                return (false);
        }
        public static bool Test_Hoten(string input)
        {
            string strRegex = @"^[A-Z]+[a-zA-Z""'\s-]*$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(input))
                return (true);
            else
                return (false);
        }
        public bool IsNumber(string input)
        {
            string strRegex = @"^[-+]?[0-9]*\.?[0-9]+$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(input))
                return (true);
            else
                return (false);
        }
        void dangky()
        {
            ChitietDK ct = new ChitietDK();
            LePhi lp = new LePhi();
            ThiSinh ts = new ThiSinh();
            XacNhan xn = new XacNhan();
            ts.SBD = tb_ma.Text;
            ct.SBD = tb_ma.Text;
            ct.Email = tb_mail.Text;
            ct.Madk = "DK01";
            ts.HoTen = tb_hoten.Text;
            ts.Ngaysinh = dt_ngaysinh.Value;
            ts.Gioitinh = showRadio(ts.Gioitinh, panelgioitinh);
            ts.CMT = tb_cmt.Text;
            ts.SDT = tb_sdt.Text;
            lp.Nhucau = showRadio(lp.Nhucau, panelnhucau);
            lp.ThuocHV = showRadio(lp.ThuocHV, panelhocvien);
            lp.Trinhdo = showCheckbox(lp.Trinhdo, paneltrinhdo);
            var model = from p in dt.LePhis where p.Nhucau == lp.Nhucau && p.Trinhdo == lp.Trinhdo && p.ThuocHV == lp.ThuocHV select p;
            foreach (LePhi item in model)
            {
                ts.Maluachon = item.Maluachon;
            }
            xn.Daxacnhan = Convert.ToBoolean(0);
            xn.SBD = tb_ma.Text;
            dt.ThiSinhs.Add(ts);
            dt.ChitietDKs.Add(ct);
            dt.XacNhans.Add(xn);
            dt.SaveChanges();
        }
        private void bt_dangki_Click_1(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("bạn phải điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Test_Email(tb_mail.Text) == true&&IsNumber(tb_cmt.Text)==true&&IsNumber(tb_sdt.Text)==true)
                {   
                    dangky();
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Email hoặc CMT hoặc SDT không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bt_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
