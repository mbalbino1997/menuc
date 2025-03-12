using StartAcademy7.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAcademy7.BLogic
{
    public class EmployeeHandler
    {
       List<Employee> employeSet = [];

        public EmployeeHandler(List<Employee> initialEmployers)
        {
            employeSet=initialEmployers;
        }
        public bool stringIncludesNumber(string input)
        {
            bool containsNumber = false;
            foreach (char c in input)
            {
                if (char.IsDigit(c)) 
                {
                    containsNumber = true;
                    break; 
                }
            }
            return containsNumber;
        }

        public bool addEmployee(Employee e)
        {
            bool added = false;
            Employee? isEqual = employeSet.Find(employe => employe.Matricola == e.Matricola);
            if (isEqual==null && e.FirstName.Trim().Length>0 && e.LastName.Trim().Length>0 && !stringIncludesNumber(e.FirstName) && !stringIncludesNumber(e.LastName)) {

            employeSet.Add(e);
                added = true;
            } else
            {
                if (e.FirstName.Trim().Length == 0 || e.LastName.Trim().Length == 0) Console.WriteLine("Il Nome ed il Cognome non possono essere vuoti");
                if (stringIncludesNumber(e.FirstName) || stringIncludesNumber(e.LastName)) Console.WriteLine("Il Nome ed il Cognome possono contenere solo lettere");
                if (isEqual != null) Console.WriteLine($"Il numero di matricola ({e.Matricola}) è già presente");
            }


                return added;
        }
        public void printEmployes()
        {
            foreach (Employee employee in employeSet)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, età: {employee.Age}. Numero matricola:{employee.Matricola}");
            }
        }
        public bool deleteEmploye(int numMatricola)
        {
            bool isDeleted = false;
            try
            {
            Employee toDelete = employeSet.Find(e => e.Matricola == numMatricola);
            if(toDelete != null)
            {
            employeSet.Remove(toDelete);
                isDeleted = true;
            }

            }
            catch (Exception e)
            {
                Console.WriteLine($"errore:{e.Message}");
            }

            return isDeleted;
        }
        public void filterEmployeesByAgeAndGender(int ageMax,int ageMin, Gender gender)
        {
            List<Employee> filteredEmployees = employeSet.FindAll(e => e.Age >= ageMin && e.Age<=ageMax && e.Gender == gender);
            Console.WriteLine($"Elenco dipendenti filtrati per età compresa tra ({ageMax},{ageMin}) e genere {gender}:");
            foreach (Employee employee in filteredEmployees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, età: {employee.Age}. Numero matricola:{employee.Matricola}");
            }
            ;
            
        }
    }
}
