using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECOApp.DTO
{
    internal class Models
    {
        public class BaiBao
        {
            public required string ID { get; set; }
            public required string TenBaiBao { get; set; }
            public DateTime NgayNop { get; set; }
            public DateTime NgayXuLy { get; set; }
            public required string TrangThai { get; set; }
        }
    }
}
