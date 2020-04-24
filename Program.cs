using System;

namespace AverageTestScores
{
    class MainClass
    {
        //Average a non-specific number of scores
        //Create a console application that will accept a number test scores(as calculated by the number
        //of scores actually entered) between 0 and 100, average them, and report a letter grade for the
        //average based on the usual scale.For example, a teacher will input any number test scores, and
        //see the average numerical grade and the letter grade.
        public static void Main(string[] args)
        {
            Console.Write("Please enter each score between 0 and 100 followed by enter. ");
            Console.WriteLine("When ready press enter again to receive a total grade: ");

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
