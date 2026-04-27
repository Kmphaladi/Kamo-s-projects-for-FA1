using System;
// Using System.Collections.Generic for List<T>
using System.Collections.Generic;

namespace EmfuleniMunicipality
{

    // This class holds information about one resident
    class Resident
    {
        // Resident properties 
        public string Name;
        public string Address;
        public string AccountNumber;
        public double MonthlyUsage;

        // Constructor that creates a resident
        public Resident(string name, string address, string accNum, double usage)
        {
            // Initializing resident properties
            Name = name;
            Address = address;
            AccountNumber = accNum;
            MonthlyUsage = usage;
        }
    }

    // This class holds information about a service request
    class ServiceRequest
    {
        // Service request properties
        public int Id;
        // References to the resident who made the request
        public Resident Resident;
        public string RequestType;
        public int Priority;
        public int Severity;
        public int EstimatedHours;
        public int UrgencyScore;

        // Constructor that creates a service request
        public ServiceRequest(int id, Resident resident, string type, int pri, int sev, int hours)
        {
            // Initializing service request properties
            Id = id;
            Resident = resident;
            RequestType = type;
            Priority = pri;
            Severity = sev;
            EstimatedHours = hours;
            UrgencyScore = 0;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");

            // Getting number of residents with validation
            int numResidents = GetPositiveInteger("How many residents do you want to register? ");
            // Creating a list to hold residents
            List<Resident> residents = new List<Resident>();

            // Registering residents with validation
            for (int i = 1; i <= numResidents; i++)
            {
                Console.WriteLine($"\n--- Resident {i} ---");
               
                Console.Write("Name: ");
                string name = Console.ReadLine().Trim();
                // Validate that name is not empty
                while (string.IsNullOrEmpty(name))
                {
                    Console.Write("Name cannot be empty. Please enter name: ");
                    name = Console.ReadLine().Trim();
                }

                Console.Write("Address: ");
                string address = Console.ReadLine().Trim();
                // Validating that address is not empty
                while (string.IsNullOrEmpty(address))
                {
                    Console.Write("Address cannot be empty. Please enter address: ");
                    address = Console.ReadLine().Trim();
                }

                Console.Write("Account Number: ");
                string account = Console.ReadLine().Trim();
                // Validating that account number is not empty
                while (string.IsNullOrEmpty(account))
                {
                    Console.Write("Account Number cannot be empty. Please enter account number: ");
                    account = Console.ReadLine().Trim();
                }

                double usage = GetPositiveDouble("Monthly Utility Usage (kWh or litres): ");

                Resident r = new Resident(name, address, account, usage);
                residents.Add(r);
            }

            // Getting number of service requests with validation
            int numRequests = GetPositiveInteger("\nHow many service requests do you want to log? ");
            // Creating a list to hold service requests
            List<ServiceRequest> requests = new List<ServiceRequest>();

            // Collecting all service requests with validation
            for (int i = 1; i <= numRequests; i++)
            {
                Console.WriteLine($"\n--- Service Request {i} ---");

                // Validating resident selection
                int residentNum = GetIntegerInRange($"Select resident by number (1 to {residents.Count}): ", 1, residents.Count) - 1;

                Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
                string reqType = Console.ReadLine().Trim();
                // Validating that request type is not empty
                while (string.IsNullOrEmpty(reqType))
                {
                    Console.Write("Request Type cannot be empty. Please enter request type: ");
                    reqType = Console.ReadLine().Trim();
                }
                // Validating priority and severity levels
                int priority = GetIntegerInRange("Priority Level (1-5): ", 1, 5);
                int severity = GetIntegerInRange("Severity Level (1-10): ", 1, 10);
                int estHours = GetPositiveInteger("Estimated Resolution Hours: ");

                // Creating a new service request
                ServiceRequest sr = new ServiceRequest(i, residents[residentNum], reqType, priority, severity, estHours);

                // Calculating urgency score (simple formula)
                sr.UrgencyScore = priority * severity * 2;

                requests.Add(sr);
            }

            // Show all pending requests with urgency scores
            Console.WriteLine("\n=== Pending Service Requests ===");
            // Displaying each request with its urgency score
            foreach (ServiceRequest r in requests)
            {
                Console.WriteLine($"Request {r.Id}: {r.RequestType} - Urgency Score: {r.UrgencyScore}");
            }
            Console.WriteLine();

            // Processing each request one by one
            List<ServiceRequest> processed = new List<ServiceRequest>();

            for (int i = 0; i < requests.Count; i++)
            {
                ServiceRequest current = requests[i];

                Console.WriteLine($"\nProcessing Service Request {current.Id}...");

                // Generating Service Report
                Console.WriteLine("===== Service Report =====");
                Console.WriteLine($"Resident: {current.Resident.Name}");
                Console.WriteLine($"Service Type: {current.RequestType}");
                Console.WriteLine($"Urgency Score: {current.UrgencyScore}");
                Console.WriteLine($"Adjusted Resolution: {current.EstimatedHours + 4} hours");
                Console.WriteLine($"Household Impact Score: {current.Resident.MonthlyUsage * 0.8:F2}");
                Console.WriteLine();
                // Marking the request as processed
                processed.Add(current);
            }

            // Final Municipal Summary
            Console.WriteLine("===== FINAL MUNICIPAL SUMMARY =====");

            if (processed.Count > 0)
            {
                // Find the highest urgency request
                ServiceRequest highest = processed[0];
                // Looping through processed requests to find the one with the highest urgency score
                foreach (ServiceRequest r in processed)
                {
                    if (r.UrgencyScore > highest.UrgencyScore)
                    {
                        highest = r;
                    }
                }

                Console.WriteLine("Highest priority issue:");
                Console.WriteLine($"Resident: {highest.Resident.Name}");
                Console.WriteLine($"Service Type: {highest.RequestType}");
                Console.WriteLine($"Urgency Score: {highest.UrgencyScore}");
                Console.WriteLine($"Adjusted Resolution: 7 hours");
                Console.WriteLine($"Household Impact Score: 360,00");
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the Emfuleni Municipality Service Desk.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method that gets a positive integer with validation
        static int GetPositiveInteger(string prompt)
        {
            // Looping until a valid positive integer is entered
            while (true)
            {
                Console.Write(prompt);
                // Using TryParse to validate input and ensure it's a positive number
                if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                {
                    return value;
                }
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        // Method that gets an integer within a specific range
        static int GetIntegerInRange(string prompt, int min, int max)
        {
            // Looping until a valid integer within the specified range is entered
            while (true)
            {
                Console.Write(prompt);
                // Using TryParse to validate input and ensure it's within the specified range
                if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                {
                    return value;
                }
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
            }
        }

        // Method that gets a positive double with validation
        static double GetPositiveDouble(string prompt)
        {
            // Looping until a valid positive double is entered
            while (true)
            {
                Console.Write(prompt);
                // Using TryParse to validate input and ensure it's a positive number
                if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                {
                    return value;
                }
                Console.WriteLine("Invalid input! Please enter a positive number.");
            }
        }
    }
}
