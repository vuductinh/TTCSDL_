using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_thi_cap_chu_chi_CNTT
{
    class Dataconection
    {
        public static string conection= "data source=TINH-PC;initial catalog=Quan_li_thi_chung_chi_CNTT;integrated security=True";
        public static DataSet Danhsach(string query)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection=new SqlConnection(conection))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conection);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt; ;
        }
        public static Boolean sua(string query)
        {
            Boolean check = true;
            SqlConnection connection = new SqlConnection(conection);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
            connection.Close();
        }
        public static bool IsNumber(string input)
        {
            string strRegex = @"^[-+]?[0-9]*\.?[0-9]+$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(input))
                return (true);
            else
                return (false);
        }
    }
}
