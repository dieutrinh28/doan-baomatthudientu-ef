using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    internal class EnMail
    {
        public string text { get; set; }
        public List<UpperCharacter> IndexUpper = new List<UpperCharacter>();
        public List<SpecialCharacter> SpecialChar = new List<SpecialCharacter>();
        public string state { get; set; }
        public string subject { get; set; }
        public string sender { get; set; }
        public DateTime date { get; set; }
        public EnMail(string text, List<UpperCharacter> IndexUpper, List<SpecialCharacter> SpecialChar)
        {
            this.text = text;
            this.IndexUpper = IndexUpper;
            this.SpecialChar = SpecialChar;
        }
    }
}
