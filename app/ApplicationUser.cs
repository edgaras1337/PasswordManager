using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class ApplicationUser
    {
        public static string? Name { get; set; }
        public static string? Password { get; set; }
        //public static string? PasswordHash { get; set; }
        public static string? AccountFilePath { get; set; }
        public static string? AccountFilePathEnc { get; set; }

        public static string StaticToString() => $"{Name},{Password}\n";

        public static void LogOut()
        {
            Name = null;
            Password = null;
            AccountFilePath = null;
            AccountFilePathEnc = null;
        }
    }
}
