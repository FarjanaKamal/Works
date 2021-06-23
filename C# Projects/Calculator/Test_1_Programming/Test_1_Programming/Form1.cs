using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Test_1_Programming
{
    public partial class Form1 : Form
    {
        String Number1Str, Number2Str,operation;
        bool OperationFlag=false;
        int Result;
        public Form1()
        {
            InitializeComponent();
        }
        private void SetNumber(string num)
        {

            if (!OperationFlag)
            {
                Number1Str += num;
                
            }
            else
            {
                Number2Str += num;
                
            }
               
        }

        private bool SetOperation(string op)
        {

            if (string.IsNullOrEmpty(Number1Str))
                MessageBox.Show("Please Select the first number first, then select the operation");
            else if (!string.IsNullOrEmpty(Number2Str))
                MessageBox.Show("Invalid Selection, Clear current Calculation first and start over.");
            else if (OperationFlag)
            {
                txtMain.Text = txtMain.Text[0..^1];
                operation = op;
                OperationFlag = true;
                
            }
            else
            {
                operation = op;
                OperationFlag = true;
                
            }
            return OperationFlag;

        }
        private int Calculate(int Number1, int Number2)
        {
            
            switch (operation)
            {
                case "+":                  
                        Result = Number1 + Number2;
                        break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Number1 * Number2;
                    break;
                case "/":
                    Result = Number1 / Number2;
                    break;
                case "%":
                    Result = Number1 % Number2;
                    break;
                default:
                    break;
            }
            return Result;
        }
        private void total_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int.TryParse(Number1Str, out num1);
            int.TryParse(Number2Str, out num2);
            txtResult.Text = (Calculate(num1, num2).ToString());
            string history = txtMain.Text + " = " + txtResult.Text;
            History.Items.Add(history);
        }
        private void UpdateGUI(string val)
        {
            txtMain.Text += val;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Number1Str = null;
            Number2Str = null;
            operation = null;
            OperationFlag = false;
            Result=0;
            txtMain.Text = "";
            txtResult.Text = "";

        }

        private void Submit_Click(object sender, EventArgs e)
        {
           

            if (Save.Checked)
            {
                StreamWriter submission;
                saveFileDialog1.Filter = "Text File (*.txt)|*.txt|All Files|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    submission = File.CreateText(saveFileDialog1.FileName);
                    foreach (var item in History.Items)
                    {
                        submission.WriteLine(item);
                    }
                    submission.Close();
                }
                else if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    MessageBox.Show("Please Enter Save");
                else
                    MessageBox.Show("Something is wrong!!!!");
            }
            else if (Load.Checked)
            {
                StreamReader submission;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    submission = File.OpenText(openFileDialog1.FileName);
                    History.Items.Clear();
                    while (!submission.EndOfStream)
                    {
                        History.Items.Add((submission.ReadLine()).ToString());
                    }
                    submission.Close();
                }
                else if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    MessageBox.Show("Please Choose a file");
                else
                    MessageBox.Show("Something is wrong!!!!");
            }
            else
            {
                StreamWriter submission;
                submission = File.AppendText(@"C:\Test1Result\CalculationHistory.txt");
                foreach (var item in History.Items)
                {
                    submission.WriteLine(item);
                }
                submission.Close();
            }
            
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            string ArithmeticOp;
            
            ArithmeticOp= ((Button)sender).Text;
            if (SetOperation(ArithmeticOp))
                UpdateGUI(ArithmeticOp);

           // UpdateGUI(a)
            
        }

        
        private void one_Click(object sender, EventArgs e)
        {
            string InputNumber;
            InputNumber=((Button)sender).Text;
            SetNumber(InputNumber);
            UpdateGUI(InputNumber);
        }

       

        
    }
}
