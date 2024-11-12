using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleManagementApp.DAO;
using ArticleManagementApp.GUI;

namespace ArticleManagementApp.BUS
{
    internal class BUS_KiemDuyet
    {
        private static BUS_KiemDuyet instance;
        public static BUS_KiemDuyet Instance
        {
            get { if (instance == null) instance = new BUS_KiemDuyet(); return BUS_KiemDuyet.instance; }
        }

        private BUS_KiemDuyet() { }

        public void SetKiemDuyetSession(string email)
        {
            DataRow dt = DAOKiemDuyet.Instance.GetKiemDuyetInfoByEmail(email);
            AccountSession.Id = Convert.ToInt32(dt["id"]);
            AccountSession.Email = dt["email"].ToString();
            AccountSession.Role = "Kiểm duyệt";
        }

        public DataTable GetAllReports()
        {
            return DAOReport.Instance.GetReports();
        }

        public DataRow GetKiemDuyetInfoByEmail(string email)
        {
            return DAOKiemDuyet.Instance.GetKiemDuyetInfoByEmail(email);
        }

        public List<string> GetDashboardStatisticsForKiemDuyet()
        {
            List<string> strings = new();
            DataRow dataRow = DAOKiemDuyet.Instance.GetDashboardStatisticsForKiemDuyet();
            foreach(DataColumn column in dataRow.Table.Columns)
            {
                strings.Add(dataRow[column].ToString());
            }

            return strings;
        }

        public List<DataRow> GetReportDashboardForKhoa()
        {
            List<DataRow> dataRows = new();
            DataTable dataTable = DAOKiemDuyet.Instance.GetReportDashboardForKhoa();
            foreach (DataRow row in dataTable.Rows)
            {
                dataRows.Add(row);
            }

            return dataRows;
        }

    }
}
