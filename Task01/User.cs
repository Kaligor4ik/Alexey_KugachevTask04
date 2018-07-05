using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class User
    {
        public User() { }

        public User(string lastName, string firstName = "Иван", string middleName = "Иванович", string birthDate = "21.02.1990", string age = "27")
        {
            _lastName = lastName;
            _firstName = firstName;
            _middleName = middleName;
            _birthDate = birthDate;
            _age = age;
        }

        private string _lastName;
        private string _firstName;
        private string _middleName;
        private string _birthDate;
        private string _age;

        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string MiddleName { get => _middleName; set => _middleName = value; }
        public string BirthDate { get => _birthDate; set => _birthDate = value; }
        public string Age { get => _age; set => _age = value; }
    }
}
