using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ74
{
    class Program
    {
        static void Main(string[] args)
        {
            String Palabra;

            Stack pilaPalabras = new Stack();
            Console.WriteLine("ingrese la primera palabra a la cola:");
            Palabra = Console.ReadLine();

            while (Palabra != "")
            {
                pilaPalabras.Push(Palabra);
                Console.WriteLine("Ingrese la próxima palabra");
                Palabra = Console.ReadLine();
            }
            while (pilaPalabras.Count > 0)
            {

                string texto = (string)pilaPalabras.Pop();
                Console.WriteLine(texto);
            }

            Console.ReadKey();
        }
    }
}
