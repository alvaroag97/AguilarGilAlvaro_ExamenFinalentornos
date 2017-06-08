using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguilarGilAlvaro_ExamenFinalEntornos.Models
{
    class ClinicaVeterinaria
    {
        List<Animal> ListaAnimal = new List<Animal>();

        public ClinicaVeterinaria(List<Animal> listaAnimal)
        {
            ListaAnimal = new List<Animal>();
        }

        public ClinicaVeterinaria()
        {
        }

        public void InsertarAnimal()
        {
            String Nombre, Raza, Fecha, Microchip, Comentarios, Especie;
            double Peso;
            bool Cantor = false;
            bool Venenoso = true;
            int e;
            short n;
            string x = "";
            Boolean escorrecto = false;
            Console.WriteLine("¿Que tipo de animal quieres introducir?");
            Console.WriteLine("1-Perro");
            Console.WriteLine("2-Gato");
            Console.WriteLine("3-Pajaro");
            Console.WriteLine("4-Reptil");
            
            //VALIDACION PARA EL MENU
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
                else if (n < 1 || n > 4)
                {

                    Console.WriteLine("Por favor, ciñese al menu");
                    escorrecto = false;
                }
                else
                {
                    escorrecto = true;
                }



            } while (!escorrecto);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Raza: ");
                    Raza = Console.ReadLine();
                    Console.WriteLine("Nombre: ");
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Fecha de Nacimiento: ");
                    Fecha = Console.ReadLine();
                    Console.WriteLine("Microchip: ");
                    Microchip= Console.ReadLine();
                    Console.WriteLine("Comentarios: ");
                    Comentarios = Console.ReadLine();
                    Console.WriteLine("Peso: ");
                    Peso = Console.Read();
                    
                    ListaAnimal.Add(new Perro(Nombre, Raza ,Fecha, Peso, Microchip, Comentarios));

                    break;
                case 2:
                    Console.WriteLine("Raza: ");
                    Raza = Console.ReadLine();
                    Console.WriteLine("Nombre: ");
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Fecha de Nacimiento: ");
                    Fecha = Console.ReadLine();
                    Console.WriteLine("Microchip: ");
                    Microchip = Console.ReadLine();
                    Console.WriteLine("Comentarios: ");
                    Comentarios = Console.ReadLine();
                    Console.WriteLine("Peso: ");

                    Peso = Console.Read();
                    ListaAnimal.Add(new Gato(Nombre, Raza, Fecha, Peso, Microchip, Comentarios));
                    break;
                case 3:
                    Console.WriteLine("Especie: ");
                    Especie = Console.ReadLine();
                    Console.WriteLine("Nombre: ");
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Fecha de Nacimiento: ");
                    Fecha = Console.ReadLine();
                    Console.WriteLine("Microchip: ");
                    Microchip = Console.ReadLine();
                    Console.WriteLine("Comentarios: ");
                    Comentarios = Console.ReadLine();
                    Console.WriteLine("¿Canta mucho?");
                    Console.WriteLine("1-Si");
                    Console.WriteLine("2-No");
                    e = Console.Read();
                    Console.WriteLine("Peso: ");
                    Peso = Console.Read();
                    if (e == 1)
                    {
                        Cantor = true;
                    }else if (e == 2)
                    {
                        Cantor = false;
                    }
                    ListaAnimal.Add(new Pajaro(Nombre, Fecha, Peso, Especie, Cantor ,Comentarios));
                    break;
                case 4:
                    Console.WriteLine("Especie: ");
                    Especie = Console.ReadLine();
                    Console.WriteLine("Nombre: ");
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Fecha de Nacimiento: ");
                    Fecha = Console.ReadLine();
                    Console.WriteLine("Microchip: ");
                    Microchip = Console.ReadLine();
                    Console.WriteLine("Comentarios: ");
                    Comentarios = Console.ReadLine();
                    Console.WriteLine("¿Es venenoso?");
                    Console.WriteLine("1-Si");
                    Console.WriteLine("2-No");
                    Console.WriteLine("Peso: ");
                    Peso = Console.Read();
                    e = Console.Read();
                    if (e == 1)
                    {
                        Venenoso = true;
                    }
                    else if (e == 2)
                    {
                        Venenoso = false;
                    }
                    ListaAnimal.Add(new Reptil(Nombre, Fecha, Peso, Especie, Venenoso, Comentarios));
                    break;
            }

            Console.WriteLine("Añadido");
            Console.ReadLine();
           
        }
         public void BuscarAnimal()//Este metodo para ver si existe y te dice todo sobre el
        {
            string Busqueda;
            Console.WriteLine("¿Que animal buscas?");
            Busqueda = Console.ReadLine();
            foreach(Animal a in ListaAnimal)
            {
   
                if (a.Nombre1.Equals(Busqueda))
                {
                    Console.WriteLine(a.ToString());
                   
                }else
                {
                    throw new Exception("No existe ese animal");
                }
            }
            Console.ReadLine();

        }

        public void ModificarComentario()//Para modificar el comentario del animal
        {
            string Busqueda;
            string Comentario = "";
            Console.WriteLine("¿Que animal buscas?");
            Busqueda = Console.ReadLine();
            foreach (Animal a in ListaAnimal)
            {
                if (a.Nombre1.Equals(Busqueda))
                {
                    Console.WriteLine("¿Cual es el nuevo comentario?");
                    Comentario = Console.ReadLine();
                    a.Comentarios1.Insert(0, Comentario);

                    Console.WriteLine("Comentario cambiado");
                    Console.ReadLine();
                }
                else
                {
                    throw new Exception("No existe");
                }
            }
        }
            public override string ToString()
        {
            string Busqueda;
            Console.WriteLine("¿De que animal quieres la ficha?");
            Busqueda = Console.ReadLine();
            foreach (Animal a in ListaAnimal)
            {
                if (a.Nombre1.Equals(Busqueda))
                {
                    Console.WriteLine(a.ToString());
                }
                else
                {
                    throw new Exception("No existe ese animal");
                }
            }
            return "No encontrado";
        }
    }
 }

