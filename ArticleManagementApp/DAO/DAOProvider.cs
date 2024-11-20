using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleManagementApp.DTO;

namespace ArticleManagementApp.DAO
{
    internal class DAOProvider
    {
        private static DAOProvider instance;

        public static DAOProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOProvider();
                }
                return instance;
            }
        }

        private DAOProvider() { }

        private const string connectionString = "Data Source=MINH-DANG;Initial Catalog=ArticleDB;Integrated Security=True;TrustServerCertificate=True";

        public DataTable ExecuteQuery(String query, object[] parameters = null)
        {
            DataTable data = new();
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new(query, connection);

                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(para, parameters[i++]);
                        }
                    }
                }
                SqlDataAdapter adapter = new(cmd);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }


        public int ExecuteNonQuery(String query, object[] parameters = null)
        {

            int data = 0;
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new(query, connection);

                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(para, parameters[i++]);
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(String query, object[] parameters = null)
        {

            object data = 0;
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new(query, connection);

                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(para, parameters[i++]);
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
