using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baomatthudientu.DTO;

namespace baomatthudientu
{
    internal class Helper
    {
        public static UserDTO user { get; set; } 
        public static string key { get; set; }
        public static void PopChar(ref List<SpecialCharacter> SpecialChar, ref List<UpperCharacter> IndexUpper, ref string[] split)
        {
            for (int m = 0; m < split.Length; m++)
            {

                string s = split[m];
                //Tìm số và kí tự đặc biệt để lưu 
                for (int i = 0; i < s.Length; i++)
                {
                    int unicode = s[i];
                    if (unicode < 65 || (unicode > 90 && unicode < 97) || unicode > 122)
                    {
                        SpecialChar.Add(new SpecialCharacter(s[i], m, i));
                    }
                }
                //Tìm số và kí tự đặc biệt để xóa
                bool repeat;
                do
                {
                    repeat = false;
                    for (int i = 0; i < s.Length; i++)
                    {
                        int unicode = s[i];
                        if (unicode < 65 || (unicode > 90 && unicode < 97) || unicode > 122)
                        {
                            s = s.Remove(i, 1);
                            repeat = true;
                            break;
                        }
                    }
                }
                while (repeat);
                // Xem kí tự nào viết hoa
                for (int j = 0; j < s.Length; j++)
                {
                    int unicode = s[j];
                    if (unicode <= 90 && unicode >= 65)
                    {
                        IndexUpper.Add(new UpperCharacter(m, j));
                    }
                }
                split[m] = s;
            }
        }
        public static void PushChar(List<SpecialCharacter> SpecialChar, List<UpperCharacter> IndexUpper, string[] split, ref string result)
        {
            for (int i = 0; i < split.Length; i++)
            {
                
                string s = split[i];
                
                // Viết hoa các kí tự
                foreach (UpperCharacter item in IndexUpper)
                {
                    if (item.indexString == i)
                    {
                        s = s.Replace(s[item.indexUpper], char.ToUpper(s[item.indexUpper]));
                    }
                }
                //Thêm các kí tự khác
                foreach (SpecialCharacter item in SpecialChar)
                {
                    if (item.indexString == i)
                    {
                        s = s.Insert(item.indexInsert, item.c.ToString());
                    }
                }
                result += s + " ";
            }
        }
    }
}
