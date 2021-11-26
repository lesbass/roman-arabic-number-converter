using NUnit.Framework;

namespace roman_arabic_number_converter
{
    [TestFixture]
    public class NumberConverterTests
    {
        [Test]
        [TestCase("III", 3)]
        [TestCase("VI", 6)]
        [TestCase("XIV", 14)]
        [TestCase("XVI", 16)]
        [TestCase("XII", 12)]
        [TestCase("XIX", 19)]
        [TestCase("XL", 40)]
        [TestCase("LXXII", 72)]
        public void ConvertRoman2ArabicNumber(string romanNumber, int arabicNumber)
        {
            var result = NumberConverter.ConvertRoman2ArabicNumber(romanNumber);
            Assert.AreEqual(arabicNumber, result);
        }
    }
}