using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{    
    [MyCustom("[А-Яа-я]{2,10}", "[А-Яа-я]{2,20}", "[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}")]
    public class User
    {        
        public string PhoneNumber { get; set; }
       
        public string Name { get; set; }
        
        public string Surname { get; set; }
        public User(string name,string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
    }
}
