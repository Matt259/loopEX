using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopEX
{
    public partial class Form1 : Form
    {
        int index = 1;
        int[] userNumbers = new int[9];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = tBInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please insert a number");
            }
            else
            {
                if (index == 10)
                {
                    MessageBox.Show("You have entered the 10th number, press the other button to calculate");
                    bAdd.Enabled = false;
                }
                else 
                {
                    MessageBox.Show("You have entered the " + index + " number");
                    userNumbers[i] = int.Parse(input);
                    tBInput.Clear();
                    i++;
                }
                index++;
            }
        }
        void printAnswer(int sum)
        {

            rTBAnswers.Text = String.Format("The sum of all of those numbers is " + sum.ToString());
        }
        private void bCalculation_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < userNumbers.Length; i++)
            {
                sum = sum + userNumbers[i];
            }
            printAnswer(sum);
        }

        private void bMake_Click(object sender, EventArgs e)
        {
            string input = tBNumber.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Enter a proper number");
            }
            else
            {
                rTBAnswer2.Clear();
                int number = int.Parse(tBNumber.Text);
                int k = 0;
                int Size;
                int Asterisk = 1;
                int Spacing;
                if (Int32.TryParse(tBNumber.Text, out Size) && Size > 0)
                {
                    Spacing = Size;
                    do
                    {
                        for (int i = 1; i < Spacing; i++)
                        {
                            rTBAnswer2.AppendText(" ");
                        }
                        for (int i = 0; i < Asterisk; i++)
                        {
                            rTBAnswer2.AppendText("* ");
                        }
                        rTBAnswer2.AppendText("\n");
                        Spacing--;
                        Asterisk++;
                        k++;
                    } while (k < Size);
                }
            }
        }     
        string show(int number)
        {
            string result = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                for (int x = i; x <= number; x++)
                {
                    result += " ";                  
                }
                result += "\n";
                for (int j = 1; j <= i; j++)
                {
                    result += "*" + " ";
                    Console.Write("*" + " ");
                }
                
                Console.WriteLine();
            }
            return result;
        }
    }
}
