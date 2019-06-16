using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabsGame2
{
    class Logic : MatrixElement
    {
        public int Number_of_gold(string[,] mas, string gold_icon)
        {
            return Check_The_Number(mas, gold_icon);
        }
        int hits = 0;
        public string[,] MoveHero(ConsoleKeyInfo keyInfo, string[,] mass, string hero, string emptysell, string ladder, string Gold, out int gold, int pr)
        {
            
            int rows = mass.GetUpperBound(0) + 1;
            int columns = mass.Length / rows;
            gold = 0;
            Get_Previous(mass, Get_X_Coords(hero, mass), Get_Y_Coords(hero, mass));
            previous = Prev();
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < columns; k++)
                    if (mass[i, k] == hero)
                    {
                        if (keyInfo.Key == ConsoleKey.RightArrow)
                        {
                            if ((i - 1) >= 0 && k - 1 >= 0 && (mass[i, k + 1] == emptysell || mass[i, k + 1] == ladder || mass[i, k + 1] == Gold))
                            {
                                return Move_A_Hero_To_Rigth(Get_X_Coords(hero, mass), Get_Y_Coords(hero, mass), mass, hero, emptysell, ladder, previous, next);
                            }
                        }
                        if (keyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            if ((i - 1) >= 0 && k - 1 >= 0 && (mass[i, k - 1] == emptysell || mass[i, k - 1] == ladder || mass[i, k - 1] == Gold))
                            {
                                return Move_A_Hero_To_Left(Get_X_Coords(hero, mass), Get_Y_Coords(hero, mass), mass, hero, emptysell, ladder, previous, next);
                            }
                        }
                        if (keyInfo.Key == ConsoleKey.UpArrow)
                        {
                            if ((i - 1) >= 0 && k - 1 >= 0 && (mass[i - 1, k] == emptysell || mass[i - 1, k] == ladder || mass[i - 1, k] == Gold))
                            {
                                return Move_A_Hero_To_Up(Get_X_Coords(hero, mass), Get_Y_Coords(hero, mass), mass, hero, emptysell, ladder, previous, next);
                            }
                        }
                        if (hits % 2 == 0)
                        {
                            if ((i - 1) >= 0 && k - 1 >= 0 && mass[i + 1, k] == "#")
                            {
                                return Gravity(Get_X_Coords(hero, mass), Get_Y_Coords(hero, mass), mass, hero, emptysell);
                            }
                        }
                        if (keyInfo.Key == ConsoleKey.DownArrow)
                        {
                            hits++;
                            if ((i - 1) >= 0 && k - 1 >= 0 && (mass[i + 1, k] == emptysell || mass[i + 1, k] == ladder || mass[i + 1, k] == Gold))
                            {                                
                                return Move_A_Hero_To_Down(Get_X_Coords(hero, mass), Get_Y_Coords(hero, mass), mass, hero, ladder, next, previous);
                            }
                        }

                        
                    }
            }
            return mass;
        }//собираем всё вместе
        public int Get_X_Coords(string element, string[,] arr)
        {
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    if (arr[i, j] == element)
                    {
                        return i;
                    }
            }
            return -1;
        }//получем место элемента в ряду
        public int Get_Y_Coords(string element, string[,] arr)
        {
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (arr[i, j] == element)
                    {
                        return j;
                    }
                }
            }
            return -1;
        }//получаем место элемента в столбце
        public string[,] Move_A_Hero_To_Rigth(int x, int y, string[,] mas, string hero, string cell, string ladder, string p, string n)
        {

            if(p == ladder)
            {
                mas[x, y + 1] = hero;
                mas[x, y] = previous;
                return mas;
            }
            mas[x, y + 1] = hero;
            mas[x, y] = cell;
            return mas;
        }//возвращаем массив, в ктр игрок походил вправо
        public string[,] Move_A_Hero_To_Left(int x, int y, string[,] mas, string hero, string cell, string ladder, string p, string n)
        {
            if (p == ladder)
            {
                mas[x, y - 1] = hero;
                mas[x, y] = previous;
                return mas;
            }
            mas[x, y] = cell;
            mas[x, y - 1] = hero;
            return mas;
        }//возвращаем массив, в ктр игрок походил влево
        public string[,] Move_A_Hero_To_Down(int x, int y, string[,] mas, string hero, string ladder, string n, string p)
        {

            if (n == "|" && p == "#")
            {
                mas[x + 1, y] = hero;
                mas[x, y] = " ";
                return mas;
            }
            mas[x + 1, y] = hero;
            mas[x, y] = ladder;            
            return mas;
        }//возвращаем массив, в ктр игрок походил вниз
        public string[,] Move_A_Hero_To_Up(int x, int y, string[,] mas, string hero, string cell, string ladder, string p, string n)
        {
            if (p == ladder)
            {
                mas[x - 1, y] = hero;
                mas[x, y] = previous;
                return mas;
            }
            mas[x, y] = ladder;
            mas[x - 1, y] = hero;
            return mas;
        }//возвращаем массив, в ктр игрок походил вверх
        public string[,] Gravity(int x, int y, string[,] mas, string hero, string cell)
        {
            mas[x, y] = cell;
            mas[x + 1, y] = " ";
            mas[x + 2, y] = hero;
            return mas;
        }
        Stack stack = new Stack();
        public void Get_Previous(string[,] mas, int x, int y)
        {
            stack.Add(mas[x, y+1]);
        }
        public string Prev()
        {
            return stack.Delete(); 
        }//получаем предыдущий элемент
        public int Check_The_Number(string[,] mas, string element)
        {
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    if (mas[i, j] == element)
                    {
                        sum++;
                    }
            }
            return sum;
        }//проверяем количество голды
        public bool Win(string[,] mas, string element)
        {
            int number_of_elements = Check_The_Number(mas, element);
            if (number_of_elements == 0)
            {
                Console.Beep();
                Console.Clear();
                Console.WriteLine("CONGRATULATIONS U WON");
                Console.Beep();
                return false;
            }
            return true;
        }//метод-победа
    }
}

