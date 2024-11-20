using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleManagementApp.GUI;

namespace ArticleManagementApp.DAO
{
    internal class DAOKiemDuyet
    {
        private static DAOKiemDuyet instance;
        public static DAOKiemDuyet Instance
        {
            get
            {
                if (instance == null) instance = new DAOKiemDuyet(); return DAOKiemDuyet.instance;
            }
        }

        private DAOKiemDuyet() { }

        public DataRow GetKiemDuyetInfoByEmail(string email)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetKiemDuyetInfoByEmail @Email", new object[] { email }).Rows[0];
        }

        public DataRow GetDashboardStatisticsForKiemDuyet()
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetDashboardStatisticsForKiemDuyet").Rows[0];
        }

        public DataTable GetReportDashboardForKhoa()
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetReportDashboardByFaculty");
        }

        public DataTable GetSubmittedReports()
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetSubmittedReports");
        }
    }
}
