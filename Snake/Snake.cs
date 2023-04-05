using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {   
        
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();          //added new shit like key info stuff
        int[] X = new int[59];                                  //snake body thinker XD
        int[] Y = new int[39];
        int fruitX;                                             //fruit container
        int fruitY;
       
        int parts = 3;                                          //starting parts of snake 

        Random rnd = new Random();                              // define random option for further code :>

        public Snake()
        {
            X[0] = 15;
            Y[0] = 12;
            Console.CursorVisible = false;
            fruitX = rnd.Next(2, (Program.maxScreenWidth - 2));            // making fruit appears randomly only on playable board
            fruitY = rnd.Next(2, (Program.maxScreenHeight - 2));
        }

        char key = 'W';    // define basic forward key to hook up








        public void Logic()
        {
            if (X[0] == fruitX)
            {
                if (Y[0] == fruitY)
                {
                    
                    parts++;
                    fruitX = rnd.Next(2, (Program.maxScreenWidth - 2));
                    fruitY = rnd.Next(2, (Program.maxScreenHeight - 2));
                } 
            }
            for (int i = parts; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];
            }
            switch (key)
            {
                case 'w':
                    Y[0]--;
                    break;
                case 's':
                    Y[0]++;
                    break;
                case 'd':
                    X[0]++;
                    break;
                case 'a':
                    X[0]--;
                    break;
            }
            for (int i = 0; i <= (parts - 1); i++)
            {
                WritePoint(X[i], Y[i]);
                WritePoint(fruitX, fruitY);
            }
            Thread.Sleep(10);




        }
        public void Controll()
        {
            if (Console.KeyAvailable)                            // checking pushed buttons
            { 
                keyInfo = Console.ReadKey(true);                 // czyta jaki klawisz jest wcisniety // checking keyboard
                key = keyInfo.KeyChar;                           //changing input into char crap and put it into key value
            }
           
        }
        public void WritePoint (int x, int y)                     //Snake single body part
        {
            Console.SetCursorPosition(x, y);                      //sets cursor in position XD
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("▇");
        }
        
        
    }
}
