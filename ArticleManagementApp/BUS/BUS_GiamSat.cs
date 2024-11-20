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
    internal class BUS_GiamSat
    {
        private static BUS_GiamSat instance;
        public static BUS_GiamSat Instance
        {
            get
            {
                if (instance == null) instance = new BUS_GiamSat(); return BUS_GiamSat.instance;
            }
        }

        private BUS_GiamSat() { }

        public void SetGiamSatSession(string email)
        {
            DataRow data = BUS_GiamSat.Instance.GetGiamSatInfoByEmail(email);
            AccountSession.Id = data["id"].ToString();
            AccountSession.Role = "Giám sát";
        }

        public DataRow GetGiamSatInfoByEmail(string email)
        {
            return DAOGiamSat.Instance.GetGiamSatInfoByEmail(email);
        }

        public List<Models.GiangVien> GetGiangVienList()
        {
            DataTable data = DAOGiamSat.Instance.GetGiangVienList();
            List<Models.GiangVien> giangViens = new List<Models.GiangVien>();
            foreach (DataRow item in data.Rows)
            {
                Models.GiangVien giangVien = new(item);
                giangViens.Add(giangVien);
            }
            return giangViens;
        }

        public DataRow GetGiamSatDashboard()
        {
            return DAOGiamSat.Instance.sp_GetGiamSatDashboard();
        }
    }
}
