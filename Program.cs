using System;
using System.Collections.Generic;

namespace LamdaExpressionExample
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
           
            List<Person> listperson = new List<Person>();
          
            AddRecords(listperson);

        }
        private static void AddRecords(List<Person> listperson)
        {
          
            {
                listperson.Add(new Person("1232132", "uma", "12 Main Street", 15));
                listperson.Add(new Person("1232111", "rohit", "13 Main Street", 25));
                listperson.Add(new Person("5555555", "jhon", "14 Main Street", 35));
                listperson.Add(new Person("6978888", "reshu", "15 Main Street", 65));
                listperson.Add(new Person("8111111", "riya", "16 Main Street", 55));

            }
            private static void
            {
                Console.WriteLine("name" + Person.name);
            }

        }
    }
}
