namespace SimpleCalculator
{
    public partial class Form1 : Form
    {

        int num1 = 0, num2 = 0, result = 0;
        string sign = "";
        bool isOperatorClicked = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.D0: case Keys.NumPad0: but_0.PerformClick(); return true;
                case Keys.D1: case Keys.NumPad1: but_1.PerformClick(); return true;
                case Keys.D2: case Keys.NumPad2: but_2.PerformClick(); return true;
                case Keys.D3: case Keys.NumPad3: but_3.PerformClick(); return true;
                case Keys.D4: case Keys.NumPad4: but_4.PerformClick(); return true;
                case Keys.D5: case Keys.NumPad5: but_5.PerformClick(); return true;
                case Keys.D6: case Keys.NumPad6: but_6.PerformClick(); return true;
                case Keys.D7: case Keys.NumPad7: but_7.PerformClick(); return true;
                case Keys.D8: case Keys.NumPad8: but_8.PerformClick(); return true;
                case Keys.D9: case Keys.NumPad9: but_9.PerformClick(); return true;

                case Keys.Add: but_pl.PerformClick(); return true;
                case Keys.Subtract: but_mi.PerformClick(); return true;
                case Keys.Multiply: but_mul.PerformClick(); return true;
                case Keys.Divide: but_div.PerformClick(); return true;
                case Keys.Enter: but_eq.PerformClick(); return true;
                case Keys.Back: Del_but.PerformClick(); return true;
                case Keys.Escape: C_but.PerformClick(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void but_0_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                result_txt.Clear();
                isOperatorClicked = false;
            }

            {
                if (result_txt.Text == "0") result_txt.Text = "0";
                else result_txt.Text += "0";
                if (process_txt.Text == "0") process_txt.Text = "0";
                else process_txt.Text += "0";
            }
            if (result_txt.Text != "0")
            {
                result_txt.Text += "0";
                process_txt.Text += "0";
            }
        }

        private void but_1_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                result_txt.Clear();
                isOperatorClicked = false;
            }

            if (result_txt.Text == "0") result_txt.Text = "1";
            else result_txt.Text += "1";

            if (process_txt.Text == "0") process_txt.Text = "1";
            else process_txt.Text += "1";
        }

        private void but_2_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                result_txt.Clear();
                isOperatorClicked = false;
            }

            if (result_txt.Text == "0") result_txt.Text = "2";
            else result_txt.Text += "2";

            if (process_txt.Text == "0") process_txt.Text = "2";
            else process_txt.Text += "2";
        }

        private void but_3_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                result_txt.Clear();
                isOperatorClicked = false;
            }

            if (result_txt.Text == "0") result_txt.Text = "3";
            else result_txt.Text += "3";

            if (process_txt.Text == "0") process_txt.Text = "3";
            else process_txt.Text += "3";
        }

        private void but_4_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                result_txt.Clear();
                isOperatorClicked = false;
            }

            if (result_txt.Text == "0") result_txt.Text = "4";
            else result_txt.Text += "4";

            if (process_txt.Text == "0") process_txt.Text = "4";
            else process_txt.Text += "4";
        }

        private void but_5_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                result_txt.Clear();
                isOperatorClicked = false;
            }

            if (result_txt.Text == "0") result_txt.Text = "5";
            else result_txt.Text += "5";

            if (process_txt.Text == "0") process_txt.Text = "5";
            else process_txt.Text += "5";
        }

        private void but_6_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                result_txt.Clear();
                isOperatorClicked = false;
            }

            if (result_txt.Text == "0") result_txt.Text = "6";
            else result_txt.Text += "6";

            if (process_txt.Text == "0") process_txt.Text = "6";
            else process_txt.Text += "6";
        }

        private void but_7_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                result_txt.Clear();
                isOperatorClicked = false;
            }

            if (result_txt.Text == "0") result_txt.Text = "7";
            else result_txt.Text += "7";

            if (process_txt.Text == "0") process_txt.Text = "7";
            else process_txt.Text += "7";
        }

        private void but_8_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                result_txt.Clear();
                isOperatorClicked = false;
            }

            if (result_txt.Text == "0") result_txt.Text = "8";
            else result_txt.Text += "8";

            if (process_txt.Text == "0") process_txt.Text = "8";
            else process_txt.Text += "8";
        }

        private void but_9_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                result_txt.Clear();
                isOperatorClicked = false;
            }

            if (result_txt.Text == "0") result_txt.Text = "9";
            else result_txt.Text += "9";

            if (process_txt.Text == "0") process_txt.Text = "9";
            else process_txt.Text += "9";
        }

        private void but_pl_Click(object sender, EventArgs e)
        {
            sign = "+";
            num1 = int.Parse(result_txt.Text);
            process_txt.Text += " + ";
            isOperatorClicked = true;
        }

        private void but_eq_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(result_txt.Text);
            if (num2 == 0)
            {
                process_txt.Text += "0";
            }
            result_txt.Clear();
            process_txt.Text += " = ";
            if (sign == "+")
            {
                result = num1 + num2;
                process_txt.Text += result.ToString();
                result_txt.Text += result.ToString();
            }
            else if (sign == "-")
            {
                result = num1 - num2;
                process_txt.Text += result.ToString();
                result_txt.Text += result.ToString();
            }
            else if (sign == "¡¿")
            {
                result = num1 * num2;
                process_txt.Text += result.ToString();
                result_txt.Text += result.ToString();
            }
            else if (sign == "¡À")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    process_txt.Text += result.ToString();
                    result_txt.Text += result.ToString();
                }
                else
                {
                    process_txt.Text += "Error: Division by zero";
                    result_txt.Text = "Error";
                }
            }
        }

        private void but_mi_Click(object sender, EventArgs e)
        {
            sign = "-";
            num1 = int.Parse(result_txt.Text);
            isOperatorClicked = true;
            process_txt.Text += " - ";
        }

        private void but_mul_Click(object sender, EventArgs e)
        {
            sign = "¡¿";
            num1 = int.Parse(result_txt.Text);
            isOperatorClicked = true;
            process_txt.Text += " ¡¿ ";
        }

        private void but_div_Click(object sender, EventArgs e)
        {
            sign = "¡À";
            num1 = int.Parse(result_txt.Text);
            isOperatorClicked = true;
            process_txt.Text += " ¡À ";
        }

        private void CE_but_Click(object sender, EventArgs e)
        {
            result_txt.Text = "0";

            if (!string.IsNullOrEmpty(process_txt.Text))
            {
                int lastSpaceIndex = process_txt.Text.LastIndexOf(' ');

                if (lastSpaceIndex != -1)
                {
                    process_txt.Text = process_txt.Text.Substring(0, lastSpaceIndex + 1);
                }
                else
                {
                    process_txt.Text = "";
                }
            }
        }

        private void C_but_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            result = 0;
            sign = "";

            result_txt.Text = "0";
            process_txt.Text = "";
        }

        private void Del_but_Click(object sender, EventArgs e)
        {
            if (result_txt.Text.Length > 0)
            {
                result_txt.Text = result_txt.Text.Substring(0, result_txt.Text.Length - 1);

                if (process_txt.Text.Length > 0)
                {
                    process_txt.Text = process_txt.Text.Substring(0, process_txt.Text.Length - 1);
                }
            }

            if (result_txt.Text == "" || result_txt.Text == "Error")
            {
                result_txt.Text = "0";
            }
        }
    }
}