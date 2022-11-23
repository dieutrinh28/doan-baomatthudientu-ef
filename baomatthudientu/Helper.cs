using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baomatthudientu.DTO;

namespace baomatthudientu
{
    class SpecialCharacter
    {
        public char c { get; set; }
        public int indexString { get; set; }
        public int indexInsert { get; set; }
        public SpecialCharacter(char c, int indexString, int indexInsert)
        {
            this.c = c;
            this.indexString = indexString;
            this.indexInsert = indexInsert;
        }
    }
    class UpperCharacter
    {
        public int indexString { get; set; }
        public int indexUpper { get; set; }
        public UpperCharacter(int indexString, int indexUpper)
        {
            this.indexUpper = indexUpper;
            this.indexString = indexString;
        }
    }
    internal class Helper
    {
        public static string emailUser { get; set; }
        public static object key { get; set; }
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
                        //s = s.Replace(s[item.indexUpper], char.ToUpper(s[item.indexUpper]));
                        s = s.Insert(item.indexUpper, s[item.indexUpper].ToString().ToUpper());
                        s = s.Remove(item.indexUpper + 1, 1);
                        // = s.Insert(item.indexUpper, s[item.indexUpper].ToString().ToUpper());
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
