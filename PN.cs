using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы
{
    class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        private char gender;
        public char Gender
        {
            get { return gender; }
            set { if (value == 'M' | value == 'F') gender = value; }
        }
        public Person() 
        {

        }
        public override string ToString()
        {
            return Name + " " + Surname + " " + BirthDate + " " + gender;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name} \t Surname: {Surname} \t Age: {Age(BirthDate)} \t Gender: {gender}" );
        }
        public void Read()
        {
            Console.WriteLine("Input Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Input Surname: ");
            Surname = Console.ReadLine();

            Console.WriteLine("Input date of birth (yyyy-mm-dd): ");
            BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter gender (M/F): ");
            Gender = char.Parse(Console.ReadLine());
        }
        public int Age(DateTime birthDay)
        {
            int age = DateTime.Now.Year - birthDay.Year;

            if (DateTime.Now.Day < birthDay.Day)
            {
                if (DateTime.Now.Month < birthDay.Month)
                {
                    age--;
                }
            }

            return age;
        }

    }
}
