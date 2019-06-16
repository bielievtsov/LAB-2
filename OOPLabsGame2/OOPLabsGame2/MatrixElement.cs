using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabsGame2
{
    abstract class MatrixElement
    {
        public  virtual int X { get; set; }//х координата в массиве
        public virtual int Y { get; set; }//у координата в массив
        public string Icon { get; set; }//поле-иконка
        public MatrixElement()//конструктор класса
        {

        }
        public virtual string Draw(string element)
        {
            {
                return Icon;
            }//метод-отображение
        }//метод-прорисовка элемента на матрице
        public string previous;// предыдущий элемент
        public string next;// следующий элемент
    }
}

