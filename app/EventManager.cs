using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class EventManager
    {
        public static void OnFormClosed(object? sender, EventArgs e)
        {
            //AesHelper.EncryptFile();


            FileManager.DeleteFile(FileManager.AccountFilePath);
        }
    }
}
