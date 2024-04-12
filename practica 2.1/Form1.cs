using System;
using System.Windows.Forms;

namespace practica_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int m = int.Parse(txtM.Text);
                int n = int.Parse(txtN.Text);

                GCD gcd = new GCD();
                int result = gcd.FindGCD(m, n);

                label1.Text = $"НОД({m}, {n}) = {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Неверный формат ввода. Пожалуйста, введите целое число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
