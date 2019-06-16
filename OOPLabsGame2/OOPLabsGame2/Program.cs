using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabsGame2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Hero hero = new Hero { Icon = "I", Exp = 0 };
            EmptyCell cell = new EmptyCell { Icon = " "};
            Block block = new Block { Icon = "#"};
            GameSpace p = new GameSpace();                       
            Logic logic = new Logic();
            Ladder ladder = new Ladder { Icon = "|" };
            Target gold = new Target { Icon = "@", value = 4 };
            string[,] mass = {{ $"{block.Draw(hero.Icon)}",$"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", },
                             { $"{block.Draw(hero.Icon)}",$"{gold.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{ladder.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", },
                             { $"{block.Draw(hero.Icon)}",$"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{ladder.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", },
                             { $"{block.Draw(hero.Icon)}",$"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{ladder.Draw(hero.Icon)}", $"{gold.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{gold.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", },
                             { $"{block.Draw(hero.Icon)}",$"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{ladder.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", },
                             { $"{block.Draw(hero.Icon)}",$"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{gold.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{hero.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{ladder.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{cell.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", },
                             { $"{block.Draw(hero.Icon)}",$"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", $"{block.Draw(hero.Icon)}", block.Draw(hero.Icon), },
                                                                                                                                                                                                                                                                                                                                };
            int exp = hero.Exp;
            void View() {
                while (true) {
                    var keyInfo = Console.ReadKey();
                    Console.Clear();
                    p.View(logic.MoveHero(keyInfo, mass, hero.Icon, cell.Icon, ladder.Icon, gold.Icon, out exp, gold.value));
                    Console.WriteLine("YOU NEED TO TAKE {0} MORE GOLD ", logic.Number_of_gold(mass, gold.Icon));
                    logic.Win(mass, gold.Icon);                 
                }
            }
            View();            
        }
    }
}

            