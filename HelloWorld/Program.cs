using System;
using System.Threading;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("메서드 호출");
            Thread.Sleep(1000);
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출2");
            Console.SetCursorPosition(0, 0);
            Console.Write("메서드 호출3");
        }
    }
}
