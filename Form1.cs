namespace SimpleCalculator
{
    public partial class Form1 : Form
    {

        int num1 = 0, num2 = 0, result = 0;
        string sign = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void but_0_Click(object sender, EventArgs e)
        {
            if (result_txt.Text != "0")
            {
                result_txt.Text += "0";
                process_txt.Text += "0";
            }
        }

        private void but_1_Click(object sender, EventArgs e)
        {
            if (result_txt.Text == "0") result_txt.Text = "1";
            else result_txt.Text += "1";

            if (process_txt.Text == "0") process_txt.Text = "1";
            else process_txt.Text += "1";
        }

        private void but_2_Click(object sender, EventArgs e)
        {
            if (result_txt.Text == "0") result_txt.Text = "2";
            else result_txt.Text += "2";

            if (process_txt.Text == "0") process_txt.Text = "2";
            else process_txt.Text += "2";
        }

        private void but_3_Click(object sender, EventArgs e)
        {
            if (result_txt.Text == "0") result_txt.Text = "3";
            else result_txt.Text += "3";

            if (process_txt.Text == "0") process_txt.Text = "3";
            else process_txt.Text += "3";
        }

        private void but_4_Click(object sender, EventArgs e)
        {
            if (result_txt.Text == "0") result_txt.Text = "4";
            else result_txt.Text += "4";

            if (process_txt.Text == "0") process_txt.Text = "4";
            else process_txt.Text += "4";
        }

        private void but_5_Click(object sender, EventArgs e)
        {
            if (result_txt.Text == "0") result_txt.Text = "5";
            else result_txt.Text += "5";

            if (process_txt.Text == "0") process_txt.Text = "5";
            else process_txt.Text += "5";
        }

        private void but_6_Click(object sender, EventArgs e)
        {
            if (result_txt.Text == "0") result_txt.Text = "6";
            else result_txt.Text += "6";

            if (process_txt.Text == "0") process_txt.Text = "6";
            else process_txt.Text += "6";
        }

        private void but_7_Click(object sender, EventArgs e)
        {
            if (result_txt.Text == "0") result_txt.Text = "7";
            else result_txt.Text += "7";

            if (process_txt.Text == "0") process_txt.Text = "7";
            else process_txt.Text += "7";
        }

        private void but_8_Click(object sender, EventArgs e)
        {
            if (result_txt.Text == "0") result_txt.Text = "8";
            else result_txt.Text += "8";

            if (process_txt.Text == "0") process_txt.Text = "8";
            else process_txt.Text += "8";
        }

        private void but_9_Click(object sender, EventArgs e)
        {
            if (result_txt.Text == "0") result_txt.Text = "9";
            else result_txt.Text += "9";

            if (process_txt.Text == "0") process_txt.Text = "9";
            else process_txt.Text += "9";
        }

        private void but_pl_Click(object sender, EventArgs e)
        {
            sign = "+";
            num1 = int.Parse(result_txt.Text);
            result_txt.Text = "0";
            process_txt.Text += " + ";
        }

        private void but_eq_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(result_txt.Text);
            if(num2 == 0)
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
            result_txt.Text = "0";
            process_txt.Text += " - ";
        }

        private void but_mul_Click(object sender, EventArgs e)
        {
            sign = "¡¿";
            num1 = int.Parse(result_txt.Text);
            result_txt.Text = "0";
            process_txt.Text += " ¡¿ ";
        }

        private void but_div_Click(object sender, EventArgs e)
        {
            sign = "¡À";
            num1 = int.Parse(result_txt.Text);
            result_txt.Text = "0";
            process_txt.Text += " ¡À ";
        }
    }
}
