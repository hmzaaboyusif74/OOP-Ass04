using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP03
{
    public class driver
    {
        public int age;
        public string name;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 16) { age = value; }
                else
                {
                    Console.WriteLine("not allowed");
                }
            }
        }
        public string Name
        {
           
            set
            {
                if (value != null && !string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("null excption");
                }
            }
            get { return name; }
        }
        public driver(int age,string name)
        {
            Age = age;
            Name = name;
            
        }
    }

}
