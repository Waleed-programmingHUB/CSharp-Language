
namespace HumanIzerLib
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.get_plural = new System.Windows.Forms.Button();
            this.inputText_1 = new System.Windows.Forms.TextBox();
            this.inputText_2 = new System.Windows.Forms.TextBox();
            this.get_num_word = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.get_num_to_roman = new System.Windows.Forms.Button();
            this.ShowText = new System.Windows.Forms.Label();
            this.clear_all_inputs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // get_plural
            // 
            this.get_plural.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.get_plural.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.get_plural.FlatAppearance.BorderSize = 0;
            this.get_plural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_plural.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.get_plural.ForeColor = System.Drawing.Color.Transparent;
            this.get_plural.Location = new System.Drawing.Point(9, 134);
            this.get_plural.Name = "get_plural";
            this.get_plural.Size = new System.Drawing.Size(172, 35);
            this.get_plural.TabIndex = 0;
            this.get_plural.Text = "Get Plural";
            this.get_plural.UseVisualStyleBackColor = false;
            this.get_plural.Click += new System.EventHandler(this.get_plural_Click);
            // 
            // inputText_1
            // 
            this.inputText_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.inputText_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputText_1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputText_1.ForeColor = System.Drawing.SystemColors.Menu;
            this.inputText_1.HideSelection = false;
            this.inputText_1.Location = new System.Drawing.Point(11, 94);
            this.inputText_1.MaxLength = 1000;
            this.inputText_1.Name = "inputText_1";
            this.inputText_1.Size = new System.Drawing.Size(170, 34);
            this.inputText_1.TabIndex = 2;
            this.inputText_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputText_2
            // 
            this.inputText_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.inputText_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputText_2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputText_2.ForeColor = System.Drawing.SystemColors.Menu;
            this.inputText_2.Location = new System.Drawing.Point(187, 94);
            this.inputText_2.MaxLength = 1000000000;
            this.inputText_2.Name = "inputText_2";
            this.inputText_2.Size = new System.Drawing.Size(233, 34);
            this.inputText_2.TabIndex = 3;
            this.inputText_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // get_num_word
            // 
            this.get_num_word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.get_num_word.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.get_num_word.FlatAppearance.BorderSize = 0;
            this.get_num_word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_num_word.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.get_num_word.ForeColor = System.Drawing.Color.Transparent;
            this.get_num_word.Location = new System.Drawing.Point(187, 134);
            this.get_num_word.Name = "get_num_word";
            this.get_num_word.Size = new System.Drawing.Size(155, 35);
            this.get_num_word.TabIndex = 4;
            this.get_num_word.Text = "Number to Words";
            this.get_num_word.UseVisualStyleBackColor = false;
            this.get_num_word.Click += new System.EventHandler(this.get_num_word_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a Singular Word";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(187, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter a Number";
            // 
            // get_num_to_roman
            // 
            this.get_num_to_roman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.get_num_to_roman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.get_num_to_roman.FlatAppearance.BorderSize = 0;
            this.get_num_to_roman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_num_to_roman.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.get_num_to_roman.ForeColor = System.Drawing.Color.Transparent;
            this.get_num_to_roman.Location = new System.Drawing.Point(348, 134);
            this.get_num_to_roman.Name = "get_num_to_roman";
            this.get_num_to_roman.Size = new System.Drawing.Size(161, 35);
            this.get_num_to_roman.TabIndex = 9;
            this.get_num_to_roman.Text = "Number to Roman";
            this.get_num_to_roman.UseVisualStyleBackColor = false;
            this.get_num_to_roman.Click += new System.EventHandler(this.get_num_to_roman_Click);
            // 
            // ShowText
            // 
            this.ShowText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowText.AutoSize = true;
            this.ShowText.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowText.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ShowText.Location = new System.Drawing.Point(15, 16);
            this.ShowText.Name = "ShowText";
            this.ShowText.Size = new System.Drawing.Size(0, 35);
            this.ShowText.TabIndex = 7;
            this.ShowText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clear_all_inputs
            // 
            this.clear_all_inputs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_all_inputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.clear_all_inputs.FlatAppearance.BorderSize = 0;
            this.clear_all_inputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_all_inputs.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_all_inputs.ForeColor = System.Drawing.Color.Transparent;
            this.clear_all_inputs.Location = new System.Drawing.Point(426, 94);
            this.clear_all_inputs.Name = "clear_all_inputs";
            this.clear_all_inputs.Size = new System.Drawing.Size(83, 34);
            this.clear_all_inputs.TabIndex = 10;
            this.clear_all_inputs.Text = "Clear";
            this.clear_all_inputs.UseVisualStyleBackColor = false;
            this.clear_all_inputs.Click += new System.EventHandler(this.clear_all_inputs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(521, 179);
            this.Controls.Add(this.clear_all_inputs);
            this.Controls.Add(this.get_num_to_roman);
            this.Controls.Add(this.ShowText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.get_num_word);
            this.Controls.Add(this.inputText_2);
            this.Controls.Add(this.inputText_1);
            this.Controls.Add(this.get_plural);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(387, 164);
            this.Name = "Form1";
            this.Text = "Humanizr .NET Get Plural Get Number in Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button get_plural;
        private System.Windows.Forms.TextBox inputText_1;
        private System.Windows.Forms.TextBox inputText_2;
        private System.Windows.Forms.Button get_num_word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button get_num_to_roman;
        private System.Windows.Forms.Label ShowText;
        private System.Windows.Forms.Button clear_all_inputs;
    }
}

