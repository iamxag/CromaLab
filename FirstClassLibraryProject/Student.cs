using System;
using System.Collections.Generic;

namespace FirstClassLibraryProject
{
    internal class Student : Person
    {
        public int RoolNumber { get; set; }  //4
         //4        
        public int Semister { get; set; } // 4
        public double marks { get; set; } //8
      
        
        public string DepartmentName { get; set; } //memory

        //functionName
        //No of Variable
        //datatypes
        private void Add(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private void Add(int v)
        {
            throw new NotImplementedException();
        }
        private void Add(string v)
        {
            throw new NotImplementedException();
        }

        private void Add(int v, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public void ReadStudent()
        {

        }

        public void PrintStudent()
        {

        }
    }
}
