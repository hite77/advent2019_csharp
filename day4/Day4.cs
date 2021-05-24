using System;
using System.Linq;

namespace day4
{
    public class SecureContainer
    {
        private int Start;
        private int End;

        public SecureContainer(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }

        public bool validPart1(int number)
        {
            bool containsDouble = false;
            string s = number.ToString();
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i-1]) {
                    containsDouble = true;
                }
                if (Int32.Parse(s[i].ToString()) < Int32.Parse(s[i-1].ToString()))
                {
                    return false;
                }
            }
            return containsDouble;
        }

        public int SolvePart1()
        {
            int count = 0;
            for (int i = Start; i <= End; i++)
            {
                if (validPart1(i))
                {
                    count += 1;
                }
            }
            return count;
        }

        public bool validPart2(int number)
        {
            if (!validPart1(number))
            {
                return false; 
            }
            string stringNumber = number.ToString();
            for (int i = 0; i < stringNumber.Length; i++)
            {
                if (stringNumber.Count(f => (f == stringNumber[i])) == 2)
                {
                    return true;
                }
            }
            return false;
        }

        public int SolvePart2()
        {
            int count = 0;
            for (int i = Start; i <= End; i++)
            {
                if (validPart2(i))
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
