using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_And_Polymorphism
{
    public class Employee
    {
        public Employee()
        {
            EmpName = "";
            EmpNumber = 10;
        }
        public Employee(string name, int number)
        {
            EmpName=name;
            EmpNumber= number;
        }
        public string EmpName
        {
            get;
            set;
        }
        public int EmpNumber
        {
            get;
            set;
        }
        public virtual void Display()
        {
            System.Windows.Forms.MessageBox.Show("Employee Name:" + EmpName +" " + "Number:" + EmpNumber + " " );
        }
    }
}
