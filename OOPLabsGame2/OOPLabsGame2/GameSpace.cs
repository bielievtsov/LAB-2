using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabsGame2
{
    class GameSpace
    {
        public GameSpace()
        {

        }

        public virtual void View(string[,] mass)
        {
            int rows = mass.GetUpperBound(0)+1;
            int columns = mass.Length / rows;

            for (int i = 0; i < rows; i++)
            {                
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mass[i, j]);
                    
                }
                Console.Write("\n");              
            }
        }
    }
}