using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Model
{
    internal static class PasswordGenerator
    {
        private static string symbols = "qwertyuioplkjhgfdsazxcvbnm1234567890QWERTYUIOPASDFGHJKLXCZXCVBNM";
        private static char[] allowedSymbols = symbols.ToCharArray();
        private static int length = 14;
        
        public static string Generate()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(allowedSymbols.Length);
                sb.Append(allowedSymbols[index]);
            }

            return sb.ToString();
            
        }
    }
}
