using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAffairs
{
    public class CitizenProfile
    {
        // Properties for Citizen Profile
        public string FullName;
        public string IDNumber;
        public int Age;
        public string CitizenshipStatus;

        public CitizenProfile(string fullName, string idNumber, string citizenship)
        {
            // Trim inputs to remove leading whitespace
            FullName = fullName.Trim();
            IDNumber = idNumber.Trim();
            CitizenshipStatus = citizenship;
            Age = CalculateAge(IDNumber);
        }

        private int CalculateAge(string idNumber)
        {
            // The first 6 digits of the ID number that represent the date of birth in YYMMDD format
            if (string.IsNullOrEmpty(idNumber) || idNumber.Length < 6)
                return -1;

            string birthPart = idNumber.Substring(0, 6);

            // Validate that the birthPart is numeric
            if (!int.TryParse(birthPart, out int birthDate))
                return -1;

            // Formulas to calculate age from the birth date
            int year = birthDate / 10000;
            int month = (birthDate / 100) % 100;
            int day = birthDate % 100;
            // Adjusting the year to a full year
            int fullYear = (year <= 20) ? 2000 + year : 1900 + year;

            try
            {
                // Creating a DateTime object for the birth date
                DateTime birthDateTime = new DateTime(fullYear, month, day);
                int age = DateTime.Today.Year - birthDateTime.Year;
                // Adjusting age if the birthday hasn't happened yet this year
                if (DateTime.Today < birthDateTime.AddYears(age))
                    age--;
                return age;
            }
            catch
            {
                // If the date is invalid, return -1 to indicate an error
                return -1;
            }
        }

        public string ValidateID()
        {
            // Validate the ID number and return a message indicating whether it's valid or not
            if (string.IsNullOrWhiteSpace(IDNumber))
                return "Error: Please enter ID Number.";
            // Checking if the ID number is exactly 13 digits long
            if (IDNumber.Length != 13)
                return "Error: ID Number must be exactly 13 digits.";
            // Checking if the ID number contains only numeric characters
            if (!long.TryParse(IDNumber, out _))
                return "Error: ID Number must contain only numbers (0-9).";
            // Checking if the date of birth extracted from the ID number is valid
            if (Age < 0 || Age > 120)
                return "Error: Invalid date of birth in ID number.";

            return $"Valid ID. Citizen is {Age} years old.";
        }

        public string GenerateProfileSummary()
        {
            string validation = ValidateID();
            // Display the citizen's profile summary and a timestamp
            return "===== DIGITAL CITIZEN SUMMARY =====\n\n" +
                   $"Name: {FullName}\n" +
                   $"ID Number: {IDNumber}\n" +
                   $"Age: {Age}\n" +
                   $"Citizenship: {CitizenshipStatus}\n" +
                   $"Validation: {validation}\n" +
                   $"Processed at: Home Affairs Digital Desk\n" +
                   $"Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm}";
        }
    }
}
