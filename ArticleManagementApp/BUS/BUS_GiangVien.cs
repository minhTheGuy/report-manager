using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleManagementApp.DAO;
using ArticleManagementApp.DTO;
using ArticleManagementApp.GUI;

namespace ArticleManagementApp.BUS
{
    internal class BUS_GiangVien
    {
        private static BUS_GiangVien instance;
        public static BUS_GiangVien Instance
        {
            get { if (instance == null) instance = new BUS_GiangVien(); return BUS_GiangVien.instance; }
        }

        private BUS_GiangVien() { }

        public void SetGiangVienSession(string email)
        {
            DataRow data = BUS_GiangVien.Instance.GetGiangVienInfoByEmail(email);
            AccountSession.Id = Convert.ToInt32(data["id"]);
            AccountSession.Role = data["hocvi"].ToString();
            AccountSession.Email = email;
        }

        public DataRow GetGiangVienInfoById(int id)
        {
            return DAOGiangVien.Instance.GetGiangVienInfoById(id);
        }

        public DataRow GetGiangVienInfoByEmail(string email)
        {
            return DAOGiangVien.Instance.GetGiangVienInfoByEmail(email);
        }

        public List<string> GetGiangVienDashboardData()
        {
            List<string> datas = [];
            DataRow data = DAOGiangVien.Instance.GetGiangVienDashboardStatistic(AccountSession.Id);
            foreach (DataColumn item in data.Table.Columns)
            {
                datas.Add(data[item].ToString());
            }

            return datas;
        }

        public DataRow GetReportById(int id)
        {
            return DAOReport.Instance.GetReportById(id);
        }

        public List<Models.BaiBao> GetReportsByEmail(string email)
        {
            List<Models.BaiBao> reports = [];
            DataTable data = DAO.DAOReport.Instance.GetReportsByEmail(email);
            foreach (DataRow item in data.Rows)
            {
                Models.BaiBao report = new(item);
                reports.Add(report);
            }
            return reports;
        }

        public List<Models.BaiBao> GetReportsByStatus(string email, string status)
        {
            List<Models.BaiBao> reports = GetReportsByEmail(email);
            return reports.Where(report => report.TrangThai == status).ToList();
        }

        public bool InsertReportByGiangVien(object[] parameters)
        {
            return DAOReport.Instance.InsertReportByGiangVien(parameters);
        }

        public DataTable SearchGiangVienReports(string keyword, int gv_id)
        {
            return DAOReport.Instance.SearchGiangVienReports(keyword, gv_id);
        }
    }
}
