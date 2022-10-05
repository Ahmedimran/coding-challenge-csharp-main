using System;
using System.Linq;

/*
 
    *
   ***
  *****
 *******
*********

ACCEPTANCE CRITERIA:
Write a script to output this pyramid on console (with leading spaces)

*/
namespace Pyramid
{
    public class Program
    {
        private static void Pyramid(int height)
        {
             var width = (height * 2) - 1;
            foreach (var i in Enumerable.Range(0, height))
            {
                var padding = height - i - 1;
                string row = new string('*', width - padding * 2);
                row = row.PadLeft(padding+row.Length, ' ');
                row = row.PadRight(padding+row.Length, ' ');
                Console.WriteLine(row);
            }
        }
        
        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}
