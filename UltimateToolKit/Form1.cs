using System;
using System.Windows.Forms;

namespace UltimateToolKit
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        

        

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBoxNum1.Text);
                double num2 = Convert.ToDouble(textBoxNum2.Text);
                string operation = comboBoxOperation.Text;

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Деление на ноль!");
                            return;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        MessageBox.Show("Выберите операцию!");
                        return;
                }

                labelResult.Text = "Результат: " + result;
            }
            catch
            {
                MessageBox.Show("Введите корректные числа!");
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxLength.Text, out int length) || length <= 0)
            {
                MessageBox.Show("Введите корректную длину!");
                return;
            }

            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string all = letters + numbers;

            string password = "";

            for (int i = 0; i < length; i++)
            {
                password += all[random.Next(all.Length)];
            }

            textBoxPassword.Text = password;
        }






        private void ComputerName_Click_1(object sender, EventArgs e)
        {
            ComputerName.Text = $"Привет! {Environment.MachineName}";
        }


    }
}
