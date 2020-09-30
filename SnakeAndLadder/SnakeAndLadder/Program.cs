using System;

namespace SnakeAndLadder
{
    class Program
    {
        public const int START_POS = 0;
        public static int rollDie()
        {
            Random random = new Random();
            int numDie = random.Next(1, 7);
            return numDie;
        }
        static void Main(string[] args)
        {
            int currentPos = START_POS;
            int numberDie = rollDie();
        }
    }
}
