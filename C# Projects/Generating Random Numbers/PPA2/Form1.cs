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

namespace PPA2
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
                int min, max, TotalNumber;
                if (int.TryParse(MinimumNumber.Text, out min) && int.TryParse(MaximumNumber.Text, out max) && int.TryParse(NoOfRandom.Text, out TotalNumber))
                {
                    if (min > 0 && min < max && max < 1000 && TotalNumber > 0)
                    {
                        StreamWriter GenerateRandomFile;
                        saveFile.Filter = "Text File (*.txt)|*.txt|All Files|*.*";
                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                            GenerateRandomFile = File.CreateText(saveFile.FileName);
                            int iteration = 0;
                            while (iteration < TotalNumber)
                            {
                                int RandomNumber = GetRandomNumber();
                                if (RandomNumber >= min && RandomNumber <= max)
                                {
                                    GenerateRandomFile.WriteLine(RandomNumber);
                                    iteration++;
                                }
                            }
                            GenerateRandomFile.Close();
                        }
                        else if (saveFile.ShowDialog() == DialogResult.Cancel)
                            MessageBox.Show("Please Enter Save");
                        else
                            MessageBox.Show("Something is wrong!!!!");
                    }
                    
                    else
                        MessageBox.Show("Input numbers are not in correct range !");

                }
                else
                    MessageBox.Show("Please enter integer input !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }
        private int GetRandomNumber()
        {
            Random RandomNum = new Random();
            return RandomNum.Next(1000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader ReadGeneratedRandomFile;
                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    ReadGeneratedRandomFile = File.OpenText(openFile.FileName);
                    int readingNumber, summation=0, counting=0;
                    while (!ReadGeneratedRandomFile.EndOfStream)
                    {
                        int.TryParse(ReadGeneratedRandomFile.ReadLine(), out readingNumber);
                        lbxNumbers.Items.Add(readingNumber.ToString());
                        summation += readingNumber;
                        counting++ ;
                    }
                    lblSum.Text = summation.ToString();
                    lblCount.Text = counting.ToString();
                    ReadGeneratedRandomFile.Close();
                }
                else if (openFile.ShowDialog() == DialogResult.Cancel)
                    MessageBox.Show("  Please select a file  ");
                else
                    MessageBox.Show("Something is wrong!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }
    }
}
