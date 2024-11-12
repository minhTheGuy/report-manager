using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleManagementApp.GUI
{
    internal class AccountSession
    {
        public static int Id { get; set; }
        public static string Email { get; set; }
        public static string Role { get; set; } = "Giảng viên";
        public static string Faculty { get; set; } = "CNTT";
    }
}
