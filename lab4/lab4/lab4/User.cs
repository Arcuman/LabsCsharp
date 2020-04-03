using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class User
    {
        public string Name { get; private  set; }
        public int Age { get; private set; }
        
        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{Name} {Age} лет\n";
        }
    }
}
