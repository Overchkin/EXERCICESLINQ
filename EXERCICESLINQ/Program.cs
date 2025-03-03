using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXERCICESLINQ;

namespace EXERCICESLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            System.Console.WriteLine(tab.CompterPair());
        }
    }
}
