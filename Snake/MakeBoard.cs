using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class MakeBoard
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public  MakeBoard()                                 
        {
            Width = 58;
            Height = 40;
        }
        public void drawBoard()
        {
           
            
            
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("─");
            }
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, Height);
                Console.Write("─");
            }

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("│");
            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.Write("│");
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┌");
            Console.SetCursorPosition((Width), 0);
            Console.WriteLine("┐");
            Console.SetCursorPosition(0, (Height));
            Console.WriteLine("└");
            Console.SetCursorPosition((Width), (Height));
            Console.WriteLine("┘");
        }
        //something in this code not working .... above same idea but working :>

        //console.writeline("height");          
        ////konwertuje readline (string) na int
        //int height = convert.toint32(console.readline());
        //console.writeline("width");
        //int width = convert.toint32(console.readline());

        //Console.Clear();
        //int width = 58;
        //int height = 40;
        //for (int i = 1; i <= (width); i++)
        //{
        //    Console.SetCursorPosition(i, 0);
        //    Console.Write("─");
        //}
        //for (int i = 1; i <= (width); i++)
        //{
        //    Console.SetCursorPosition(i, (height + 1));
        //    Console.Write("─");
        //}

        //for (int i = 1; i <= (height); i++)
        //{
        //    Console.SetCursorPosition(0, i);
        //    Console.Write("│");
        //}
        //for (int i = 1; i <= (height); i++)
        //{
        //    Console.SetCursorPosition((width + 1), i);
        //    Console.Write("│");
        //}
        //Console.SetCursorPosition(0, 0);
        //Console.WriteLine("┌");
        //Console.SetCursorPosition((width + 1), 0);
        //Console.WriteLine("┐");
        //Console.SetCursorPosition(0, (height + 1));
        //Console.WriteLine("└");
        //Console.SetCursorPosition((width + 1), (height + 1));
        //Console.WriteLine("┘");
        //Console.ReadLine();

        public static void ascii_snake()
        {

            using (StringReader reader = new StringReader(@"


   ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣄⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡖⣻⠉⢿⣿⠆⠈⠙⢶⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣷⡚⠒⠊⠙⠂⠀⠀⢆⣱⡘⡷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⡟⠛⠳⣖⠒⠒⢙⡤⣿⣷⠃⢳⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠀⠀⢻⠆⠤⠤⡗⣿⢻⣼⢀⢷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⠇⠀⠸⣼⣏⡒⢲⠟⡟⣾⡾⣎⢾⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡾⠀⢸⡴⢻⠃⠀⡜⢸⣻⠴⠛⠁⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡇⣰⣰⣷⠏⠀⢰⠃⣿⣷⢳⣰⣤⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠹⣯⣿⣟⠢⢤⣇⣸⣿⡽⣧⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣶⣭⠓⠌⠉⡛⠉⣿⣼⣾⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠃⠀⠀⣰⠁⣼⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⠃⠀⠀⠐⠁⣴⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⠇⠀⠀⠀⠀⣼⠏⢰⢦⡀⠀⠀⠀⠀⠀⣀⡠⠤⠤⠤⠤⣀⡀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⠀⡀⠀⠀⣸⡟⠀⠈⢯⡓⠦⢤⡤⠴⠚⠁⠀⠀⠀⠀⠀⢘⠍⠳⡄⠀⠀⠀⠀
⠀⠀⢀⣠⠤⠖⠒⡒⠒⠢⢤⡗⢤⡉⢺⠒⣿⡃⣀⣀⣠⠽⠷⠒⠛⠉⠉⣉⣉⣛⣛⣛⣛⡉⠀⠀⣸⠀⠀⠀⠀
⢀⡴⠋⠀⠀⢠⠊⠀⠀⠀⢸⡇⢄⡈⠛⣏⣿⠉⠁⠀⢀⣠⠤⠖⠚⠉⠉⠀⠀⠀⠓⠦⣄⠉⠙⠚⠯⣄⡀⠀⠀
⡜⠀⠀⠀⠀⢸⣤⡶⠦⢤⣼⣇⠀⠈⢉⣧⢿⣧⠴⠚⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣷⠀⠀⠀⠀⠉⢦⠀
⣇⠀⠀⠀⠀⠈⠳⣄⣀⣀⣈⣿⠑⠢⠤⠼⡞⣿⡄⠀⠀⠀⠀⠀⢀⣀⣠⡤⠴⠶⠶⠒⠒⢿⡇⠀⠀⠀⠀⠸⡆
⠘⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢇⠈⠐⠂⠙⣖⠻⣤⣠⣤⡶⠞⠋⠉⠀⠀⠀⠀⠀⠀⢀⡼⠃⠀⠀⠀⠀⢸⠇
⠀⠈⠓⢦⣀⠀⠀⠀⠀⠀⠀⠀⠘⢧⡀⠀⠀⠈⠢⠀⠉⠓⠦⠤⢤⣀⣠⠤⠤⠤⠒⠚⠉⠀⠀⠀⠀⠀⣠⡟⠁
⠀⠀⠀⠀⠈⠙⠓⠲⠶⠶⠶⠶⠞⠛⠓⢄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⠟⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠒⠤⢄⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣤⠴⠞⠋⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀   ⠉⠉⠉⠉⠉⠉⠉⠉⠉

"))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        
                        Console.OutputEncoding = System.Text.Encoding.Unicode;
                        Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                        Console.WriteLine(line);
                    }
                } while (line != null);
            }

        }           //snake asci art

        public static void ascii_TextLogo()
        {
            using (StringReader reader = new StringReader(@"



  _________   ____ __  _   ___ 
 / ___|    \ /    |  |/ ] /  _]
(   \_|  _  |  o  |  ' / /  [_ 
 \__  |  |  |     |    \|    _]
 /  \ |  |  |  _  |     |   [_ 
 \    |  |  |  |  |  .  |     |
               \___|__|__|__|__|__|\_|_____|   by Rybazxs
                               


"))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                        Console.WriteLine(line);
                    }
                } while (line != null);
            }
           
            Console.SetCursorPosition(1, 44);
            Console.WriteLine("P r e s s    a n y   k e y   t o     c o n t i n u e . . . ");
        }        //snake text logo      
    }
}
