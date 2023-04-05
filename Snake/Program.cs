using System;
using System.Reflection;
using System.Threading.Tasks;


namespace Snake
{
    public class Program
    {
       public static int maxScreenWidth = 60;                            //window sizes
       public static int maxScreenHeight = 46;

        public static void Main(string[] args)
        {
            
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;       //text colour
            
            Console.Title = "Snake_by_Rybazxs";                 //window title
            Console.WindowWidth = maxScreenWidth;               //window sizes exsecutor
            Console.WindowHeight = maxScreenHeight;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
           // MakeBoard.ascii_snake();
           // MakeBoard.ascii_TextLogo();

            //Console.ReadKey();
            Console.Clear();

            
            //MakeBoard.ascii_snake();
            MakeBoard makeBoard = new MakeBoard();
            
            Snake snake = new Snake();  
            


            while (true)
            {


                makeBoard.drawBoard();
                snake.Controll();
                snake.Logic();
                Console.Clear();

            }
            //Menu.menu();     
      
        }
    }
}
