using System;

namespace AverageTestScores
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter each score between 0 and 100 followed by enter, \n When ready press enter again to receive a total grade: ");

            string testNumbers;
            double total = 0;
            int numbers = 0;
            while ((testNumbers = Console.ReadLine()) != "")
            {
                total += double.Parse(testNumbers);
                numbers++;
            }

            Console.WriteLine("The average of the number entered is {0}", total / numbers);

            double average = total / numbers;

            if (average < 60)
            {
                Console.WriteLine("The Letter Grade is: F");
            }
            else if (60 < average && average < 70)
            {
                Console.WriteLine("The Letter Grade is: D");
            }
            else if (70 < average && average < 80)
            {
                Console.WriteLine("The Letter Grade is: C");
            }
            else if (80 < average && average < 90)
            {
                Console.WriteLine("The Letter Grade is: B");
            }
            else if (90 < average && average < 100)
            {
                Console.WriteLine("The Letter Grade is: A");
            }

        }
    }
}
