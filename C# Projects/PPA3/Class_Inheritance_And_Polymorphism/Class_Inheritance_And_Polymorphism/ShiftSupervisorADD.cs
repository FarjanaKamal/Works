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
    public partial class ShiftSupervisorADD : Form
    {
        int value1;
        double value2,value3;
        

        public ShiftSupervisorADD()
        {
            InitializeComponent();

            
        }

        private void ShiftSupervisorADD_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(SHIFT_TYPE));

        }

        private void Btn_Add_ShiftSupervisor_Click(object sender, EventArgs e)
        {
            int NoOfShiftSupervisor = (Form1.CompanyShiftSupervisor).Count;
            if (NoOfShiftSupervisor == 2)
            {
                MessageBox.Show("ALREADY TWO SUPERVISORS ARE ASSIGNED","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Form1.DayFlag == 1 && comboBox1.SelectedIndex==0)
                MessageBox.Show("SUPERVISOR FOR DAY SHIFT IS ALREADY ASSIGNED", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Form1.NightFlag == 1 && comboBox1.SelectedIndex == 1)
                MessageBox.Show("SUPERVISOR FOR NIGHT SHIFT IS ALREADY ASSIGNED", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Form1.EmployeeName = textBox1.Text;
                int.TryParse(textBox2.Text, out value1);
                Form1.EmployeeNumber = value1;
                Form1.ShiftIndex = comboBox1.SelectedIndex + 1;
                // This flag will help to keep track whether day supervisor is added or not
                if (Form1.ShiftIndex == 1) Form1.DayFlag++;
                // This flag will help to keep track whether night supervisor is added or not
                if (Form1.ShiftIndex == 2) Form1.NightFlag++;
                double.TryParse(textBox4.Text, out value2); 
                Form1.AnnualSal = value2;
                double.TryParse(textBox5.Text, out value3);
                Form1.AnnulaProBonus = value3;
                ShiftSupervisor Emp = new ShiftSupervisor();
                Emp = new ShiftSupervisor(Form1.EmployeeName, Form1.EmployeeNumber, Form1.ShiftIndex, Form1.AnnualSal, Form1.AnnulaProBonus);
                Form1.CompanyEmployees.Add(Emp);
                Form1.CompanyShiftSupervisor.Add(Emp);
            }
            
        }
    }
}
