using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu.Lớp_hỗ_trợ
{
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
}
