

namespace FLIPCOIN
{
    class flip_coin
    {
        public static void Main(string[] args)
        {
            int headCount = 0;
            int tailCount = 0;

            double headpercentage = 0;
            double tailpercentage = 0;
            Console.WriteLine("enter  num of flips");
            int flipcoin = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < flipcoin; i++)
            {
                Random random = new Random();
                int num = random.Next(2);

                Console.WriteLine("e random num from system = " + num);

                if (num == 0)
                {
                    Console.WriteLine("tail");
                    tailCount = tailCount + 1;
                }
                else
                {
                    Console.WriteLine("head");
                    headCount = headCount + 1;
                }
            }

            headpercentage = (headCount * 100) / flipcoin;
            tailpercentage = (tailCount * 100) / flipcoin;

            Console.WriteLine("headpercentage = " + headpercentage);
            Console.WriteLine("tailpercentage = " + tailpercentage);
        }
    }
}