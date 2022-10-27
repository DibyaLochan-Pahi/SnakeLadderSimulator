using System;

namespace UC3CheckForOption
{
    internal class UC3
    {
        public UC3()
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator");
            Console.WriteLine("--------------------------------------");
        }
        static void Main(string[] args)
        {
            UC3 game=new UC3();
            int startingPoint = 0;
            int[] ladder = { 4, 15, 35, 55, 87 };
            int[] snake = { 20, 44, 67, 92 };
            Random random = new Random();
            Console.WriteLine("Player Starting Point is : " + startingPoint);
            int newPoint = GetNumber(random);                 // calling the methods
            startingPoint = startingPoint + newPoint;       //shifted to new point
            
            int jumpNumber = getOption(startingPoint, ladder, snake); //Calling Methods for check Option
            
            startingPoint=startingPoint + jumpNumber;                 // Adding New Point
            Console.WriteLine("Shift New Point : " + startingPoint);

        }
        //Method For Get Random Number 
        public static int GetNumber(Random random)
        {
            int newPoint = random.Next(1, 7);
            Console.WriteLine(" New Point is : " + newPoint);
            return newPoint;
        }
        // Method For Check Option
        public static int getOption(int startingPoint,int[] ladder, int[] snake)
        {
            int jumpNumber = 0;
            if (startingPoint == ladder[0])
            {
                Console.WriteLine("Got Ladder");
                jumpNumber = 12;
                  
            }
            else if (startingPoint == ladder[1])
            {
                Console.WriteLine("Got Ladder");
                jumpNumber = 45;
            }
            else if (startingPoint == ladder[2])
            {
                Console.WriteLine("Got Ladder");
                jumpNumber = 80;
            }
            else if (startingPoint == ladder[3])
            {
                Console.WriteLine("Got Ladder");
                jumpNumber = 95;
            }
            else if (startingPoint == ladder[1])
            {
                Console.WriteLine("Got Ladder");
                jumpNumber = 93;
            }
            else if (startingPoint == snake[0])
            {
                Console.WriteLine("Snake Bite");
                jumpNumber = 10;
            }
            else if (startingPoint == snake[1])
            {
                Console.WriteLine("Snake Bite");
                jumpNumber = 32;
            }
            else if (startingPoint == snake[2])
            {
                Console.WriteLine("Snake Bite");
                jumpNumber = 53;
            }
            else if (startingPoint == snake[3])
            {
                Console.WriteLine("Snake Bite");
                jumpNumber = 9;
            }
            
                Console.WriteLine("New Position After Option: " + jumpNumber);
                return jumpNumber;
        }
    }
    
}
