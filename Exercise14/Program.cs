using System;
using ClassLibrary1;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {           
            var user1 = new User("Иван","Иванов","25-742-49-28");
            var user2 = new User("Петр","Петров","17-658-12-03");
            var user3 = new User("И", "T", "145-17-89");
            var user1Valid = ValidateUser(user1);
            var user2Valid = ValidateUser(user2);
            var user3Valid = ValidateUser(user3);

            Console.WriteLine($"user1 validation result = {user1Valid}");
            Console.WriteLine($"user2 validation result = {user2Valid}");
            Console.WriteLine($"user3 validation result = {user3Valid}");
        }
        static bool ValidateUser(User user)
        {            
            Type t = typeof(User);
            
            object[] attrs = t.GetCustomAttributes(true);
            
            foreach (MyCustomAttribute attr in attrs)
            {
                if (Regex.IsMatch(user.PhoneNumber,attr.Number)&&Regex.IsMatch(user.Name,attr.Name)&&Regex.IsMatch(user.Surname,attr.Surname))
                    return true;
                else
                    return false;
            }
            return false;            
        }
    }
}
