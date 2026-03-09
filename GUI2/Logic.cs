using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI2
{
    internal class Logic
    {
        public static string GetMena(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";
            return text.Replace("муха", "слон").Replace("Муха", "Слон");
        }
    }
}
