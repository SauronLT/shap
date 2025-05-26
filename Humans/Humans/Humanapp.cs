using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private byte _age;

        public byte Age
        {
            get => _age;
            set
            {
                if (value >= 0 && value <= 120)
                    _age = value;
                else
                    throw new ArgumentException("bele shey yox");
            }
        }


        public Human() { } 
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }
        public virtual void ShowFullData()
        {
            Console.WriteLine($"Full Name: {GetFullName()} | Age: {Age}");
        }
    }

   
    public class User : Human
    {
        private string _userName;
        private string _password;

        public string UserName
        {
            get => _userName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("aye sehf yazdin");
                if (value.Length < 6 || value.Length > 25)
                    throw new ArgumentException("ae duz yaz");
                _userName = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("duz yaz");
                if (value.Length < 8 || value.Length > 25)
                    throw new Exception("dedim duz yaz");
                _password = value;
            }
        }

        
        public User(string name, string surname, string username, string password)
            : base(name, surname)
        {
            UserName = username;
            Password = password;
        }

        public override void ShowFullData()
        {
            Console.WriteLine($"Full Name: {GetFullName()} | Age: {Age} | Username: {UserName}");
        }
    }

    
    
}
