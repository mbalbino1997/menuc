using StartAcademy7.BLogic;

namespace StartAcademy7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool whileTrue = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Benvenuto nel menù");
                Console.WriteLine("a per le iterazioni x per uscire");
                string menuChoice = Console.ReadLine().ToLower();
                switch (menuChoice)
                {
                    case "a":
                        Iterations.doWhileIteration();
                        Iterations.whileIteration();
                        whileTrue = true;
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
