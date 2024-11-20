using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleManagementApp.DAO
{
    internal class DAOGiangVien
    {
        private static DAOGiangVien instance;
        public static DAOGiangVien Instance
        {
            get
            {
                if (instance == null) instance = new DAOGiangVien(); return DAOGiangVien.instance;
            }
        }

        private DAOGiangVien() { }

        public DataRow GetGiangVienInfoById(string id)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetGiangVienInfoById @id", new object[] { id }).Rows[0];

        }
        public DataRow GetGiangVienInfoByEmail(string email)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetGiangVienInfoByEmail @email", new object[] { email }).Rows[0];
        }
        public DataRow GetGiangVienDashboardStatistic(string gv_id)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetDashboardStatisticsForGiangVien @GV_ID", new object[] { gv_id }).Rows[0];
        }

        public DataTable GetReportStatisticByYear(int year, string gv_id)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetReportStatisticByYear @year , @GV_ID", new object[] { year, gv_id });
        }

        public bool ChangeAvatar(string id, byte[] avatar)
        {
            return DAOProvider.Instance.ExecuteNonQuery("exec sp_ChangeAvatarGV @id , @path", new object[] { id, avatar }) > 0;
        }

        public bool UpdateInforGV(object[] parameters)
        {
            return DAOProvider.Instance.ExecuteNonQuery("exec sp_UpdateInforGV @MaGV , @HoTen , @HocHam , @HocVi", parameters) > 0;
        }
    }
}