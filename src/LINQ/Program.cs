using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {2, 4, 7, 12, 6};
            List<int> squares = new List<int> {4, 16, 49, 144, 36};

            System.Console.WriteLine(TestForSquares(numbers, squares));
        }

        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            return true;
        }
    }
}