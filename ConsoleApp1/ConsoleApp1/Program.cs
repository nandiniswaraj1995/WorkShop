using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int stake = 100;
        public static int bet = 1;
        public static int win = 0;
        public static int loss = 0;
        public static int flag = 0;

        Random random = new Random();

        public void winOrLoss()
        {

            int check = random.Next(0, 2);
            if (check == 1)
            {
                win++;
                stake++;
                Console.WriteLine("Player Win the game");
            }
            else
            {
                loss++;
                stake--;
                Console.WriteLine("Player loss the game");

            }
        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.winOrLoss();
        }
    }
}
