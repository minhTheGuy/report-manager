using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleManagementApp.DTO
{
    internal class Models
    {
        public class BaiBao
        {
            public string ID { get; set; }
            public string TenBaiBao { get; set; }
            public string Location { get; set; }
            public string TrangThai { get; set; }
            public string Note { get; set; }
            public BaiBao() { }
            public BaiBao(DataRow dataRow)
            {
                this.ID = dataRow["ReportID"].ToString();
                this.TenBaiBao = dataRow["JournalTitle"].ToString();
                this.Location = dataRow["ReportTitle"].ToString();
                this.TrangThai = dataRow["Status"].ToString();
                this.Note = dataRow["Notes"].ToString();
            }
        }

        public class Users
        {
            public string ID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        public class GiangVien
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int SLBB { get; set; }
            public int SoGio { get; set; }
            public string HocVi { get; set; }
            public DateTime JoinDate { get; set; }
            public string Faculty { get; set; }
            public GiangVien() { }
            public GiangVien(DataRow dataRow)
            {
                this.ID = dataRow["id"].ToString();
                this.Name = dataRow["name"].ToString();
                this.SLBB = Convert.ToInt32(dataRow["slbb"]);
                this.SoGio = Convert.ToInt32(dataRow["sogio"]);
                this.HocVi = dataRow["hocvi"].ToString();
                this.JoinDate = Convert.ToDateTime(dataRow["join_date"]);
                this.Faculty = dataRow["Faculty"].ToString();
            }
        }
    }
}
