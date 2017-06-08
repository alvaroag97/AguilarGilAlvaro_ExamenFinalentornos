using AguilarGilAlvaro_ExamenFinalEntornos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguilarGilAlvaro_ExamenFinalEntornos
{
    class Program
    {
     

        static public void Mostrarmenu()
        {
            // Declaracion de variables
            int i;
            String[] Menu = { "Añadir", "Busca","Modificar comentario", "Salir"};
            //Proceso
            Console.Clear();
            for (i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine("{0} - {1}", (i + 1), Menu[i]);
            }
        }
        static public void OpcionMenu(ref short n)
        {
            //Inicializar
            
            // Declaracion de variables
            String x = "";
            Boolean escorrecto = false;
            //Proceso
            do
            {
                Console.WriteLine("¿Que deseas hacer?");
                x = Console.ReadLine();
                escorrecto = short.TryParse(x, out n);
                if (!escorrecto)
                {
                    Console.WriteLine("No has introducido un numero");
                    escorrecto = false;

                }
                else if (n < 1 || n > 3)
                {

                    Console.WriteLine("Por favor, ciñese al menu");
                    escorrecto = false;
                }
                else
                {
                    escorrecto = true;
                }



            } while (!escorrecto);
        }
            static void Main(string[] args)
        {
            short n = 0;
            ClinicaVeterinaria clinica = new ClinicaVeterinaria();
            do
            {

                Mostrarmenu();
                OpcionMenu(ref n);
                switch (n)
                {
                    case 1:
                        clinica.InsertarAnimal();
                        break;
                    case 2:
                        clinica.BuscarAnimal();
                        break;
                    case 3:
                        clinica.ModificarComentario();
                        break;
                }

            } while (n != 4);
        }
    }
}
