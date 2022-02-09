using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassLibraryProject
{
    public class Teacher : Staff
    {
        List<string> Semisters;
        
        const int PFPercntage = 12;
        public Teacher(int salary, string typeOfEmployee) :base(salary, typeOfEmployee)
        {
        }
        public void PrintTeacher()
        {
            Console.WriteLine(MobileNumber);
            Student student =  new Student();
        }
        public override void FinalSalaryCalculation()
        {
            base.FinalSalaryCalculation();
            FinalSalary = FinalSalary - 200;
        }
        public new void GetInfo()
        {            
            base.GetInfo();
            Console.WriteLine($"Types Of Staff = {this.TypeOfEmployee} No of subject = 5");
        }

    }
    //public class SeniorTeacher: Teacher
    //{

    //}
}
