using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguilarGilAlvaro_ExamenFinalEntornos.Models
{
    abstract class Animal
    {
        protected string Nombre;
        protected string FechaNacimiento;
        protected double Peso;
        protected string Comentarios;
        private string microchip;
        private bool cantor;

        public Animal(string nombre, string fechaNacimiento, double peso, string comentarios)
        {
            Nombre1 = nombre;
            FechaNacimiento1 = fechaNacimiento;
            Peso1 = peso;
            Comentarios1 = comentarios;
        }

        public Animal(string nombre, string fechaNacimiento, double peso, string comentarios, string microchip) : this(nombre, fechaNacimiento, peso, comentarios)
        {
            this.microchip = microchip;
        }

        public Animal(string nombre, string fechaNacimiento, double peso, string comentarios, bool cantor) : this(nombre, fechaNacimiento, peso, comentarios)
        {
            this.cantor = cantor;
        }

        public string Nombre1
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public string FechaNacimiento1
        {
            

            set
            {
                FechaNacimiento = value;
            }
        }

        public double Peso1
        {
          

            set
            {
                if(value <= 0)
                {
                    throw new Exception("un animal no puedo no pesar nada");
                }else
                {
                    Peso = value;
                }
            }
        }

        public string Comentarios1
        {
            get
            {
                return Comentarios;
            }

            set
            {
                Comentarios = value;
            }
        }

      
       
        
    }
}
