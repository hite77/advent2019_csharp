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
            int sum_with_fuel = 0;

            foreach (string line in lines)
            {
                sum = mass.round(Int32.Parse(line));
                sum_with_fuel += mass.round_with_fuel(Int32.Parse(line));
            }

            Console.WriteLine("Answer: " + sum);
            Console.WriteLine("Answer day2: " + sum_with_fuel);
        }
        public int round(int number)
        {
            double divide = number / 3;
            sum += (int)(Math.Round(divide) - 2);
            return sum;
        }

        public int round_with_fuel(int number)
        {
            double divide = number / 3;
            int current_value = (int)(Math.Round(divide) - 2);
            if (current_value > 0)
            {
                int adder = round_with_fuel(current_value);
                if (adder > 0)
                {
                    current_value += adder;
                }
                
            }
            return current_value;
        }
    }
}