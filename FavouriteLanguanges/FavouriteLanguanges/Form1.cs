using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FavouriteLanguanges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        // setting up the form with initial settings
        private void SetupForm()
        {
            TxtLang.PlaceholderText = "Enter programming language";

            // Show current time at start
            UpdateDateTimeDisplay();
        }

        // adding a new language to the list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = TxtLang.Text.Trim();   // Remove extra spaces

            // 1. Input validation - Prevent empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a programming language.",
                              "Input Required",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                TxtLang.Focus();
                return;
            }

            // Prevent duplicate languages (case-insensitive check) - CLEAN VERSION
            if (listLang.FindStringExact(input) != -1)
            {
                MessageBox.Show($"The language '{input}' is already in your list!",
                              "Duplicate Entry",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                TxtLang.Focus();
                TxtLang.SelectAll();
                return;
            }

            // Adding the language to the ListBox
            listLang.Items.Add(input);

            // Clearing the textbox after successful add
            TxtLang.Clear();

            // Updating the date/time display
            UpdateDateTimeDisplay($"Added '{input}'");

        }

        // Removing a selected language from the list
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Checking if user has selected an item
            if (listLang.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a language to remove.",
                              "No Selection",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            string selectedLanguage = listLang.SelectedItem.ToString();

            // Confirming before removing
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove '{selectedLanguage}'?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // If user confirms, remove the selected language
            if (result == DialogResult.Yes)
            {
                listLang.Items.RemoveAt(listLang.SelectedIndex);

                // Update the date/time display with removal info
                UpdateDateTimeDisplay($"Removed '{selectedLanguage}'");
            }
        }

        // helper method to update the date/time display
        private void UpdateDateTimeDisplay(string action = "")
        {
            string timeStamp = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

            // If no action is provided it just shows the last updated time
            if (string.IsNullOrEmpty(action))
            {
                dateTimeDisplay.Text = $"Last updated: {timeStamp}";
            }
            else
            {
                dateTimeDisplay.Text = $"{action} at {timeStamp}";
            }
        }

        // Optional: Allow pressing Enter key in textbox to add language
        private void TxtLang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();   // Trigger the Add button
            }
        }
    }
}