using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    class Student
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Student(int id, string name)
        {
            this.id = id;
            Name = name;
        }
        public override string ToString()
        {
            return String.Format("Id: {0}, Name:{1}", Id, Name);
        }
    }
}
