using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._04._2024.Models
{
    internal class Student
    {
        private static int Count = 1;
        private string name;
        private string surname;
        public int Id { get; }


        public string Name
        {
            get 
            {
                return name; 
            }
            set 
            { if (value.Length >= 3) 
                {
                    name = value; 
                } 
            }
        }

        public string Surname
        {
            get 
            {
                return surname; 
            }
            set 
            {
                surname = value;
            }
        }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = Count;
            Count++;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name:{Name}\nSurname:{Surname}\nId={Id}");
        }






    }
}

