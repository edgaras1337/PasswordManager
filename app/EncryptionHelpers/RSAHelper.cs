using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace app.EncryptionHelpers
{
    public class RSAHelper
    {
        private static string _privPem = @"-----BEGIN RSA PRIVATE KEY-----
MIIBOAIBAAJAbVRiHRfPwhCmWYs4rg7wEmtglosch0ZKSPYRY3uYAVkK5q1ek8FL
CSMx++aFqPS+e4f9zJoEYuCIJJI26XeSjQIDAQABAkAMiV+SzHczXqtkmzVNqELZ
KdzyhlMoI+RCx4yo5rRAeyjPGFk+RUiUsewT/ng7pTByoMgvP8n+lfU6ls2uoYsB
AiEA11VwgXPRhMi/DgB/OeRVSEGuSE93AR9SkbF4Cr9mKsECIQCB+g0PCxIeARS1
TpsrZvaY8dQppmy4t2lze/39yWrWzQIgGe/qq00eEZZ0nOUmbfy44Qk4SvF3biUt
turfgLvpPIECIF09qjyObpLDp71hBIOgO2sAoHi4gOoJ+UX1PwHeihxJAiBcAby7
bQloXmnrc+ypoNHWK/w9Oxqp7d1ktL7YQeM4Bw==
-----END RSA PRIVATE KEY-----";

        public static string EncryptPassword(string plainText)
        {
            var bytes = Encoding.UTF8.GetBytes(plainText);
            using var rsa = new RSACryptoServiceProvider();
            rsa.ImportFromPem(_privPem);

            var y = rsa.Encrypt(bytes, RSAEncryptionPadding.Pkcs1);

            return Convert.ToBase64String(y);
        }

        public static string DecryptPassword(string cipherText)
        {
            var bytes = Convert.FromBase64String(cipherText);
            using var rsa = new RSACryptoServiceProvider();
            rsa.ImportFromPem(_privPem);

            var x = rsa.Decrypt(bytes, RSAEncryptionPadding.Pkcs1);

            return Encoding.UTF8.GetString(x);
        }
    }
}
