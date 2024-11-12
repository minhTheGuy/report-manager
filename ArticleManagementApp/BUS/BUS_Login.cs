using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ArticleManagementApp.DAO;

namespace ArticleManagementApp.BUS
{
    internal class BUS_Login
    {
        private static BUS_Login instance;

        public static BUS_Login Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Login();
                }
                return instance;
            }
        }

        private BUS_Login() { }

        public bool Login(string username, string password)
        {
            return DAOLogin.Instance.ValidateLogin(username, password).Rows.Count > 0;
        }

        public int CheckRole(string email)
        {
            DataRow row = DAOLogin.Instance.GetAccountByEmail(email);
            if (row == null)
                return 0;
            return int.Parse(row["loai"].ToString());
        }
    }
}
