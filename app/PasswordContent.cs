using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class PasswordContent
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Application { get; set; }
        public string? Comment { get; set; }

        public override string ToString() => $"{Name},{Password},{Application},{Comment}\n";

        public PasswordContent(string line)
        {
            var dataRow = line.Split(',');

            Name = dataRow[0];
            Password = dataRow[1];
            Application = dataRow[2];
            Comment = dataRow[3];
        }

        public PasswordContent()
        {
        }
    }
}
