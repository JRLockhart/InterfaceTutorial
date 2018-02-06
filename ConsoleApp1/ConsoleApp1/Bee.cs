using System;

namespace ConsoleApp1
{
    class Bee : IStingPatrol
    {
        //if methods arn't implemented the app will throw a compile error
        int IStingPatrol.AlertLevel => throw new NotImplementedException();

        int IStingPatrol.StingerLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        bool IStingPatrol.LookForEnemies()
        {
            throw new NotImplementedException();
        }

        int IStingPatrol.SharpenStinger(int length)
        {
            throw new NotImplementedException();
        }
    }
}
