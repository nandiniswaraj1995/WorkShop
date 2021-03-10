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
        public int winOrLossForADay()
        {
            int lossStake = stake / 2;
            int winStake = (stake * 3) / 2;
            bool flag = true;
            while (flag == true)
            {
                int check = random.Next(0, 2);
                if (check == 1)
                {

                    stake++;

                }
                else
                {

                    stake--;
                }
                if (stake == lossStake || stake == winStake)
                {

                    flag = false;
                }
            }

            return stake;

        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            int result = obj.winOrLossForADay();
            Console.WriteLine("Playe stake for day " + stake);
        }
    }
}
