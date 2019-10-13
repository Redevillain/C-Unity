using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 237;
            Console.WindowHeight = 75;
            Console.Title = "Welcome to the Matrix";            
            Console.CursorVisible = false;
            Console.WindowTop = 0;
            Console.WindowLeft = 0;
            string sa = "Welcome to the";
            string sb = " Real";
            string sc = " world";
            string sd = ", Neo";
            Console.SetCursorPosition(Console.BufferWidth/2-20, 35);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sa);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(sb);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(sc);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sd);
            Console.ReadLine();
            Console.Clear();

            int time = 1; 
            int[] stroki = new int[Console.BufferWidth];
            Random position = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {                
                int s =position.Next(0, Console.BufferWidth-4);
                while (s % 4 != 0) s++;
                stroki[s]++;
                Console.SetCursorPosition(s, stroki[s]);
                s = position.Next(32, 127);             
                Console.Write((char)s);

                if (time == 1) time = 0;
                else time = 1;
                Thread.Sleep(time);
            }
        }
    }
}
