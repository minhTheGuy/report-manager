using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleManagementApp.DAO
{
    internal class DAOReport
    {
        private static DAOReport instance;
        public static DAOReport Instance
        {
            get { if (instance == null) instance = new DAOReport(); return DAOReport.instance; }
        }
        private DAOReport() { }

        public DataRow GetReportById(int id)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetReportById @id", new object[] { id }).Rows[0];
        }
        public DataTable GetReports()
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetReports");
        }

        public DataTable GetReportsById(string id)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetGiangVienReportsById @Id", new object[] { id });
        }

        public bool InsertReportByGiangVien(object[] parameters)
        {
            string query = "exec sp_SubmitReportByGiangVien @TenBaiBao , @NoiDangBai , @TacGiaChinh , @TacGiaHoTro , @LinkBB , @MaKhoa , @SoPH , @SoTrang , @NgayXB , @DOI , @MaMH , @MinhChung";
            return DAOProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetGiangVienByReportId(int id)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetGiangVienByReportId @id", new object[] { id });
        }

        public DataTable SearchGiangVienReports(string keyword, int gv_id)
        {
            string query = "exec sp_SearchGiangVienReports @keyword , @gv_id";
            return DAOProvider.Instance.ExecuteQuery(query, new object[] { keyword, gv_id });
        }
    }
}
