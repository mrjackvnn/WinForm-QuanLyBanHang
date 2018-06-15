using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyBanHang.Model
{
    class DatabaseSonGaming
    {
        SqlConnection sqlCnn;
        SqlCommand sqlCm;
        SqlDataAdapter sqlDa;
        DataSet ds;
        public DatabaseSonGaming()
        {
            string sqlQuery = "Data Source=sonsiho\\sonsiho;Initial Catalog=SonGaming;Integrated Security=True";
            sqlCnn = new SqlConnection(sqlQuery);
        }

        public DataTable Execute(string sqlQuery)
        {
            sqlDa = new SqlDataAdapter(sqlQuery, sqlCnn);
            ds = new DataSet();
            sqlDa.Fill(ds);
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string sqlQuery)
        {
            sqlCm = new SqlCommand(sqlQuery,sqlCnn);
            sqlCnn.Open();
            sqlCm.ExecuteNonQuery();
            sqlCnn.Close();
        }
    }
}
