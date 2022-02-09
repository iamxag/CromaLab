using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassLibraryProject
{
    public sealed class Singleton
    {
        public static int counter = 0;
        private static Singleton Instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (Instance == null)
                    Instance = new Singleton();
                return Instance;
            }
            
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("CounterValue " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}
