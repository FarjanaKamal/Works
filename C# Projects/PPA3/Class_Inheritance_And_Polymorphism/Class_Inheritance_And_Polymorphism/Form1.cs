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
    public enum SHIFT_TYPE
    {
        Day = 1,
        Night = 2
    }
    
    public partial class Form1 : Form
    {
        public static List<Employee> CompanyEmployees = new List<Employee>();
        public static List<ProductionWorker> CompanyEmployeesASProductionWorker = new List<ProductionWorker>();
        public static List<ShiftSupervisor> CompanyShiftSupervisor = new List<ShiftSupervisor>();
        public static List<TeamLeader> CompanyTeamLeader = new List<TeamLeader>();
        public static string EmployeeName;
        public static int EmployeeNumber;
        public static double WorkerPayRate;
        public static double AnnualSal;
        public static double AnnulaProBonus;
        public static double MonthlyBonus;
        public static int RequiredTrainingHoursNumber;
        public static int AttendedNumberTraningHours;
        public static int ShiftIndex;
        public static int DayFlag = 0, NightFlag = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreateEmployee_Click(object sender, EventArgs e)
        {
            Form EmpForm = new EmployeeADD();
            EmpForm.ShowDialog();     
        }

        private void BtnCreateShiftSupervisor_Click(object sender, EventArgs e)
        {
            Form ShitSupForm = new ShiftSupervisorADD();
            ShitSupForm.ShowDialog();
        }

        private void BtnCreateProductionWorkers_Click(object sender, EventArgs e)
        {

            Form ProdWorkerForm = new ProductionWorkerADD();
            ProdWorkerForm.ShowDialog();
        }


        private void Btn_TeamLEaderAdd_Click(object sender, EventArgs e)
        {
            Form TeamLeaderForm = new TeamLeaderADD();
            TeamLeaderForm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ShiftSupervisor emp in CompanyShiftSupervisor)
            {
                emp.Display();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*listView1.View = View.Details;
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Number");*/
            foreach (Employee emp in CompanyEmployees)
            {
                emp.Display();
            }    
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (TeamLeader emp in CompanyTeamLeader)
            {
                emp.Display();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ProductionWorker emp in CompanyEmployeesASProductionWorker)
            {
              emp.Display();
              
            }
        }
    }
}
