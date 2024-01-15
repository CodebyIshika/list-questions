using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Functions countObj = new Functions();
            countObj.CountOfNumbers();

            Console.WriteLine("-----------------------");
            Functions sequenceObj = new Functions();
            sequenceObj.SequenceOfValues();

            Console.WriteLine("-----------------------");
            Functions rangeObj = new Functions();
            rangeObj.GetRange();

            Console.WriteLine("-----------------------");
            Functions numberObj = new Functions();
            numberObj.TypeOfNumber();

            Console.ReadKey();

        }
    }
}
