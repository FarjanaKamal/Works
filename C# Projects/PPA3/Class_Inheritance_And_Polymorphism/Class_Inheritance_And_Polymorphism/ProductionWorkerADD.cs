using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Inheritance_And_Polymorphism
{
    public partial class ProductionWorkerADD : Form
    {
        int value1;
        double value2;
        public ProductionWorkerADD()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(SHIFT_TYPE));
        }

        private void Btn_Add_ProductionWorker_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" &&int.TryParse(textBox2.Text, out value1) && comboBox1.SelectedIndex > -1 && double.TryParse(textBox4.Text, out value2))
            {
                Form1.EmployeeName = textBox1.Text;
                Form1.EmployeeNumber = value1;
                Form1.ShiftIndex = comboBox1.SelectedIndex + 1;
                Form1.WorkerPayRate = value2;
                ProductionWorker Emp = new ProductionWorker();
                Emp = new ProductionWorker(Form1.EmployeeName, Form1.EmployeeNumber, Form1.ShiftIndex, Form1.WorkerPayRate);
                Form1.CompanyEmployees.Add(Emp); // a production worker is also an employee
                Form1.CompanyEmployeesASProductionWorker.Add(Emp);
            }
            else
            {
                MessageBox.Show("PLEASE FILL ALL FIELDS", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
