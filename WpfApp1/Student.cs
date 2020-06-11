using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Student
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        bool IsRegisterd { get; set; }

        public Student() { }

        public Student(int id, string firstName, string lastName, bool isRegisterd)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            IsRegisterd = isRegisterd;
        }
    }
}
