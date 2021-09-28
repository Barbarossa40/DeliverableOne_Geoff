using System;

namespace DeliverableOne_Geoff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guten Tag! ");

            Console.WriteLine();

            string answer;
            do
            {
                Console.Write("Enter Unit of Measurment: ");
                string unit = Console.ReadLine();

                Console.Write("Enter Amount: ");
                double amount = double.Parse(Console.ReadLine());

                if (unit == "fidget spinner")
                {
                    Console.WriteLine(amount / 3.50 + " inch");
                }
                else if (unit == "inch")
                {
                    Console.WriteLine(amount * 3.50 + " fidget spinner");
                }
                else if (unit == "meme")
                {
                    Console.WriteLine(amount / 5 + " foot");
                }
                else if (unit == "foot")
                {
                    Console.WriteLine(amount * 5 + " meme");
                }
                Console.Write("Answer Yes if you wish to do another conversation ");
                answer = (Console.ReadLine());
                answer = answer.ToLower();

            } while(answer == "yes");


        }
    }
}
