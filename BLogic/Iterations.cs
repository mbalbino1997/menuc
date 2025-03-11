using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAcademy7.BLogic
{
    public class Iterations
    {
    public static void whileIteration()
        {
            bool isOk=true;
            string input = "";
            while (isOk)
            {
                Console.WriteLine("Sei nel while");
           string param = Console.ReadLine();
            isOk =param=="fine" ? false : true ;

            }

        }
    public static void doWhileIteration()
        {
            bool isOk = true;
            do
            {
                Console.WriteLine("Sei nel do while");
                string param = Console.ReadLine();
                isOk = param == "fine" ? false : true;
            } while (isOk);
        }
    }
}
