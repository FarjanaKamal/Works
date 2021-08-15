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
        double hrate;

        private void TeamLeaderADD_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(SHIFT_TYPE));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (textBox1.Text!="" &&
            int.TryParse(textBox2.Text, out value1) &&
            double.TryParse(textBox4.Text,out hrate)&&
            int.TryParse(textBox5.Text, out MBonus) &&
            int.TryParse(textBox6.Text, out NoOfTRaning) &&  int.TryParse(textBox7.Text, out AttendedTraning)&& comboBox1.SelectedIndex > -1)
            {
                //Team leaders are required to attend a minimum number of hours of training per year
                if (AttendedTraning>= NoOfTRaning)
                {
                    Form1.EmployeeName = textBox1.Text;
                    Form1.EmployeeNumber = value1;
                    Form1.ShiftIndex = comboBox1.SelectedIndex + 1;
                    Form1.WorkerPayRate = hrate;
                    Form1.MonthlyBonus = MBonus;
                    Form1.RequiredTrainingHoursNumber = NoOfTRaning;
                    Form1.AttendedNumberTraningHours = AttendedTraning;
                    TeamLeader Emp = new TeamLeader();
                    Emp = new TeamLeader(Form1.EmployeeName, Form1.EmployeeNumber, Form1.ShiftIndex, Form1.WorkerPayRate, Form1.MonthlyBonus, Form1.RequiredTrainingHoursNumber, Form1.AttendedNumberTraningHours);
                    Form1.CompanyEmployees.Add(Emp); // a team leader is also an employee
                    Form1.CompanyEmployeesASProductionWorker.Add(Emp); // a team leader is also a production worker
                    Form1.CompanyTeamLeader.Add(Emp);
                }
                else
                {
                    MessageBox.Show("DOESNOT MEET THE MINIMUM TRAINING HOURS REQUIREMENTS", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                
            }
        }
    }
}
