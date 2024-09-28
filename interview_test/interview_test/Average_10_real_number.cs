using System;
using System.Collections.Generic;
using System.Linq;

class  Average_10_real_number
{
    static void Main()
    {
        List<double> positives = new List<double>();
        List<double> negatives = new List<double>();

        Console.WriteLine("Please enter 10 real numbers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            double number;

            // Validate input and ensure a valid number is entered
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter a valid real number: ");
            }

            // Separate numbers into positives and negatives
            if (number > 0)
            {
                positives.Add(number);
            }
            else if (number < 0)
            {
                negatives.Add(number);
            }
        }

        // Calculate averages
        double avgPositives = positives.Count > 0 ? positives.Average() : 0;
        double avgNegatives = negatives.Count > 0 ? negatives.Average() : 0;

        // Display the results
        Console.WriteLine($"\nAverage of positive numbers: {(positives.Count > 0 ? avgPositives.ToString("F2") : "No positive numbers")}");
        Console.WriteLine($"Average of negative numbers: {(negatives.Count > 0 ? avgNegatives.ToString("F2") : "No negative numbers")}");
    }
}
