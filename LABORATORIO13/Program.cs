using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int opcion = Pantallas.pantallaPrincipal();
            int prueba = 2;
            do
            {

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Pantallas.realizarEncuesta();
                        Console.ReadKey();
                        break;
                    case 2:
                        Pantallas.verDatosRegistrados();
                        break;
                    case 3:
                        Pantallas.eliminarUnDato();
                        break;
                    case 4:
                        Pantallas.OrdenarDatosDeMenorAMayor();
                        break;

                }
                Console.Clear();
                opcion = Pantallas.pantallaPrincipal();
            } while (prueba > 0);
        }
    }
}
