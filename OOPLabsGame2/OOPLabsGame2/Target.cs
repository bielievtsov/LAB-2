using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabsGame2
{
    class Target : MatrixElement
    {
        public Target()
        {

        }
        public override string Draw(string hero)
        {
            string result = "";
            for (int i = 0; i < hero.Length; i++)
            {
                result += Icon;
            }
            return result;
        }
        public int value { get; set; }
    }
}
