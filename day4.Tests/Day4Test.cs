using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace day4.Tests

//    --- Day 4: Secure Container ---

//You arrive at the Venus fuel depot only to discover it's protected by a password. The Elves had written the password on a sticky note, but someone threw it out.

//However, they do remember a few key facts about the password:

//    It is a six-digit number.
//    The value is within the range given in your puzzle input.
//    Two adjacent digits are the same (like 22 in 122345).
//    Going from left to right, the digits never decrease; they only ever increase or stay the same(like 111123 or 135679).

//Other than the range rule, the following are true:

//    111111 meets these criteria(double 11, never decreases).
//    223450 does not meet these criteria(decreasing pair of digits 50).
//    123789 does not meet these criteria(no double).

//How many different passwords within the range given in your puzzle input meet these criteria?

//Your puzzle answer was 1650.
//--- Part Two ---

//An Elf just remembered one more important detail: the two adjacent matching digits are not part of a larger group of matching digits.

//Given this additional criterion, but still ignoring the range rule, the following are now true:

//    112233 meets these criteria because the digits never decrease and all repeated digits are exactly two digits long.
//    123444 no longer meets the criteria (the repeated 44 is part of a larger group of 444).
//    111122 meets the criteria (even though 1 is repeated more than twice, it still contains a double 22).

//How many different passwords within the range given in your puzzle input meet all of the criteria?

//Your puzzle answer was 1129.

//Both parts of this puzzle are complete! They provide two gold stars: **

//At this point, you should return to your Advent calendar and try another puzzle.

//Your puzzle input was 178416-676461.
{
    [TestClass, TestCategory("Day4")]
    public class Day4Test
    {
        [TestMethod]
        public void ValidPart1()
        {
            SecureContainer secureContainer = new SecureContainer(178416, 676461);
            Assert.IsTrue(secureContainer.validPart1(111111));
            Assert.IsFalse(secureContainer.validPart1(223450));
            Assert.IsFalse(secureContainer.validPart1(123789));
        }

        [TestMethod]
        public void SolutionPart1()
        {
            SecureContainer secureContainer = new SecureContainer(178416, 676461);
            Assert.AreEqual(1650, secureContainer.SolvePart1());
        }

        [TestMethod]
        public void ValidPart2()
        {
            SecureContainer secureContainer = new SecureContainer(178416, 676461);
            Assert.IsTrue(secureContainer.validPart2(112233));
            Assert.IsFalse(secureContainer.validPart2(123444));
            Assert.IsFalse(secureContainer.validPart2(111111));
            Assert.IsFalse(secureContainer.validPart2(223450));
            Assert.IsTrue(secureContainer.validPart2(111122));
        }

        [TestMethod]
        public void SolutionPart2()
        {
            SecureContainer secureContainer = new SecureContainer(178416, 676461);
            Assert.AreEqual(1129, secureContainer.SolvePart2());
        }
    }
}
