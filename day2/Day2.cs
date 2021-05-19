using System;

namespace day2
{
    public class Intcode
    {
        private int[] storage;

        public Intcode(int[] input)
        {
            storage = input;
        }

        public int process()
        {
            int currentIndex = 0;

            while(storage[currentIndex] != 99)
            {
                if ((storage[currentIndex+1] < storage.Length) &&
                    (storage[currentIndex + 2] < storage.Length) &&
                    (storage[currentIndex + 3] < storage.Length))
                {
                    switch (storage[currentIndex])
                    {
                        case 1:
                            storage[storage[currentIndex + 3]] = storage[storage[currentIndex + 1]] + storage[storage[currentIndex + 2]];
                            break;
                        case 2:
                            storage[storage[currentIndex + 3]] = storage[storage[currentIndex + 1]] * storage[storage[currentIndex + 2]];
                            break;
                    }
                }
                currentIndex += 4;
            }
            
            return storage[0];
        }

        static public void Main()
        {
            int[] data = { 1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,13,19,1,9,19,23,1,6,23,27,2,27,9,31,2,6,31,35,1,5,35,39,1,10,39,43,1,43,13,47,1,47,9,51,1,51,9,55,1,55,9,59,2,9,59,63,2,9,63,67,1,5,67,71,2,13,71,75,1,6,75,79,1,10,79,83,2,6,83,87,1,87,5,91,1,91,9,95,1,95,10,99,2,9,99,103,1,5,103,107,1,5,107,111,2,111,10,115,1,6,115,119,2,10,119,123,1,6,123,127,1,127,5,131,2,9,131,135,1,5,135,139,1,139,10,143,1,143,2,147,1,147,5,0,99,2,0,14,0 };
            data[1] = 12;
            data[2] = 2;
            Intcode intcode = new Intcode(data);

            Console.WriteLine("Answer: " + intcode.process());

            // data[1] and data[2] should go from 0-99
            // too high: 490025
            for (int noun = 0; noun <= 99; noun++)
            {
                for (int verb = 0; verb <= 99; verb++)
                {
                    int[] dataOriginal = { 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 13, 19, 1, 9, 19, 23, 1, 6, 23, 27, 2, 27, 9, 31, 2, 6, 31, 35, 1, 5, 35, 39, 1, 10, 39, 43, 1, 43, 13, 47, 1, 47, 9, 51, 1, 51, 9, 55, 1, 55, 9, 59, 2, 9, 59, 63, 2, 9, 63, 67, 1, 5, 67, 71, 2, 13, 71, 75, 1, 6, 75, 79, 1, 10, 79, 83, 2, 6, 83, 87, 1, 87, 5, 91, 1, 91, 9, 95, 1, 95, 10, 99, 2, 9, 99, 103, 1, 5, 103, 107, 1, 5, 107, 111, 2, 111, 10, 115, 1, 6, 115, 119, 2, 10, 119, 123, 1, 6, 123, 127, 1, 127, 5, 131, 2, 9, 131, 135, 1, 5, 135, 139, 1, 139, 10, 143, 1, 143, 2, 147, 1, 147, 5, 0, 99, 2, 0, 14, 0 };

                    dataOriginal[1] = noun;
                    dataOriginal[2] = verb;

                    if (new Intcode(dataOriginal).process() == 19690720)
                    {
                        Console.WriteLine("Noun: " + noun + " Verb: " + verb);
                        Console.WriteLine("Answer2: " + (100 * noun+verb));
                        return;
                    }
                }
            }
        }

        public int[] getStorage()
        {
            return storage;
        }
    }
}
