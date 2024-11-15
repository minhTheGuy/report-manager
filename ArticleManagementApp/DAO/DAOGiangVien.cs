﻿using System;
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

        public DataRow GetGiangVienInfoByEmail(string email)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetGiangVienInfoByEmail @email", new object[] { email }).Rows[0];
        }
        public DataRow GetGiangVienDashboardStatistic(int gv_id)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetDashboardStatisticsForGiangVien @GV_ID", new object[] { gv_id }).Rows[0];
        }

        public DataTable GetReportStatisticByYear(int year, int gv_id)
        {
            return DAOProvider.Instance.ExecuteQuery("exec sp_GetReportStatisticByYear @year , @GV_ID", new object[] { year, gv_id });
        }
    }
}