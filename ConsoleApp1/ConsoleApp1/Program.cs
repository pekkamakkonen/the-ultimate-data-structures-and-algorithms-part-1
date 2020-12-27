using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Array numbers = new Array(3);
            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Insert(40);
            numbers.RemoveAt(4);
            numbers.Print();
            Console.ReadKey();
        }
    }
}
