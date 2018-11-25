using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceConsole.ServiceWebFX;

namespace WebServiceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceFXSoapClient WSSoapClient = new WebServiceFXSoapClient();

            /////////////////////
            ///unlimited loop
            /////////////////////////
            while (true)
            {
                Console.WriteLine("entrer un nombre entre 1 et 100,  Ctrl+C pour quitter ");
                int n = int.Parse(Console.ReadLine());
                int resultat = WSSoapClient.Fibonacci(n);
         
                Console.WriteLine("fibonacci({0}) must to return {1}",n,resultat);
                //Console.WriteLine(resultat);


            }
           
            

        }
    }
}
