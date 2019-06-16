using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabsGame2
{
    class Hero : MatrixElement
    {
        public Hero()
        {

        }
        public override string Draw(string hero)
        {
            return (Icon);
        }
        public string Prevoius { get; set; }
        public int Exp { get; set; }
    }
}
