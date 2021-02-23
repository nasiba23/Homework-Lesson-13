using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HomeworkLesson13
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Task> taskList = new List<Task>();

            for (int i = 0; i < 100; i++)
            {
                taskList.Add(Task.Run(() => Matrix.Draw()));
            }
            await Task.WhenAll(taskList);
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

    static class Examples
    {
        static int Multithreading()
        {
            var result = 0;
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    result += i;
                }
            });
            return result;
        }

        static async Task<int> Asynchronous()
        {
            var result = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    result += i;
                }
            });
            return result;
        }

        static int ParallelMethod()
        {
            var result = 0;
            Parallel.For(1, 100, (i, pr) => result += i);
            return result;
        }
    }
        

}