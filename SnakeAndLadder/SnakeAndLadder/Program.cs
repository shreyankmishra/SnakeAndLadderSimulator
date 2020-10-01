using System;

namespace SnakeAndLadder
{
    class Program
    {
        public const int START_POS = 0;
        public const int END_POS = 100;
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;
        public static int rollDie()
        {
            Random random = new Random();
            int numDie = random.Next(1, 7);
            return numDie;
        }

        public static int newPos(int numOnDie)
        {
            int stepChange = 0;
            Random random = new Random();
            int option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    break;
                case SNAKE:
                    stepChange = -numOnDie;
                    break;
                case LADDER:
                    stepChange = numOnDie;
                    break;
            }
            return stepChange;
        }
        static void Main(string[] args)
        {
            int currentPos = START_POS, nextPos;
            while (currentPos < END_POS)
            {
                int numOnDie = rollDie();
                int stepsMove = newPos(numOnDie);
                nextPos = currentPos + stepsMove;
                if (nextPos < START_POS)
                    currentPos = START_POS;
                else
                    currentPos = nextPos;
            }
            Console.WriteLine("Final Position is " + currentPos);
        }
    }
    }
