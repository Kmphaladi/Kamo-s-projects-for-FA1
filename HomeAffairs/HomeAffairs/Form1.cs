using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAffairs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Loads citizenship options into the dropdown
            LoadCitizenshipOptions();
        }

        private void LoadCitizenshipOptions()
        {
            // Populates the CitizenshipStatus ComboBox with options
            CitizenshipStatus.Items.AddRange(new string[]
            {
                "Citizen",
                "Permanent Resident",
                "Visitor"
            });
            CitizenshipStatus.SelectedIndex = 0;
        }

        // Method that creates a CitizenProfile object from form inputs
        private CitizenProfile CreateProfile()
        {
            // Validating inputs before creating the profile
            if (string.IsNullOrWhiteSpace(FullName.Text))
                throw new Exception("Name is required. Please enter your full name.");
            // Validates that the name contains only letters and spaces
            if (!IsValidName(FullName.Text))
                throw new Exception("Name can only contain letters and spaces. No numbers or special characters allowed.");
            // Validates that the ID number is not empty
            if (string.IsNullOrWhiteSpace(IDNumber.Text))
                throw new Exception("ID Number is required.");
            
            return new CitizenProfile(
                FullName.Text,
                IDNumber.Text,
                CitizenshipStatus.SelectedItem.ToString()
            );
        }

        // Method that checks if name contains only letters and spaces
        private bool IsValidName(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        // ID CHECKER Button
        private void btnIDChecker_Click(object sender, EventArgs e)
        {
            try
            {
                CitizenProfile profile = CreateProfile();

                string result = profile.ValidateID();
                // Display the result in the Age TextBox and change color based on validity
                Age.Text = result;
                Age.ForeColor = result.StartsWith("Valid") ? Color.Green : Color.Red;
            }
            catch (Exception ex)
            {
                // Show a message box with the error and update the Age TextBox with the error message
                MessageBox.Show(ex.Message, "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Age.Text = "Error: " + ex.Message;
                Age.ForeColor = Color.Red;
            }
        }

        // PROFILE GENERATOR Button
        private void btnGenProfile_Click(object sender, EventArgs e)
        {
            try
            {
                CitizenProfile profile = CreateProfile();

                Summary.Text = profile.GenerateProfileSummary();

                string validation = profile.ValidateID();
                Age.Text = validation;
                // Change the color of the Age TextBox based on the validation result
                Age.ForeColor = validation.StartsWith("Valid") ? Color.Green : Color.Red;
            }
            catch (Exception ex)
            {
                // Show a message box with the error and update the Summary TextBox with the error message
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
