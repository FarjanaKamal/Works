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
    public partial class TeamLeaderADD : Form
    {
        int value1,MBonus, NoOfTRaning, AttendedTraning;

        private void TeamLeaderADD_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(SHIFT_TYPE));
        }

        public TeamLeaderADD()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ProductionWorkerChangesTeamLeader form1 = new ProductionWorkerChangesTeamLeader();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.EmployeeName = textBox1.Text;
            int.TryParse(textBox2.Text, out value1);
            Form1.EmployeeNumber = value1;
            Form1.ShiftIndex = comboBox1.SelectedIndex + 1;
            int.TryParse(textBox4.Text, out MBonus);
            Form1.MonthlyBonus = MBonus;
            int.TryParse(textBox5.Text, out NoOfTRaning);
            Form1.RequiredTrainingHoursNumber = NoOfTRaning;
            int.TryParse(textBox6.Text, out AttendedTraning);
            Form1.AttendedNumberTraningHours = AttendedTraning;
            TeamLeader Emp = new TeamLeader();
            Emp = new TeamLeader(Form1.EmployeeName, Form1.EmployeeNumber, Form1.ShiftIndex, Form1.WorkerPayRate, Form1.MonthlyBonus, Form1.RequiredTrainingHoursNumber, Form1.AttendedNumberTraningHours);
            Form1.CompanyEmployees.Add(Emp);
            Form1.CompanyEmployeesASProductionWorker.Add(Emp);
        }
    }
}
