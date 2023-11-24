using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LABORATORIO13
{
    public class Pantallas
    {
        public static int[] arreglo = new int[100];
        public static int contador = 0;
       
        public static int pantallaPrincipal()
        {

            string texto = " ================================\n" +
                " Encuestas de Calidad\n" +
                " ================================\n" +
                " 1: Realizar encuesta\n" +
                " 2: Ver datos registrados\n" +
                " 3: Eliminar un dato\n" +
                " 4: Ordenar datos de menor a mayor\n" +
                " 5: Salir\n" +
                " ================================\n";
            Console.Write(texto);
            return Operaciones.getEntero(" Ingrese una opción: ", texto);
        }
        public static void realizarEncuesta()
        {
            string texto = " ================================\n" +
                " Nivel de Satisfacción\n" +
                " ================================\n" +
                " ¿Qué tan satisfecho está con la\n" +
                " atención de nuestra tienda?\n" +
                " 1: Nada satisfecho\n" +
                " 2: No muy satisfecho\n" +
                " 3: Tolerable\n" +
                " 4: Satisfecho\n" +
                " 5: Muy satisfecho\n" +
                " ================================\n";
            Console.Write(texto);
            int nivel =  Operaciones.getEntero(" Ingrese una opción: ", texto);

            if (contador == 100)
            {
                Console.WriteLine(" La lista ya esta llena");
            }
            arreglo[contador] = nivel;
            contador++;

            Console.Clear();
            string texto2 = " ===================================\n" +
                " Nivel de Satisfacción\n" +
                " ===================================\n" +

                "\n ¡Gracias por participar!\n" +

                "\n ===================================\n";

            Console.Write(texto2);
            
            Console.WriteLine(" Presione una tecla para\n" +
                " regresar al menú ...\n");
        }
        public static void verDatosRegistrados()
        {
            string texto = " ================================\n" +
                " Ver datos registrados\n" +
                " ================================\n";
            Console.Write(texto);

            if (contador == 0)
            {
                Console.WriteLine("No hay datos");
            }
            
            for (int i = 0; i < contador; i++)
            {

                if (i == contador)
                {
                    Console.Write(arreglo[i] + " [] \n");
                }
                else
                {
                    Console.Write(" [" + arreglo[i] + "] ");
                }

            }
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;
            
            for (int i = 0; i < contador; i++)
            {
                if (arreglo[i]==1)
                {
                    c1++;
                }
                else if (arreglo[i]==2)
                {
                    c2++;
                }
                else if (arreglo[i]==3)
                {
                    c3++;
                }
                else if (arreglo[i]==4)
                {
                    c4++;
                }
                else
                {
                    c5++;
                }
            }
           
            

            Console.Write("\n " + "0"+ c1 + " personas: Nada satisfecho" +
                "\n " + "0" + c2 + " personas: No muy satisfecho" +
                "\n " + "0" + c3 + " personas: Tolerable" +
                "\n " + "0" + c4 + " personas: Satisfecho" + 
                "\n " + "0" + c5 + " personas: Muy satisfecho" +
                "\n");


            string texto2 = "\n ================================\n";
               
            Console.Write(texto2);
            Console.WriteLine(" Presione una tecla para regresar ...\n");
            Console.ReadKey();
            
        }
        public static void eliminarUnDato()
        {
            string texto = " ================================\n" +
                " Eliminar un dato\n" +
                " ================================\n";
            Console.Write(texto);
            
            for (int i = 0; i <= contador-1; i++)
            {
                Console.Write(" 00"+ i + ":[" + arreglo[i] + "] ");
            }

            string texto1 = "\n ================================" +
                "\n Ingrese la posición a eliminar: ";
            Console.Write(texto1);
            int posicion = int.Parse(Console.ReadLine());

            string texto2 = " ================================\n"; 
            Console.Write(texto2);

           
            for (int i = posicion; i < contador; i++)
            {
                arreglo[i] = arreglo[i + 1];

            }
            contador--;
            for (int i = 0; i < contador; i++)
            {
                Console.Write(" 00" + i + ":[" + arreglo[i] + "] ");
            }

            string texto3 = "\n ================================\n";

            Console.Write(texto3);
            Console.WriteLine(" Presione una tecla para regresar ...\n");
            Console.ReadKey();
        }
        public static int OrdenarDatosDeMenorAMayor()
        {
            string texto = " ===================================\n" +
                " Ordenar datos\n" +
                " ===================================\n";
            Console.Write(texto);
            
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(i + ":[" + arreglo[i] + "] ");
                if ((i+1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string texto2 = "\n ================================\n" +
                " Posicion ordenada:\n"+
                " ================================\n";
           
            Console.Write(texto2);

            int ordenado = 0;
            while (ordenado == 0)
                ordenado = 1;

            for (int i = 0; i < contador; i++)
            {
                for( int p = 0; p < contador-1; p++)
                {
                    if (arreglo[p] > arreglo[p + 1])
                    {

                        int auxiliar = arreglo[p + 1];
                        arreglo[p + 1] = arreglo[p];
                        arreglo[p] = auxiliar;
                        ordenado = 0;
                    }
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("No existen notas");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(i + ":[" + arreglo[i] + "] ");
                if ((i + 1) % 5 == 0 )
                {
                    Console.WriteLine();
                }
            }

            string texto3 = " ================================\n" + 
                "Presione una tecla para regresar ...\n";

            Console.Write(texto3);

            Console.ReadLine();
            Console.Clear();

            return pantallaPrincipal();
        }
    }
}
