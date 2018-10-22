using System;

namespace BCS.App
{
    class Program
    {
        private static void Main(string[] args)
        {
            var numbersWithOutput = Services.GetNumbers.GetNumbersWithOutput();

            foreach (var numberWithOutput in numbersWithOutput)
            {
                Console.WriteLine(numberWithOutput.Number + " " + numberWithOutput.Output);
            }

            Console.ReadLine();
        }
    }
}
