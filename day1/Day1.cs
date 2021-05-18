using System;

namespace day1
{
    public class Mass
    {
        private int sum = 0;
    
        static void Main()
        {
            Mass mass = new Mass();

            string[] lines = System.IO.File.ReadAllLines(@"day1/data.txt");

            int sum = 0;

            foreach (string line in lines)
            {
                sum = mass.round(Int32.Parse(line));
            }

            Console.WriteLine("Answer: " + sum);
        }
        public int round(int number)
        {
            double divide = number / 3;
            sum += (int)(Math.Round(divide) - 2);
            return sum;
        }
    }
}