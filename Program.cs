using System;

namespace exercise3_properties
{
    class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Priyanka";
            Console.WriteLine(myObj.Name);
        }
    }
}
