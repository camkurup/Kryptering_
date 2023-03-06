using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryptering
{
    internal class Encrypter
    {
        public string Encrypt(string text) 
        {
            string value = "";
            char konvertedSign;

            foreach (char sign in text)
            {
                int unicode = sign;
                if (unicode < 127)
                {
                    unicode++;
                }
                else if (unicode == 127)
                {
                    unicode = 1;
                }
                else
                {
                    continue;
                }
                konvertedSign = System.Convert.ToChar(unicode);
                value += konvertedSign;
            }

            return value;
        }

        public string Decrypt(string text)
        {
            string value = "";
            char konvertedSign;

            foreach (char sign in text)
            {
                int unicode = sign;
                if (unicode < 127)
                {
                    unicode--;
                }
                else if (unicode == 127)
                {
                    unicode = 1;
                }
                else
                {
                    continue;
                }
                konvertedSign = System.Convert.ToChar(unicode);
                value += konvertedSign;
            }

            return value;
        }
    }
}
