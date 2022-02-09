using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassLibraryProject
{
    public class Staff:Person
    {
        int Age;
        public int Salary;
        const int PFPercntage = 12;
        public double FinalSalary;
        protected string TypeOfEmployee;
        public void PrintStaff()
        {
            Console.WriteLine(Age);
            Console.WriteLine(AddresssName);
        }
        public Staff(int salary, string typeOfEmployee)
        {
            Salary = salary;
            TypeOfEmployee = typeOfEmployee;
        }

        public virtual void FinalSalaryCalculation()
        {
            FinalSalary = Salary - PFPercntage * 1.0/ 100 * Salary;
            Console.WriteLine(FinalSalary);
        }
        public void GetInfo()
        {            
            Console.WriteLine($"Age = {Age}, Name = {Name}, TypeOFEmployee = {this.TypeOfEmployee}  \n This is a staff class");
        }
    }

}
