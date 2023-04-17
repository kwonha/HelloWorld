using System;
using System.Threading;

namespace HelloWorld
{
    internal class Program
    {
        private static readonly int SnakeStateTotal = 3;
        private const int snakeStaete1 = 0;
        private const int snakeState2 = 1;
        private const int snakeState3 = 2;
        private static readonly int snakeMoveCount = 50;
        private static readonly int SnakeRow = 5;
        private static readonly int SnakeSleepTime = 1000;

        static void Main(string[] args)
        {
            int x = 1;
            while (x <500)
            {
                Console.Clear();
                Console.SetCursorPosition(x, SnakeRow);

                switch(x%SnakeStateTotal)
                {
                    case snakeStaete1:
                        Console.WriteLine("__@");
                        break;
                    case snakeState2:
                        Console.WriteLine("_^@");
                        break;
                    case snakeState3:
                        Console.WriteLine("^_@");
                        break;

                }
                /*if(x%3 == 0)
                    Console.WriteLine("__@");
                else if (x%3 == 1)
                    Console.WriteLine("_^@"); 
                else
                    Console.WriteLine("^_@");*/
                
                Thread.Sleep(SnakeSleepTime);
                x++;

            }
        }
    }
}
