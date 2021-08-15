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
    public partial class EmployeeADD : Form
    {        
        int value;
        public EmployeeADD()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)

        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpName.Text!="" && int.TryParse(EmpNum.Text, out value))
            {
                Form1.EmployeeName = EmpName.Text;
                Form1.EmployeeNumber = value;
                Employee Emp = new Employee();
                Emp = new Employee(Form1.EmployeeName, Form1.EmployeeNumber);
                Form1.CompanyEmployees.Add(Emp);
            }
            else
            {
                MessageBox.Show("PLEASE FILL ALL FIELDS", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
