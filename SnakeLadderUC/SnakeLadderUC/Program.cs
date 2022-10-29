using System;

namespace SnakeLadderUC
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("Welcome To Ladder and Snake simulator");
            Console.WriteLine("----------------------------------------");
        }
        public static void Main(string[] args)
        {
            Program game = new Program ();

            int[] ladder = { 4, 15, 35, 55, 87 };
            int[] snake = { 20, 44, 67, 92 };
            int startingPoint = 0;
            string p1 = "Player1";
            Console.WriteLine("Player Starting Point is : " + startingPoint);
            // calling the gamePlay methods
            int reachposition = gamePlay(p1, startingPoint, ladder, snake);
            Console.WriteLine("Finally " + p1 + " Reached Position : " + reachposition);          
        }
        //Method For Get Random Number 
        public static int GetNumber(Random random)
        {
            int newPoint = random.Next(1, 7);
            Console.WriteLine("New Random Rolling Point is : -->" + newPoint);
            return newPoint;
        }
        public static int gamePlay(string player, int playerPosition, int[] ladder, int[] snake)
        {
            int winningPosition = 100;
            Random random = new Random();
            while (winningPosition > playerPosition)
            {
                int newPoint = GetNumber(random);
                playerPosition = playerPosition + newPoint;       //shifted to new point

                int jumpNumber = getOption(playerPosition, ladder, snake); //Calling Methods for check Option
                playerPosition = jumpNumber;                 // Adding New Point
                Console.WriteLine(player + " Shift to New Point : " + playerPosition);
                // In case the player position moves below zero
                // then the player restart from zero
                if (playerPosition < 0)
                {
                    Console.WriteLine(player + " Point is below Zero so Restart from Zero ");
                    playerPosition = 0;
                }
                Console.WriteLine();
                Console.WriteLine();
            }        
            return playerPosition;
        }
        // Method For Check Option
        public static int getOption(int startingPoint, int[] ladder, int[] snake)
        {
            int jumpNumber = 0;
            if (startingPoint == ladder[0])
            {
                Console.WriteLine("Got Ladder");
                jumpNumber = 12;
                Console.WriteLine("New Position After Ladder: " + jumpNumber);
            }
            else if (startingPoint == ladder[1])
            {
                Console.WriteLine("Got Ladder");
                jumpNumber = 45;
                Console.WriteLine("New Position After Ladder: " + jumpNumber);
            }
            else if (startingPoint == ladder[2])
            {
                Console.WriteLine("Got Ladder");
                jumpNumber = 80;
                Console.WriteLine("New Position After Ladder: " + jumpNumber);
            }
            else if (startingPoint == ladder[3])
            {
                Console.WriteLine("Got Ladder");
                jumpNumber = 95;
                Console.WriteLine("New Position After Ladder: " + jumpNumber);
            }
            else if (startingPoint == ladder[1])
            {
                Console.WriteLine("Got Ladder");
                jumpNumber = 93;
                Console.WriteLine("New Position After Ladder: " + jumpNumber);
            }
            else if (startingPoint == snake[0])
            {
                Console.WriteLine("Snake Bite");
                jumpNumber = 10;
                Console.WriteLine("New Position After Snake Bite: " + jumpNumber);
            }
            else if (startingPoint == snake[1])
            {
                Console.WriteLine("Snake Bite");
                jumpNumber = 32;
                Console.WriteLine("New Position After Snake Bite: " + jumpNumber);
            }
            else if (startingPoint == snake[2])
            {
                Console.WriteLine("Snake Bite");
                jumpNumber = 53;
                Console.WriteLine("New Position After Snake Bite: " + jumpNumber);
            }
            else if (startingPoint == snake[3])
            {
                Console.WriteLine("Snake Bite");
                jumpNumber = 9;
                Console.WriteLine("New Position After Snake Bite: " + jumpNumber);
            }           
            if (jumpNumber != 0)
            {
                return jumpNumber;
            }
            return startingPoint;


        }
    }
}

