using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeworkLesson13
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
        static class Matrix
    {
        static object locker = new object();
        private static List<string> symbolsList = new List<string>()
        {
            "d",
            "a",
            "5",
            "l",
            "j",
            "9",
            "p",
            "R",
            "1",
            "k",
            "d",
            "4",
            "d",
            "l",
            "j",
            "9",
            "d",
            "4",
            "l",
            "j",
            "p",
            "R",
            "1",
            "2",
        };

        public static void Draw()
        {
            while (true)
            {
                lock (locker)
                {

                    Random rand = new Random();
                    int randLength = rand.Next(2, 10);
                    int randTop = rand.Next(0, 30);
                    int randdWidth = rand.Next(0, 60);

                    for (int i = 0; i < randLength; i++)
                    {
                        Console.CursorLeft = randdWidth;
                        if (i == randLength - 1)
                        {
                            int randSymbol = rand.Next(0, 24);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(symbolsList[randSymbol]);
                            Console.ResetColor();
                        }
                        else if (i == randLength - 2)
                        {
                            int randSymbol = rand.Next(0, 24);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(symbolsList[randSymbol]);
                            Console.ResetColor();
                        }
                        else
                        {
                            int randSymbol = rand.Next(0, 24);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(symbolsList[randSymbol]);
                            Console.ResetColor();
                        }
                    }
                }
            }
        }
    }

}