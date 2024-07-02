namespace CalcForms
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            my_operator = new ComboBox();
            button_1 = new Button();
            button_2 = new Button();
            button_3 = new Button();
            button_4 = new Button();
            button_5 = new Button();
            button_6 = new Button();
            button_7 = new Button();
            button_8 = new Button();
            button_9 = new Button();
            button_10 = new Button();
            textBox_2 = new TextBox();
            textBox_1 = new TextBox();
            operator_subtraction = new Button();
            operator_addition = new Button();
            operator_division = new Button();
            operator_multiplication = new Button();
            button_Equal = new Button();
            result = new TextBox();
            fany = new Button();
            SuspendLayout();
            // 
            // my_operator
            // 
            my_operator.FormattingEnabled = true;
            my_operator.Items.AddRange(new object[] { "+", "-", "X", "/" });
            my_operator.Location = new Point(472, 147);
            my_operator.Name = "my_operator";
            my_operator.Size = new Size(125, 49);
            my_operator.TabIndex = 0;
            // 
            // button_1
            // 
            button_1.BackColor = Color.DarkOrange;
            button_1.Location = new Point(140, 289);
            button_1.MinimumSize = new Size(150, 150);
            button_1.Name = "button_1";
            button_1.Size = new Size(188, 150);
            button_1.TabIndex = 1;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button_all_Click;
            // 
            // button_2
            // 
            button_2.BackColor = Color.DarkOrange;
            button_2.Location = new Point(506, 289);
            button_2.MinimumSize = new Size(150, 150);
            button_2.Name = "button_2";
            button_2.Size = new Size(188, 150);
            button_2.TabIndex = 2;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = false;
            button_2.Click += button_all_Click;
            // 
            // button_3
            // 
            button_3.BackColor = Color.DarkOrange;
            button_3.Location = new Point(848, 289);
            button_3.MinimumSize = new Size(150, 150);
            button_3.Name = "button_3";
            button_3.Size = new Size(188, 150);
            button_3.TabIndex = 3;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = false;
            button_3.Click += button_all_Click;
            // 
            // button_4
            // 
            button_4.BackColor = Color.DarkOrange;
            button_4.Location = new Point(140, 460);
            button_4.MinimumSize = new Size(150, 150);
            button_4.Name = "button_4";
            button_4.Size = new Size(188, 150);
            button_4.TabIndex = 4;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = false;
            button_4.Click += button_all_Click;
            // 
            // button_5
            // 
            button_5.BackColor = Color.DarkOrange;
            button_5.Location = new Point(506, 460);
            button_5.MinimumSize = new Size(150, 150);
            button_5.Name = "button_5";
            button_5.Size = new Size(188, 150);
            button_5.TabIndex = 5;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = false;
            button_5.Click += button_all_Click;
            // 
            // button_6
            // 
            button_6.BackColor = Color.DarkOrange;
            button_6.Location = new Point(848, 460);
            button_6.MinimumSize = new Size(150, 150);
            button_6.Name = "button_6";
            button_6.Size = new Size(188, 150);
            button_6.TabIndex = 6;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = false;
            button_6.Click += button_all_Click;
            // 
            // button_7
            // 
            button_7.BackColor = Color.DarkOrange;
            button_7.Location = new Point(139, 641);
            button_7.MinimumSize = new Size(150, 150);
            button_7.Name = "button_7";
            button_7.Size = new Size(188, 150);
            button_7.TabIndex = 7;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = false;
            button_7.Click += button_all_Click;
            // 
            // button_8
            // 
            button_8.BackColor = Color.DarkOrange;
            button_8.Location = new Point(506, 641);
            button_8.MinimumSize = new Size(150, 150);
            button_8.Name = "button_8";
            button_8.Size = new Size(188, 150);
            button_8.TabIndex = 8;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = false;
            button_8.Click += button_all_Click;
            // 
            // button_9
            // 
            button_9.BackColor = Color.DarkOrange;
            button_9.Location = new Point(849, 641);
            button_9.MinimumSize = new Size(150, 150);
            button_9.Name = "button_9";
            button_9.Size = new Size(188, 150);
            button_9.TabIndex = 9;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = false;
            button_9.Click += button_all_Click;
            // 
            // button_10
            // 
            button_10.BackColor = Color.DarkOrange;
            button_10.Location = new Point(139, 852);
            button_10.MinimumSize = new Size(150, 150);
            button_10.Name = "button_10";
            button_10.Size = new Size(897, 150);
            button_10.TabIndex = 10;
            button_10.Text = "10";
            button_10.UseVisualStyleBackColor = false;
            button_10.Click += button_all_Click;
            // 
            // textBox_2
            // 
            textBox_2.Location = new Point(650, 149);
            textBox_2.MinimumSize = new Size(0, 80);
            textBox_2.Name = "textBox_2";
            textBox_2.Size = new Size(300, 80);
            textBox_2.TabIndex = 11;
            textBox_2.Click += textBox_2_Click;
            // 
            // textBox_1
            // 
            textBox_1.Location = new Point(140, 149);
            textBox_1.MaxLength = 100;
            textBox_1.MinimumSize = new Size(100, 100);
            textBox_1.Name = "textBox_1";
            textBox_1.Size = new Size(300, 100);
            textBox_1.TabIndex = 12;
            textBox_1.Click += textBox_1_Click;
            // 
            // operator_subtraction
            // 
            operator_subtraction.Location = new Point(1185, 289);
            operator_subtraction.MinimumSize = new Size(150, 150);
            operator_subtraction.Name = "operator_subtraction";
            operator_subtraction.Size = new Size(188, 150);
            operator_subtraction.TabIndex = 13;
            operator_subtraction.Text = "-";
            operator_subtraction.UseVisualStyleBackColor = true;
            operator_subtraction.Click += all_operators;
            // 
            // operator_addition
            // 
            operator_addition.Location = new Point(1185, 460);
            operator_addition.MinimumSize = new Size(150, 150);
            operator_addition.Name = "operator_addition";
            operator_addition.Size = new Size(188, 150);
            operator_addition.TabIndex = 14;
            operator_addition.Text = "+";
            operator_addition.UseVisualStyleBackColor = true;
            operator_addition.Click += all_operators;
            // 
            // operator_division
            // 
            operator_division.Location = new Point(1185, 641);
            operator_division.MinimumSize = new Size(150, 150);
            operator_division.Name = "operator_division";
            operator_division.Size = new Size(188, 150);
            operator_division.TabIndex = 15;
            operator_division.Text = "/";
            operator_division.UseVisualStyleBackColor = true;
            operator_division.Click += all_operators;
            // 
            // operator_multiplication
            // 
            operator_multiplication.Location = new Point(1185, 852);
            operator_multiplication.MinimumSize = new Size(150, 150);
            operator_multiplication.Name = "operator_multiplication";
            operator_multiplication.Size = new Size(188, 150);
            operator_multiplication.TabIndex = 16;
            operator_multiplication.Text = "*";
            operator_multiplication.UseVisualStyleBackColor = true;
            operator_multiplication.Click += all_operators;
            // 
            // button_Equal
            // 
            button_Equal.BackColor = Color.SeaShell;
            button_Equal.Location = new Point(1043, 149);
            button_Equal.MinimumSize = new Size(0, 80);
            button_Equal.Name = "button_Equal";
            button_Equal.Size = new Size(52, 80);
            button_Equal.TabIndex = 17;
            button_Equal.Text = "=";
            button_Equal.UseVisualStyleBackColor = false;
            button_Equal.Click += button_Equal_Click;
            // 
            // result
            // 
            result.Location = new Point(1147, 149);
            result.MinimumSize = new Size(100, 100);
            result.Name = "result";
            result.Size = new Size(226, 100);
            result.TabIndex = 18;
            // 
            // fany
            // 
            fany.Location = new Point(1513, -5);
            fany.Name = "fany";
            fany.Size = new Size(106, 106);
            fany.TabIndex = 19;
            fany.Text = "dont touch";
            fany.UseVisualStyleBackColor = true;
            fany.MouseHover += fany_MouseHover;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1615, 1149);
            Controls.Add(fany);
            Controls.Add(result);
            Controls.Add(button_Equal);
            Controls.Add(operator_multiplication);
            Controls.Add(operator_division);
            Controls.Add(operator_addition);
            Controls.Add(operator_subtraction);
            Controls.Add(textBox_1);
            Controls.Add(textBox_2);
            Controls.Add(button_10);
            Controls.Add(button_9);
            Controls.Add(button_8);
            Controls.Add(button_7);
            Controls.Add(button_6);
            Controls.Add(button_5);
            Controls.Add(button_4);
            Controls.Add(button_3);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(my_operator);
            Name = "CalculatorForm";
            Text = "c";
            Load += CalculatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox my_operator;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private Button button_4;
        private Button button_5;
        private Button button_6;
        private Button button_7;
        private Button button_8;
        private Button button_9;
        private Button button_10;
        private TextBox textBox_2;
        private TextBox textBox_1;
        private Button operator_subtraction;
        private Button operator_addition;
        private Button operator_division;
        private Button operator_multiplication;
        private Button button_Equal;
        private TextBox result;
        private Button fany;
    }
}