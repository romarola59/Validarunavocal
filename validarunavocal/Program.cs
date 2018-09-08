using System;

namespace validarunavocal
{
    public class Program
    {

        
        public static void Main()
        {
            string vocal;
            
            Console.WriteLine("Introduce una letra para saber si es vocal: ");
            vocal = Convert.ToString(Console.ReadLine());

            switch(vocal)
            {
                case "A":
                    Console.WriteLine("Esta es la vocal A mayuscula");
                    break;
                case "a": Console.WriteLine("Esta es la vocal a minuscula");
                    break;
                case "E": Console.WriteLine("Esta es la vocal E mayuscula");
                    break;
                case "e":Console.WriteLine("Esta es la vocal e minuscula");
                    break;
                case "I":Console.WriteLine("Esta es la vocal I mayuscula ");
                    break;
                case "i":Console.WriteLine("Esta es la vocal i minuscula");
                    break;
                case "O":Console.WriteLine("Esta es la vocal O mayuscula" );
                    break;
                case "o": Console.WriteLine("Esta es la vocal o minuscula");
                    break;
                case "U": Console.WriteLine("Esta es la vocal U mayuscula ");
                    break;
                case "u": Console.WriteLine("Esta es la vocal u minuscula");
                    break;
                default: Console.WriteLine("Lo que escribiste {0} no es una vocal: ",vocal);
                    break;


                      

            }
            Console.ReadKey();
        }
    }
}
