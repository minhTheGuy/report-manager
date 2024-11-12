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

        public BindingList<Models.BaiBao> GetSampleData()
        {
            // sample data
            BindingList<Models.BaiBao> sampleData =
            [
                new Models.BaiBao
                {
                    ID = "BG001",
                    TenBaiBao = "Bài giảng 1",
                    NgayNop = DateTime.Now,
                    NgayXuLy = DateTime.Now,
                    TrangThai = "Đã xử lý"
                },
                new Models.BaiBao
                {
                    ID = "BG002",
                    TenBaiBao = "Bài giảng 2",
                    NgayNop = DateTime.Now,
                    NgayXuLy = DateTime.Now,
                    TrangThai = "Đã xử lý"
                },
                new Models.BaiBao
                {
                    ID = "BG003",
                    TenBaiBao = "Bài giảng 3",
                    NgayNop = DateTime.Now,
                    NgayXuLy = DateTime.Now,
                    TrangThai = "Đã xử lý"
                }
            ];

            return sampleData;
        }

        public BindingList<Models.Users> GetUsers()
        {
            // sample data
            BindingList<Models.Users> sampleData =
            [
                new Models.Users
                {
                    ID = "U001",
                    Username = "admin",
                    Password = "admin",
                    Role = "Admin"
                },
                new Models.Users
                {
                    ID = "U002",
                    Username = "user",
                    Password = "user",
                    Role = "User"
                }
            ];

            return sampleData;
        }

    }
}
