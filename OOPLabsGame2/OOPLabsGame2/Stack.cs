using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabsGame2
{
    public class Stack
    {
        readonly string[] stack = new string[5];
        private int index = 0;
        public void  Add(string element)
        {
            stack[index] = element;
            index++;
        }
        public string Delete()
        {
            string x = stack[index];
            index--;
            return x;
        }
    }
}
