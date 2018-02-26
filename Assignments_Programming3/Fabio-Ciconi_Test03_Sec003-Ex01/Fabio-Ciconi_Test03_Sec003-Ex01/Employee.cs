using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabio_Ciconi_Test03_Sec003_Ex01
{
    class Employee
    {

        public string Name { get; set; }
        public double salary;
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    salary = 0.0;
            }
        } // end property
        // constructor
        public Employee(string name, double sal)
        {
            Name = name;
            Salary = sal;
        }

        public Employee()
        {
        }

        public override string ToString()
        {
            return String.Format("\nName: {0}, Salary:{1}", Name, Salary);
        }

    }
}
