using FirstClassLibraryProject;
using System;
using System.Collections.Generic;

namespace CromaLab
{
    public class Program
    {
        interface Iuser
        {
            bool Login(string username, string password);
            bool Register(string username, string password, string email);
            void Looger(string Error);

        }
        //public Student student1 { get; set; }
        public class CheckingClass
        {
            public bool ISNULL(string s)
            {
                if(s == null)
                    return false;
                else
                    return true;
            }
            public bool Contains(string s)
            {
                if(s.Contains("abdul"))
                    return false;
                else
                    return true;
            }
        }
        public void PrintSudent()
        {
            //Staff staff = new Staff();
            ////Console.WriteLine(student1.MobileNumber);
            //Console.WriteLine(student1.Age);
        }

        //
        static void Main(string[] args)
        {
            Singleton single = Singleton.GetInstance;
            single.PrintDetails("Hi");
            Singleton single1 = Singleton.GetInstance;
            single1.PrintDetails("Hi1");
            //List<Person> list = new List<Person>
            //{
            //    new Staff(50000, "Permanent"),
            //    new Staff(30000, "Temperory")
            //};
            //foreach (Person person in list)
            //{
            //    Console.WriteLine(person.GetType());
            //}


            //Person person = new Person();


            //PartialCalss partial = new PartialCalss();
            //partial.Add();
            //partial.multiply();
            //Staff staff = new Staff(2000, "Supporting Staff");
            //Staff staff1 = new Staff();
            //staff.FinalSalaryCalculation();
            //staff.GetInfo();

            //Teacher teacher = new Teacher(10000, "Teaching Staff");
            //teacher.FinalSalaryCalculation();
            //teacher.GetInfo();

            //Staff staffTeacher = new Teacher(12000, "Teacher Class reference variable pointing Staff Class");
            //teacher.FinalSalaryCalculation();
            //teacher.GetInfo();
            // Read 2 varaibles and display output
            //ReadAndDisplay2Variables(); // No Return value, No parameter
            //Student student = new Student() { RoolNumber = 100, MobileNumber = 9000000000 };
            //student.RoolNumber = 100;
            //student.MobileNumber = 9000000000;

            //Student student = new Student();
            //Teacher teacher = new Teacher();




            //Program program = new Program();
            //program.student1 = student;
            //List<Student> students = new List<Student>();
            //int[] RoolNumber; // 10 40 bytes; 1, 2, ... 9,10
            //int[] MobilNumber; // 10 40 bytes; 
            //int[] arrayName1 = new int[3];
            //int[] arrayName2 = new int[] { 1, 2};
            //int[] arrayName3 = new int[] { 1, 2, 3, 4};

            //List<string> listOfNames = new List<string>() { "abdul", "rohit", "james", "stephan"};
            // index of 
            //int index = listOfNames.IndexOf("james");
            //listOfNames[index] = "john";
            //index = listOfNames.IndexOf("rohit");
            //listOfNames.RemoveAt(index);
            /* a = [ 2  3
             *       5  6]
            */
            /* b = [ 5  2
             *       4  3]
            */
            /*
             * a + b = [7 5
             *          9 9]
             */

            //int[][] jaggedArrays = new int[][] { arrayName1, arrayName2, arrayName3 };
            //int[,] multi = new int[2, 2]; 
            //double quare = Math.Sqrt(5);
            //quare = SquareRoot(5);

            //for(int i = 0; i < arrayName1.Length; i++)
            //{
            //    arrayName1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i = 0; i < arrayName1.Length; i++)
            //{ 
            //    Console.WriteLine(arrayName1[i]);
            //}
            ///*
            //* 2 3
            //* 4 2
            //*/
            //for (int i = 0;i < multi.GetLength(0); i++)
            //{
            //    for(int j = 0; j < multi.GetLength(1); j++)
            //    {
            //        multi[i,j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0;i < multi.GetLength(0); i++)
            //{
            //    for(int j = 0; j < multi.GetLength(1); j++)
            //    {
            //        Console.WriteLine(multi[i,j]);
            //    }
            //}
            ////foreach(datatype datatypename in arrayName)
            //foreach (int item in arrayName3)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");
            //for (int index = 0; index < 10; index= index + 2)
            //{
            //    Console.WriteLine(index);
            //}
            //int index1 = 1;
            //while(index1 <= 10)
            //{
            //    Console.WriteLine(index1);
            //    index1++;
            //}






            Console.WriteLine("Welcome to electric Billing Software\n");
            int unit = 0;
            bool initFlag = false;
            bool errFlag = false;
            do
            {
                if (initFlag)
                {
                    Console.WriteLine("Please Provide corect reading Previous month should be less than current months reading \n");
                }
                Console.WriteLine("Please Provide Previous Months Reading");
                int prevoiusMonthReading;
                try
                {
                    prevoiusMonthReading = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    try
                    {
                        Console.WriteLine("Please Provide integer value for Previous Months Reading");
                        prevoiusMonthReading = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("You have not provided the correct input twice");
                        Console.WriteLine("The reading you provide for Previous Months is not integer please provide integer value");
                        errFlag = true;
                        continue;
                    }
                }
                Console.WriteLine("Please Provide Present Reading");
                int presentReading;
                try
                {
                    presentReading = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    try
                    {
                        Console.WriteLine("Please Provide integer value for Present Reading");
                        presentReading = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("You have not provided the correct input twice");
                        Console.WriteLine("The reading you provide for Present Reading is not integer please provide integer value");
                        errFlag = true;
                        continue;
                    }
                }
                unit = presentReading - prevoiusMonthReading;
                initFlag = unit < 0;
            } while (initFlag);

            //if(unit < 0)
            //{
            //    Console.WriteLine("Please Provide integer value for Previous Months Reading");
            //    prevoiusMonthReading = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Please Provide Present Reading");
            //    presentReading = Convert.ToInt32(Console.ReadLine());
            //}
            //unit = presentReading - prevoiusMonthReading;
            //int unit = 500, billAmount;
            int billAmount = 0;
            if (errFlag)
            {
                switch (unit)
                {
                    //case datatype when Experession 
                    case int when unit <= 100:
                        billAmount = 100;
                        break;
                    case int when (unit <= 200 && unit > 100):
                        billAmount = 100 + (unit - 100) * 5;
                        break;
                    case int when (unit <= 300 && unit > 200):
                        billAmount = 100 + 500 + (unit - 200) * 6;
                        break;
                    case int when (unit <= 400 && unit > 300):
                        billAmount = 100 + 500 + 600 + (unit - 300) * 7;
                        break;
                    default:
                        billAmount = 100 + 500 + 600 + 700 + ((unit - 400) * 8);
                        break;
                }
                string message = $"Your Bill for {unit} is {billAmount}";
                Console.WriteLine(message);
            }
            //Console.WriteLine("Welcome to Dotnet Training");
            //Console.WriteLine("Please Provide Your Age : ");
            //Console.WriteLine("Your grade is  {0}", grade);
            //Console.ReadLine();
            //string s = "abdul";
            //    if (string.IsNullOrEmpty(s) && s == "abdul")
            //char grade = 'B';

            //switch (grade)
            //{
            //    // case value
            //    case 'A':
            //        Console.WriteLine("Excellent!");
            //        break;
            //    case 'B':
            //    case 'C':
            //        Console.WriteLine("Well done");
            //        break;
            //    case 'D':
            //        Console.WriteLine("You passed");
            //        break;
            //    case 'F':
            //        Console.WriteLine("Better try again");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid grade");
            //        break;
            //}
            //Console.WriteLine("Your grade is  {0}", grade);
            //Console.ReadLine();
            //string s = "abdul";
            //    if (string.IsNullOrEmpty(s) && s == "abdul")
            //int billAmount;
            //int previousMonthValue = 3000, presentMonthValue = 2000;
            //int unit = presentMonthValue - previousMonthValue;
            //int unit = 100;
            //if (unit <= 100)
            //{
            //    billAmount = 100;
            //}                
            //else if (unit <= 200 && unit > 100)
            //{
            //    billAmount =  100 + (unit - 100) * 5;
            //}
            //else if (unit <= 300 && unit > 200)
            //{
            //    billAmount = 100 + 500 + (unit - 200) * 6;
            //}
            //else if (unit <= 400 && unit > 300)
            //{
            //    billAmount = 100 + 500 + 600 + (unit - 300) * 7;
            //}
            //else
            //{
            //    billAmount = 100 + 500 + 600 + 700 + (unit - 400) * 8;
            //}
            ////Console.WriteLine("Your Bill for " + unit + "is" + billAmount);
            //string message = $"Your Bill for {unit} is {billAmount}";
            //Console.WriteLine($"Your Bill for {unit} is {billAmount}");
            //Console.WriteLine(" your bill amount is = " + billAmount);
            //Console.WriteLine($" your bill amount is = {billAmount}");




            //int age;
            //try
            //{
            //    age = Convert.ToInt32(Console.ReadLine());
            //    if(age <18)
            //    {
            //        Console.WriteLine("You are not eligible to vote");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are eligible to vote");
            //    }

            //}
            //catch
            //{
            //    Console.WriteLine("Please Provide Integer");
            //    age = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Your Age is " + age);
            //int value = sizeof(int);
            //int valuel = sizeof(long);
            //var ageI = 4;
            //string TypeOfClass = typeof(Program).Name;

            //int valued = sizeof(double);
            //Console.WriteLine("Size of Age variable is", value);


            //int a, b,c;
            //a = 10; //  1010
            //b = 20; // 10100
            //c = a & b; //00000 
            //c = a | b; // 11110


            //a = (b + c) * c - a / ++c * 24 != 0 ? 1 : 0; 

            //PropertiesExplaination propertiesExplaination = new PropertiesExplaination();
            //string TypeOfPropeties = typeof(PropertiesExplaination).Name;
            //propertiesExplaination.CashWithdrawn = 15000;
            //propertiesExplaination.CashWithdrawn = 10000;
            //const int a = 2147483647; //4 bytes
            //const int b = 2147483647; //4 bytes
            //Console.Write(unchecked(a + b));
            //Double b = 7.3; //8 bytes
            //char c = 'a'; //2 bytes
            //string s = "Chroma lab"; //2 bytes per characters
            //Console.WriteLine($"{a} {b} {c} {s}");
            ////a = (int)b;            
            //b = a;
            //Console.WriteLine($"{a} {b} {c} {s}");
            //StaticReadonlyConst staticReadonlyConst = new StaticReadonlyConst(2, 3, "abdul");
            //StaticReadonlyConst staticReadonlyConst1 = staticReadonlyConst;
            //Console.WriteLine($"Area Of Circle = {staticReadonlyConst.CalculateArea(6)} , s = {StaticReadonlyConst.s} ");
            //Console.WriteLine($"x = {staticReadonlyConst.x}, y = {staticReadonlyConst.y},  z = {StaticReadonlyConst.z}, s = {StaticReadonlyConst.s}");
            //StaticReadonlyConst staticReadonlyConst1 = new StaticReadonlyConst(5, 4, "Amit");
            //Console.WriteLine($"x = {staticReadonlyConst1.x}, y = {staticReadonlyConst1.y},  z = {StaticReadonlyConst.z}, s = {StaticReadonlyConst.s}");
            //StaticReadonlyConst staticReadonlyConst2 = new StaticReadonlyConst(5, 4, "rohit");
            //staticReadonlyConst2.printValues(6);
            //staticReadonlyConst1.printValues(6);
            //staticReadonlyConst.printValues(6);
            //staticReadonlyConst1.printValues(6);
            //staticReadonlyConst2.printValues(6);

        }
       

        private static void ReadAndDisplay2Variables()
        {
            string var = ReadVariableString();  // return type no parameters
            //Console.WriteLine("Enter a variable 2");
            string var1 = ReadVariableString();
            PrintVariablesInConsole(var, var1);
            string merge = Concatenate(var, var1); // return type with parameters
        }

        private static string Concatenate(string var, string var1)
        {
            return var + var1;
        }

        private static void PrintVariablesInConsole(string var, string var1)
        {
            Console.WriteLine($"The 2 variables are {var} and {var1}");
        }

        private static string ReadVariableString()
        {
            Console.WriteLine("Enter a variable 1");
            string var = Console.ReadLine();
            return var;
        }

        private static double SquareRoot(int v)
        {
            throw new NotImplementedException();
        }
    }
    public class StaticReadonlyConst
    {
        public int raduis = 1;
        public readonly int y = 1;
        public readonly string Name;
        public const double PI = 3.142;
        public static int s = 1;

        public StaticReadonlyConst(int x, int y, string Name)
        {
            this.Name = Name;
            this.raduis = x;
            this.y = y;
            s++;
        }
        public void printValues(int x)
        {
            int store = 0;    
            x = x;
            s++;
        }
        public double CalculateArea(int raduis)
        {
            this.raduis = raduis;
            s++;
            object myBoxed = raduis;
            int myUnBoxed = (int)myBoxed;
            return this.raduis * PI;            
        }
    }

    public class PropertiesExplaination
    {
        private int balance = 20000;
        private int cashWithdrawn;
        public string CustomerName { get; set; }
        //public string CustomerName 
        //{ 
        //    get
        //    {
        //        return CustomerName;
        //    } 
        //    set
        //    {
        //        CustomerName = value;
        //    }
        //}
        public int CashWithdrawn
        {
            set
            {
                if(value < 20000 && value < balance)
                {
                    cashWithdrawn = value;
                    balance -= value;
                }
            }
            get
            {
                return cashWithdrawn;
            }
        }
    }
}



