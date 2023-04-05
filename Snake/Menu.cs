using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Menu
    {
        public static void menu()
        {
            string[] menuOptions = new string[] { "New Game\t", "Options\t", "Difficulty\t", "Scores\t", "Exit\t" };
            int menuSelect = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                
                MakeBoard.ascii_snake();

                Console.SetCursorPosition(9, 39);
                Console.WriteLine("Press Backspace, Enter and Arrows to navigate");
                
                Console.SetCursorPosition(0, 40);
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    Console.WriteLine((i == menuSelect ? "--> " : "") + menuOptions[i] + (i == menuSelect ? "<--" : ""));
                }

                var keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                {
                    menuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                {
                    menuSelect--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (menuSelect)
                    {
                        case 0:

                            MakeBoard makeBoard = new MakeBoard();
                            Snake snake = new Snake();
                            Console.Clear();
                           // makeBoard.drawBoard();
                            snake.Controll();
                            snake.Logic();
                           
                            
                                
                            

                            break;
                        case 1:
                            //Options();
                            break;
                        case 2:
                            //Difficulty();
                            break;
                        case 3:
                            //Scores();
                            break;
                        case 4:
                            //Exit();
                            break;
                    }
                }
            }
        }
    }
}


