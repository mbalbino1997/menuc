using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAcademy7.DataModels

{
    public enum Gender
    {
        Male,
        Female
    }
    public class Employee
    {
        private int age;
        private string firstName;
        private string lastName; 
        private int matricola;
        private Gender gender;

        public Employee(int age, string firstName, string lastName, int matricola, Gender gender)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Matricola = matricola;
            Gender = gender;
        }

        public int Age { get => age; set => age = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Matricola { get => matricola; set => matricola = value; }
        public Gender Gender { get => gender; set => gender = value; }
    }
}
