using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_Abecedario
{
    class Program
    {
        static void MethodA ()
        {
            string[] letrasA = {"A","C","E","G","I","K","M","Ñ","P","R","T","V","X","Z" };
            for(int i=0; i < letrasA.Length; i++)
            {
                Console.WriteLine("Proceso A letra {0}", letrasA[i]);
                Thread.Sleep(1000); // pausa el hilo por 1000 milisegundos
            }
        }
        static void MethodB ()
        {
            string[] letrasB = {"B","D","F","H","J","L","N","O","Q","S","U","W","Y"};
            for (int i = 0; i < letrasB.Length; i++)
            {
                Console.WriteLine("Proceso B letra {0}", letrasB[i]);
                Thread.Sleep(1000); //pausa el hilo por 1000 milisegundos
            }
        } 

        static void Main(string[] args)
        {
            var tareaA = Task.Factory.StartNew(MethodA); //crea la tareaA y la ejecuta
            var tareaB = Task.Factory.StartNew(MethodB); //crea la tareaB y la ejecuta
            

            
            Task.WaitAll(tareaA,tareaB); //espera que las tareas finalizen para ejecutar su codigo

            Console.WriteLine("tareas finalizadas!"); //escribe al finalizar las tareas A y B
            Console.ReadLine();
        }
    }
}
