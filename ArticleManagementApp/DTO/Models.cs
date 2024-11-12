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
            public DateTime NgayNop { get; set; }
            public DateTime NgayXuLy { get; set; }
            public string TrangThai { get; set; }
            public BaiBao() { }
            public BaiBao(DataRow dataRow)
            {
                this.ID = dataRow["ReportID"].ToString();
                this.TenBaiBao = dataRow["ReportTitle"].ToString();
                this.NgayNop = Convert.ToDateTime(dataRow["PublicationYear"]);
                this.NgayXuLy = Convert.ToDateTime(dataRow["PublicationYear"]);
                this.TrangThai = dataRow["Status"].ToString();
            }
        }

        public class Users
        {
            public string ID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }
    }
}
