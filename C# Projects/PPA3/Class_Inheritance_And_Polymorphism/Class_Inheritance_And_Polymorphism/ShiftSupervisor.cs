using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_And_Polymorphism
{
    public class ShiftSupervisor: Employee
    {
    public SHIFT_TYPE shift { get; set; }
        public ShiftSupervisor()
    {
            AnnualSalary = 0.0;
            AnnualProductionBonus = 0.0;
    }
    public ShiftSupervisor(string name, int number, int shifttype, double AnnuSal, double AnnuBonus):base(name,number)
    {
            if (shifttype == 1)
                shift = SHIFT_TYPE.Day;
            else
                shift = SHIFT_TYPE.Night;
            AnnualSalary = AnnuSal;
            AnnualProductionBonus = AnnuBonus;
        }
        public double AnnualSalary
    {
        get;
        set;
    }
    public double AnnualProductionBonus
    {
        get;
        set;
    }
    public override void Display()
        {
            System.Windows.Forms.MessageBox.Show("Shift Super Visor Name:"+EmpName+"Number:"+EmpNumber+"Shift Type: "+shift+ "Annual Salary:"+AnnualSalary+ "Annual Production Bonus: "+AnnualProductionBonus);
        }

    }
}
