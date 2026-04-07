using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI2
{
    internal class Logic
    {
        public static string GetEncryptedText(string text)
        {
            if (string.IsNullOrEmpty(text)) 
                return "";
            char[] characters = text.ToCharArray();
            
            for (int i = 0; i < characters.Length; i++)
            {
                switch (characters[i])
                {
                    case 'а': characters[i] = 'б'; break;
                    case 'б': characters[i] = 'в'; break;
                    case 'в': characters[i] = 'г'; break;
                    case 'г': characters[i] = 'д'; break;
                    case 'д': characters[i] = 'е'; break;
                    case 'е': characters[i] = 'ё'; break;
                    case 'ё': characters[i] = 'ж'; break;
                    case 'ж': characters[i] = 'з'; break;
                    case 'з': characters[i] = 'и'; break;
                    case 'и': characters[i] = 'й'; break;
                    case 'й': characters[i] = 'к'; break;
                    case 'к': characters[i] = 'л'; break;
                    case 'л': characters[i] = 'м'; break;
                    case 'м': characters[i] = 'н'; break;
                    case 'н': characters[i] = 'о'; break;
                    case 'о': characters[i] = 'п'; break;
                    case 'п': characters[i] = 'р'; break;
                    case 'р': characters[i] = 'с'; break;
                    case 'с': characters[i] = 'т'; break;
                    case 'т': characters[i] = 'у'; break;
                    case 'у': characters[i] = 'ф'; break;
                    case 'ф': characters[i] = 'х'; break;
                    case 'х': characters[i] = 'ц'; break;
                    case 'ц': characters[i] = 'ч'; break;
                    case 'ч': characters[i] = 'ш'; break;
                    case 'ш': characters[i] = 'щ'; break;
                    case 'щ': characters[i] = 'ъ'; break;
                    case 'ъ': characters[i] = 'ы'; break;
                    case 'ы': characters[i] = 'ь'; break;
                    case 'ь': characters[i] = 'э'; break;
                    case 'э': characters[i] = 'ю'; break;
                    case 'ю': characters[i] = 'я'; break;
                    case 'я': characters[i] = 'а'; break;

                    case 'А': characters[i] = 'Б'; break;
                    case 'Б': characters[i] = 'В'; break;
                    case 'В': characters[i] = 'Г'; break;
                    case 'Г': characters[i] = 'Д'; break;
                    case 'Д': characters[i] = 'Е'; break;
                    case 'Е': characters[i] = 'Ё'; break;
                    case 'Ё': characters[i] = 'Ж'; break;
                    case 'Ж': characters[i] = 'З'; break;
                    case 'З': characters[i] = 'И'; break;
                    case 'И': characters[i] = 'Й'; break;
                    case 'Й': characters[i] = 'К'; break;
                    case 'К': characters[i] = 'Л'; break;
                    case 'Л': characters[i] = 'М'; break;
                    case 'М': characters[i] = 'Н'; break;
                    case 'Н': characters[i] = 'О'; break;
                    case 'О': characters[i] = 'П'; break;
                    case 'П': characters[i] = 'Р'; break;
                    case 'Р': characters[i] = 'С'; break;
                    case 'С': characters[i] = 'Т'; break;
                    case 'Т': characters[i] = 'У'; break;
                    case 'У': characters[i] = 'Ф'; break;
                    case 'Ф': characters[i] = 'Х'; break;
                    case 'Х': characters[i] = 'Ц'; break;
                    case 'Ц': characters[i] = 'Ч'; break;
                    case 'Ч': characters[i] = 'Ш'; break;
                    case 'Ш': characters[i] = 'Щ'; break;
                    case 'Щ': characters[i] = 'Ъ'; break;
                    case 'Ъ': characters[i] = 'Ы'; break;
                    case 'Ы': characters[i] = 'Ь'; break;
                    case 'Ь': characters[i] = 'Э'; break;
                    case 'Э': characters[i] = 'Ю'; break;
                    case 'Ю': characters[i] = 'Я'; break;
                    case 'Я': characters[i] = 'А'; break;
                }
            }
            return new string(characters);
        }
    }
}
