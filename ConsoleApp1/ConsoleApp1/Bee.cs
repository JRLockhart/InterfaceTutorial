using System;

namespace ConsoleApp1
{
    class Bee : IStingPatrol
    {
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
