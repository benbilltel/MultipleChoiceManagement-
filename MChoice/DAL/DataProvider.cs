using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DAL
{
    public class DataProvider
    {
        private string _connectionString = @"Data Source=BEN;Initial Catalog=MChoiceManagement;Integrated Security=True";

        public DataProvider() { }
        public DataTable ExecuteQuerry(string querry)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }
        public int ExecuteNonQuerry(string querry)
        {
            int recordsChanged = 0;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(querry, conn);
                recordsChanged = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return recordsChanged;

        }
        public object ExecuteScalar(string querry)
        {
            object firstCell = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(querry, conn);
                firstCell = cmd.ExecuteScalar();
                conn.Close();
            }
            return firstCell;

        }
    }
}
