using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Events
{
    public class FileEvent
    {
        public event EventHandler OnFileUpdate;

        public void Update(List<PasswordContent> passwords)
        {
            passwords = FileManager.ReadPasswords(ApplicationUser.AccountFilePath!);

            OnFileUpdate?.Invoke(this, null);
        }
    }
}
