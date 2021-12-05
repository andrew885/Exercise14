using System;

namespace ClassLibrary1
{
    public class MyCustomAttribute: System.Attribute
    {       
        public string Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public MyCustomAttribute(string name,string surname, string number)
        {
            Number = number;
            Name = name;
            Surname = surname;
        }
    }
}
