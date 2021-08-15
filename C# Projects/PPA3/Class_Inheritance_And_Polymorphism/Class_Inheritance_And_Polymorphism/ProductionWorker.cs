using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_And_Polymorphism
{
    
     public class ProductionWorker : Employee
    {
        
        public SHIFT_TYPE shift { get; set; }
        public ProductionWorker()
        {
            
            HourlyPayRate = 0.0;
        }
        public ProductionWorker(string name, int number, int shifttype, double hourlyPayRate):base(name,number)
        {
            if(shifttype==1)
              shift = SHIFT_TYPE.Day;
            else
              shift = SHIFT_TYPE.Night;
            HourlyPayRate = hourlyPayRate;

        }
        public double HourlyPayRate
        {
            get;
            set;
        }
        public override void Display()
        {
            System.Windows.Forms.MessageBox.Show("Employee Name: " + EmpName+"\n" + "Number: " + EmpNumber + "\n" + "Shift Type: " + shift+"\n" + "Hourly Pay Rate:" +HourlyPayRate+"\n"+ "Position: Production Worker");
        }
    }

}

