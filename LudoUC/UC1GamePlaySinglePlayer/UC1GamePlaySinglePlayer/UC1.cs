using System;

namespace UC1GamePlaySinglePlayer
{
    internal class UC1
    {
        public UC1()
        {
            Console.WriteLine("Welcome To Snake and Ladder Simulator");
            Console.WriteLine("--------------------------------------");
        }
        static void Main(string[] args)
        {
            UC1 game = new UC1();
            int startingPoint = 0;
            Console.WriteLine("Player Starting Point is : "+ startingPoint);
        }
    }
}
