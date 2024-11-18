using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleManagementApp.DAO
{
    internal class DAOGiamSat
    {
        private static DAOGiamSat instance;
        public static DAOGiamSat Instance
        {
            get
            {
                if (instance == null) instance = new DAOGiamSat(); return DAOGiamSat.instance;
            }
        }

        private DAOGiamSat() { }

        public DataRow GetGiamSatInfoByEmail(string email)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetGiamSatInfoByEmail @Email", new object[] { email }).Rows[0];
        }

        public DataTable GetGiangVienList()
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetGiangVienList");
        }

        public DataRow sp_GetGiamSatDashboard()
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetGiamSatDashboard").Rows[0];
        }

        public DataTable GetGiamSatDashboardStatisticByYear(int year)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetGiamSatDashboardStatisticByYear @Year", new object[] { year });
        }
    }
}
