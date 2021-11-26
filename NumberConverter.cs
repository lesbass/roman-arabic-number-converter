using System;
using System.Linq;

namespace roman_arabic_number_converter
{
    public static class NumberConverter
    {
        public static int ConvertRoman2ArabicNumber(string romanNumberAsString) =>
            romanNumberAsString
                .Select(x => Enum.TryParse<Numbers>(x.ToString(), out var arabicVal) ? (int)arabicVal : 0)
                .Reverse()
                .Aggregate((sum: 0, prev: 0), (acc, x) => (acc.sum + (x < acc.prev ? -1 : 1) * x, x))
                .sum;
    }
}