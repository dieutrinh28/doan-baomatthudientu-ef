using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu.Lớp_hỗ_trợ
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
}
