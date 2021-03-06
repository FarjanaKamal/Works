using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_And_Polymorphism
{
    public class TeamLeader: ProductionWorker
    {
    
        public TeamLeader()
        {
            MonthlyBonusAmount = 0.0;
            RequiredNumberofTrainingHours = 0;
            TheNumberofTrainingHoursAttended = 0;

        }
        public TeamLeader(string name, int number, int shifttype,double hourlyPayRate,double MnthlyBAmount, int RequiredNoTrainingHours, int NoTrainingHoursAttended) : base(name, number, shifttype, hourlyPayRate)
        {
            MonthlyBonusAmount = MnthlyBAmount;
            RequiredNumberofTrainingHours = RequiredNoTrainingHours;
            TheNumberofTrainingHoursAttended = NoTrainingHoursAttended;
        }
        public double MonthlyBonusAmount
        {
            get;
            set;
        }
        public int RequiredNumberofTrainingHours
        {
            get;
            set;
        }
        public int TheNumberofTrainingHoursAttended
        {
            get;
            set;
        }
        public override void Display()
        {
            System.Windows.Forms.MessageBox.Show("Employee Name:" + EmpName +"\n"+ "Number:" + EmpNumber+"\n"  + "Shift Type: " + shift + "\n" + "Hour Pay Rate:" +HourlyPayRate+ "\n" + "Monthly Bonus:" + MonthlyBonusAmount + "\n" + "Required number of training hours.: " + RequiredNumberofTrainingHours+ "\n" + "The number of training hours attended: " +TheNumberofTrainingHoursAttended+ "\n" +"Position: Team Leader");
        }
    }
}
