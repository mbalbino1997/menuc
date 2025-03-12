using StartAcademy7.BLogic;
using StartAcademy7.DataModels;

namespace StartAcademy7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> initialList = new()
{
    new Employee(30, "pinco", "pallino", 222, Gender.Male),
    new Employee(28, "luigi", "pluto", 123,Gender.Male),
    new Employee(35, "sara", "buongiorno", 234, Gender.Female),
    new Employee(31, "michela", "buongiorno", 444, Gender.Female)
};
            EmployeeHandler handler = new EmployeeHandler(initialList);
            bool whileTrue = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Benvenuto nel menù");
                Console.WriteLine("a) ITERAZIONI; b) GESTIONE DIPENDENTI x) USCIRE");
                string menuChoice = Console.ReadLine().ToLower();
                switch (menuChoice)
                {
                    case "a":
                        Iterations.doWhileIteration();
                        Iterations.whileIteration();
                        whileTrue = true;
                        break;
                    case "b":
                        whileTrue = true;
                        Console.WriteLine("Gestione dipendenti: a)inserire dipendente; b)eliminare un dipendente; c)stampare l'elenco dipendenti, d) filtrare in base al range di età(max e min inclusi) e genere.");
                        string manageEmployees = Console.ReadLine().ToLower();
                          
                        switch (manageEmployees)
                        {
                            case "a":
                                Console.Write("Inserisci età: ");
                                int age = int.Parse(Console.ReadLine());

                                Console.Write("Inserisci nome: ");
                                string firstName = Console.ReadLine();

                                Console.Write("Inserisci cognome: ");
                                string lastName = Console.ReadLine();

                                Console.Write("Inserisci matricola: ");
                                int matricola = int.Parse(Console.ReadLine());

                                Console.Write("Inserisci 0 se sei uomo, 1 se sei donna: ");
                                int genderInput = int.Parse(Console.ReadLine());

                                if (Enum.IsDefined(typeof(Gender), genderInput))
                                {
                                    Gender gender = (Gender)genderInput;

                                    if (handler.addEmployee(new Employee(age, firstName, lastName, matricola, gender)))
                                    {
                                        Console.WriteLine("Elenco dipendenti aggiornato:");
                                        handler.printEmployes();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Errore nell'aggiunta del dipendente.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Opzione non valida per il genere.");
                                }
                                Console.WriteLine("Premi un tasto qualsiasi per continuare...");
                                Console.ReadLine();
                                break;
                            case "b":
                                Console.Write("Inserisci il numero di matricola del dipendente che vuoi eliminare:");
                                int deleteEmploye = Convert.ToInt32(Console.ReadLine());
                                handler.deleteEmploye(deleteEmploye);
                                Console.WriteLine("Elenco dipendenti:");
                                handler.printEmployes();
                                Console.WriteLine("premi un tasto qualsiasi per continuare...");
                                Console.ReadLine();
                                break;
                            case "c":
                                Console.WriteLine("Elenco dipendenti:");
                                handler.printEmployes();
                                Console.WriteLine("premi un tasto qualsiasi per continuare...");
                                Console.ReadLine();
                                break;
                            case "d":
                                Console.Write("Inserisci l'età minima: ");
                                int minAge = int.Parse(Console.ReadLine());

                                Console.Write("Inserisci l'età massima: ");
                                int maxAge = int.Parse(Console.ReadLine());

                                Console.Write("Inserisci 0 per Uomo o 1 per Donna (Genere): ");
                                int filterGenderInput = int.Parse(Console.ReadLine());
                                Gender filterGender = (Gender)filterGenderInput;

                                handler.filterEmployeesByAgeAndGender(minAge,maxAge,Gender.Female);
                                Console.WriteLine("premi un tasto qualsiasi per continuare...");
                                Console.ReadLine();
                                break;
                            default: Console.WriteLine("Comando non valido");
                                Console.WriteLine("premi un tasto qualsiasi per continuare...");
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case "x":
                        whileTrue = false;
                        break;
                    default: Console.WriteLine("Comando non valido");
                        whileTrue = true;
                        break;

                }



            } while (whileTrue);
        }
    }
}
