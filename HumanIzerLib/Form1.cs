using System;
using Humanizer;
using System.Windows.Forms;

namespace HumanIzerLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void get_plural_Click(object sender, EventArgs e)
        {
            string _data = inputText_1.Text;
                if (_data == "")
                {
                    ShowText.Text = "Grammer Error";
                }
                else
                {
                    ShowText.Text = $"Plural is {_data.Pluralize().Transform(To.TitleCase)}";
                }
            
        }

        private void get_num_word_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(inputText_2.Text);

                ShowText.Text = $"Your Answer is {number.ToWords().Transform(To.TitleCase)}";

            }
            catch (Exception)
            {
                MessageBox.Show(" Math Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_num_to_roman_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(inputText_2.Text);

                ShowText.Text = $"Your Answer is {number.ToRoman().Transform(To.TitleCase)}";

            }
            catch (Exception)
            {
                MessageBox.Show(" Math Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_all_inputs_Click(object sender, EventArgs e)
        {
            inputText_1.Text = "";
            inputText_2.Text = "";
            ShowText.Text = "";
        }
    }
}
