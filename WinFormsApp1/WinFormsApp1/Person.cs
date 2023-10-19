using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Person
    {
        private string name;
        private string surname;
        private DateTime birth_date;
        private string email;
        private string phone;

        public Person()
        {

        }
        public Person(string name, string surname, string email, string phone, DateTime date)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            BirthDate = date;
        }
        public string Name
        {
            get => name; set
            {
                if (value == "") throw new Exception("Name CANNOT be empty.");
                name = value;
            }
        }
        public string Surname
        {
            get => surname; set
            {
                if (value == "") throw new Exception("Surname CANNOT be empty.");
                surname = value;
            }
        }
        public string Email
        {
            get => email; set
            {
                if (value == "") throw new Exception("Email CANNOT be empty.");
                email = value;
            }
        }
        public string Phone
        {
            get => phone; set
            {
                if (value == "") throw new Exception("Phone CANNOT be empty.");
                phone = value;
            }
        }
        public DateTime BirthDate
        {
            get => birth_date; set
            {
                BirthDate = value;
            }
        }

    }
}
