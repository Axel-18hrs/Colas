using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cola = new Queue<int>();
            bool salir = true;

            while (salir)
            {
                Console.Clear();
                Console.WriteLine("// Select an option" +
                    "\n[1]: Enter a value " +
                    "\n[2]: Delete first element" +
                    "\n[3]: Show first element" +
                    "\n[4]: Show Queue" +
                    "\n[5]: Exit");

                int opcion;

                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {

                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter a value:");
                            cola.Enqueue(Convert.ToInt32(Console.ReadLine()));
                            break;

                        case 2:
                            Console.Clear();
                            if (cola.Count > 0)
                            {
                                int element = cola.Dequeue();
                                Console.Clear();
                                Console.WriteLine("// Element dequeued from the queue: " + element);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The Queue is empty");
                            }

                            break;

                        case 3:
                            Console.Clear();
                            if (cola.Count > 0)
                            {

                                int elementoDs = cola.Peek();
                                Console.Clear();
                                Console.WriteLine("// Element Peeked from the queue: " + elementoDs);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The Queue is empty");
                            }

                            break;

                        case 4:
                            Console.Clear();
                            if (cola.Count > 0)
                            {
                                foreach (int i in cola)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The Queue is empty");
                            }

                            break;

                        case 5:
                            salir = false;
                            Console.Clear();
                            Console.WriteLine("Good bye");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("// Not a valid choice");
                }

                

                Console.ReadKey();
            }
        }
    }
}
