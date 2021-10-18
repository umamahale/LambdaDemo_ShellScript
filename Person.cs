using System;
using System.Collections.Generic;
using System.Text;

namespace LamdaExpressionExample
{
    class Person
    {
        internal static string name;
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public Person(string ssn, string name,string add,int age)
        {
            SSN = ssn;
            Name = name;
            Address = add;
            Age = age;
        }

    }
}
