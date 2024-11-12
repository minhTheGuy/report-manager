using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleManagementApp.DAO
{
    internal class DAOLogin
    {
        private static DAOLogin instance;
        public static DAOLogin Instance
        {
            get { if (instance == null) instance = new DAOLogin(); return DAOLogin.instance; }
        }

        private DAOLogin() { }

        public DataRow GetAccountByEmail(string email)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetAccountRoleByEmail @Email", new object[] { email }).Rows[0];
        }

        public DataTable ValidateLogin(string username, string password)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_CheckLogin @email , @password", new object[] { username, password });
        }

    }
}

