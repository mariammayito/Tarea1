using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static string name = "";
        static string book = "";
        static int cell = 0;
        static int op = 0;
        static int precio = 0;
        static int cant =0;
        static int montoPago = 0;
        static int Subtotal = 0;
        static string seguir = "";
        static string n = "";
        static double total = 0;
        static double descFantacia = 0.85;
        static double descInfantil = 0.05;
        static double descMisterio = 0.90;
        static double descEducativo= 0.80;
        static double otro = 0.75;

        static void Main() //void
        //static void Main(string[] args)
        {
            Console.WriteLine("Libreria El Buen Lector");
            Console.Write("Digite su nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Digite su numero de Telefono");
            cell = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Selecione uno de los siguientes libros a comprar");
                Console.WriteLine(" 1. El Señor de los anillos, Las dos torres. (fantasía) ");
                Console.WriteLine(" 2. Alicia en el país de la Maravillas. (infantil)");
                Console.WriteLine(" 3. Cementerio de Mascotas (misterio) ");
                Console.WriteLine(" 4. Quiero aprender (educativo)");
                Console.WriteLine(" 5. El poder del pensamiento Positivo (superación) ");
                Console.WriteLine(" 6. Mi primer libro de matemáticas. (educativo) ");
                Console.WriteLine(" 7. Las aventuras de Tom Sawyer. (infantil) ");
                Console.WriteLine(" 8. El mago de Oz. (fantasía)");
                Console.WriteLine(" 9. La zona muerta. (misterio)");
                Console.WriteLine(" 10. Viaje al centro de la tierra (ciencia ficción)");
                op = int.Parse(Console.ReadLine());

                Console.WriteLine(" Digite la cantidad de libros que desae llevar: ");
                cant = int.Parse(Console.ReadLine());

            
            // int caseSwitch = 1;
            switch (op)
            {
                case 1:
                    book = "El Señor de los anillos, Las dos torres";
                    precio = 8000;
                    total = (cant * precio)*descFantacia;
                    //Console.WriteLine("Case 1");
                    break;
                case 2:
                    book = "Alicia en el país de la Maravillas";
                    precio = 5000;
                    total = (cant * precio)*descInfantil;
                    //Console.WriteLine("Case 2");
                    break;
                case 3:
                    book = "Cementerio de Mascotas";
                    precio = 7000;
                    total = (cant * precio) * descMisterio;
                    //Console.WriteLine("Case 2");
                    break;
                case 4:
                    book = "Quiero aprender";
                    precio = 10000;
                    total = (cant * precio) * descEducativo;
                    //Console.WriteLine("Case 2");
                    break;
                case 5:
                    book = "El poder del pensamiento Positivo";
                    precio = 9000;
                    total = (cant * precio) * otro;
                    //Console.WriteLine("Case 2");
                    break;
                case 6:
                    book = "Mi primer libro de matemáticas";
                    precio = 8000;
                    total = (cant * precio) * descEducativo;
                    //Console.WriteLine("Case 2");
                    break;
                case 7:
                    book = "Las aventuras de Tom Sawyer";
                    precio = 6000;
                    total = (cant * precio) * descInfantil;
                    //Console.WriteLine("Case 2");
                    break;
                case 8:
                    book = "El mago de Oz";
                    precio = 4000;
                    total = (cant * precio) * descFantacia;
                    //Console.WriteLine("Case 2");
                    break;
                case 9:
                    book = "La zona muerta";
                    precio = 2000;
                    total = (cant * precio) * descMisterio;
                    //Console.WriteLine("Case 2");
                    break;
                case 10:
                    book = "Viaje al centro de la tierra";
                    precio = 10000;
                    Subtotal = (cant * precio);
                    total = (cant * precio) * otro;
                    //Console.WriteLine("Case 2");
                    break;
                default:
                    //precio = 8000;
                    //total = (cant * precio);
                    Console.WriteLine("Thanks...");
                    break;
            }

                Console.WriteLine("Desea agregar otro libro?  ");
                Console.WriteLine("Presione s para continuar n para proceder con el pago.");
                seguir = Console.ReadLine();
                seguir = seguir.ToLower();

            }
            while (seguir == n);

            Console.WriteLine("El total a cancelar es de: " + total);
            Console.WriteLine("Digite el Monto con el que va a cancelar: ");
            montoPago = int.Parse(Console.ReadLine());

            Console.WriteLine("============================================");
            Console.WriteLine("*-*      Libreria El Buen Lector         *-*");
            Console.WriteLine("============================================");
            Console.WriteLine("Factura Proforma                     N° 0001");
            Console.WriteLine("Cliente:  "+name);
            Console.WriteLine("Telefono: "+cell);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("   Item                         Ctd         Precio           SubTotal");
            Console.Write(book);
            Console.Write("                      "+cant);
            Console.Write("                                    " + precio);
            Console.Write("                                                      " + Subtotal);
            Console.WriteLine("");
            Console.WriteLine("                                            Total"+total);
            Console.ReadKey();




        }
    }
}
