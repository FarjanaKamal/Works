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
    public partial class ProductionWorkerChangesTeamLeader : Form
    {
        int MBonus, NoOfTRaning, AttendedTraning;
        public ProductionWorkerChangesTeamLeader()
        {
            InitializeComponent();
            
        }

        private void BTN_ChangeToTeamLeader_Click(object sender, EventArgs e)
        {
            int SelecMember = listBox1.SelectedIndex;
            Form1.EmployeeName = Form1.CompanyEmployeesASProductionWorker.ElementAt(SelecMember).EmpName;
            Form1.EmployeeNumber = Form1.CompanyEmployeesASProductionWorker.ElementAt(SelecMember).EmpNumber;
            Form1.WorkerPayRate = Form1.CompanyEmployeesASProductionWorker.ElementAt(SelecMember).HourlyPayRate;
            SHIFT_TYPE shift = Form1.CompanyEmployeesASProductionWorker.ElementAt(SelecMember).shift;
            String ShiftValue=shift.ToString();
            int.TryParse(textBox1.Text, out MBonus);
            Form1.MonthlyBonus = MBonus;
            int.TryParse(textBox2.Text, out NoOfTRaning);
            Form1.RequiredTrainingHoursNumber = NoOfTRaning;
            int.TryParse(textBox3.Text, out AttendedTraning);
            Form1.AttendedNumberTraningHours = AttendedTraning;
            TeamLeader Emp = new TeamLeader();
            if(ShiftValue=="Day")
             Emp = new TeamLeader(Form1.EmployeeName, Form1.EmployeeNumber, (int)SHIFT_TYPE.Day, Form1.WorkerPayRate, Form1.MonthlyBonus, Form1.RequiredTrainingHoursNumber, Form1.AttendedNumberTraningHours);
            else
             Emp = new TeamLeader(Form1.EmployeeName, Form1.EmployeeNumber, (int)SHIFT_TYPE.Night, Form1.WorkerPayRate, Form1.MonthlyBonus, Form1.RequiredTrainingHoursNumber, Form1.AttendedNumberTraningHours);
            Form1.CompanyEmployeesASProductionWorker.RemoveAt(SelecMember);
            Form1.CompanyEmployees.Add(Emp);
            Form1.CompanyEmployeesASProductionWorker.Add(Emp);
        }

        private void ProductionWorkerChangesTeamLeader_Load(object sender, EventArgs e)
        {
            foreach (ProductionWorker emp in Form1.CompanyEmployeesASProductionWorker)
            {
                listBox1.Items.Add(emp.EmpName);
            }
        }
    }
}
