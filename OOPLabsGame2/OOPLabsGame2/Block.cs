using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabsGame2
{
    class Block : MatrixElement
    {
        public int health_point { get; set; }
        public override string Draw( string hero)
        {
            string result = "";
            for (int i = 0; i < hero.Length; i++)
            {
                result += Icon;
            }
            return result;
        }
    }
}
