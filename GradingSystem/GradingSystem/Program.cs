using System;
// Regular expression library for validating student names
using System.Text.RegularExpressions;
namespace GradingSystem
{
    class Program {
        static void Main()
        {
            // Variable to store the student name
            string studentName = string.Empty;
            // Variable to track if the student name is valid
            bool studentNameIsValid = false;

            // Loop until a valid student name is entered correctly
            while (!studentNameIsValid)
            {
                try
                {
                    Console.Write("Enter student name: ");
                    studentName = Console.ReadLine();

                    // Validation checking that name should not be empty
                    if (string.IsNullOrWhiteSpace(studentName))
                    {
                        throw new Exception("Student name cannot be empty.");
                    }

                    // Validation checking that only letters and spaces are allowed
                    if (!Regex.IsMatch(studentName, @"^[a-zA-Z\s]+$"))
                    {
                        throw new Exception("Student name can only contain letters and spaces.");
                    }

                    studentNameIsValid = true;   // Loop will exit if the name is valid
                }
                catch
                {
                    // If an exception is thrown, the loop will continue and prompt the user again
                    Console.WriteLine("Invalid input. Please enter a valid student name.");
                }
            }

            int markCount = 0;
            double totalMarks = 0;
            for (int i = 1; i <= 3; i++)
            {
                // Variable to track if the mark is valid
                bool markIsValid = false;

                while (!markIsValid)
                {
                    try
                    {
                        Console.Write($"Enter mark for Subject {i}: ");
                        string input = Console.ReadLine();
                        // Validation checking that the input is a valid number
                        if (!double.TryParse(input, out double marks))
                        {
                            throw new Exception("Invalid number");
                        }

                        // Checking for range
                        if (marks < 0 || marks > 100)
                        {
                            Console.WriteLine("Mark should be between 0 and 100.");
                            continue;
                        }

                        totalMarks += marks;
                        markIsValid = true;   // Loop will exit if the mark is valid
                    }
                    catch
                    {
                        Console.WriteLine("Invalid mark. Please enter a valid number, no letters or special characters.");
                        // Loop will ask again for the same subject
                    }
                }
            }
            // Displaying the results
            Console.WriteLine("\n===== Student Results ===== ");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Total marks: {totalMarks}");
            double averageMarks = totalMarks / 3.0;
            Console.WriteLine($"Average mark: {averageMarks:F2}");

            // Determining pass or fail based on average marks
            if (averageMarks >= 50)
            {
                Console.WriteLine($"Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
            Console.WriteLine($"Results Issued at: {DateTime.Now:dd MMM yyyy HH:mm:ss}");
        }
    }
}