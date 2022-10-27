using System;

namespace UC2RollDiceAndGetNumber
{
    internal class UC2
    {
        //Constructor for Print Heading
        public UC2()
        {
            Console.WriteLine("Welcome To Snake and Ladder Simulator");
            Console.WriteLine("--------------------------------------");
        }
        static void Main(string[] args)
        {
            UC2 game = new UC2();       //calling the Constructor
            int startingPoint = 0;
            Random random = new Random();
            Console.WriteLine("Player Starting Point is : " + startingPoint);
            int newPoint=GetNumber(random);                 // calling the method
            startingPoint = startingPoint + newPoint;       //shifted to new point
            Console.WriteLine("Shift New Point : "+ startingPoint);
            
        }
        //Method For Get Random Number 
        public static int GetNumber(Random random)
        {
            int newPoint = random.Next(0, 7);
            Console.WriteLine(" New Point is : "+ newPoint);
            return newPoint;
        }
    }
}
