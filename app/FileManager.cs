using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class FileManager
    {
        public const string AccountsDirName = "Accounts";
        public static readonly string AccountDirPath = @$"{Directory.GetParent(Directory.GetCurrentDirectory())!
        .Parent!.Parent!.FullName}\{AccountsDirName}\";

        public static string CreateAccountFilePath(string fileName) => 
            @$"{AccountDirPath}\{fileName}ACCOUNT.csv";

        public static string CreateAccountEncFilePath(string fileName) =>
            @$"{AccountDirPath}\{fileName}ACCOUNT.enc";

        public static void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public static List<PasswordContent> ReadPasswords(string filePath)
        {
            var passwords = new List<PasswordContent>();
            var lines = (File.ReadAllLines(filePath))[1..];

            foreach (var line in lines) passwords.Add(new PasswordContent(line));

            return passwords;
        }
    }
}
