using System;
using Humanizer; // Using a NUGet Lib
using System.Windows.Forms;
/*
*   
*   Windows Desktop Application Source Code
*   Author : Waleed Ali Sarwar
*   @2021 Source-Code
*   In C# .NET Core 3.1 LTS
*   
*   Simple Desktop App For Windows x64
*   Relates to English & Math
*   
*/
// NameSpace
namespace HumanIzerLib
{
    public partial class Form1 : Form
    {
        // Form
        public Form1()
        {
            InitializeComponent();
        }
        // Button Get Plural 
        private void get_plural_Click(object sender, EventArgs e)
        {
            // Set the data of TextBox
            string _data = inputText_1.Text;
            // If user click button without TextBox Fill the will be action
                if (_data == "")
                {
                    ShowText.Text = "Grammer Error";
                }
                else
                {
                    ShowText.Text = $"Plural is {_data.Pluralize().Transform(To.TitleCase)}";
                }
            
        }
        // Button Get Number to Counting in words
        // Function
        private void get_num_word_Click(object sender, EventArgs e)
        {
            // Try Catch Exception
            try
            {
                // Taking User Input Number
                int number = Convert.ToInt32(inputText_2.Text); // Converting int to Input String
                // Answer Message Shows
                ShowText.Text = $"Your Answer is {number.ToWords().Transform(To.TitleCase)}";

            }
            catch (Exception)
            {
                // Show the Error to Client / User
                MessageBox.Show(" Math Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Button Get Simple Number Converting to Roman number
        // Function
        private void get_num_to_roman_Click(object sender, EventArgs e)
        {
            // Try Catch Exception Handler
            try
            {
                // Taking User input number 
                int number = Convert.ToInt32(inputText_2.Text);
                // Number to Roman Number
                ShowText.Text = $"Your Answer is {number.ToRoman().Transform(To.TitleCase)}";

            }
            catch (Exception)
            {
                // Error Message Show Dialog
                MessageBox.Show(" Math Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Clear the Inputs and ShowText Label Output 
        private void clear_all_inputs_Click(object sender, EventArgs e)
        {
            inputText_1.Text = ""; // TextBox - 1 for Get Singular 
            inputText_2.Text = "";// TextBox - 2 // Get Number to Words / Get Number to Roman
            ShowText.Text = ""; // Clear the Label OutPut Label
        }
    }
}
