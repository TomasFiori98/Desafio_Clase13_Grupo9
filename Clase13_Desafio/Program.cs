using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Implementar una clase llamada "Operación" y definir dos métodos estáticos 
//que permitan sumar y restar dos valores enteros (ingresados por teclado)

namespace Clase13_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, opc;

            Console.WriteLine("Ingrese dos numeros enteros a continuacion: ");
            Console.Write(" 1° -> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" 2° -> ");
            b = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Que desea hacer con estos dos numeros? ");
                Console.WriteLine(" 1- Sumar");
                Console.WriteLine(" 2- Restar");
                Console.WriteLine(" 3- SALIR DEL PROGRAMA");
                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("La suma es = {0}", Operacion.sumar(a, b));
                        break;
                    case 2:
                        Console.WriteLine("La resta es = {0}", Operacion.restar(a, b));
                        break;
                    case 3:
                        Console.WriteLine("\n   SALIENDO DEL PROGRAMA");
                        break;
                    default:
                        Console.WriteLine("\n La opcion ingresada no es valida.");
                        Console.WriteLine("Por favor digite una opcion correcta.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opc != 3);
            
        }
    }
}
