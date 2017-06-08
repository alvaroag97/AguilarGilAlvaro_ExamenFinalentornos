using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguilarGilAlvaro_ExamenFinalEntornos.Models
{
    class Perro : Animal
    {
        private string raza;
        private string microchip;

        public Perro(string nombre, string raza, string fechaNacimiento, double peso, string microchip, string comentario) : base(nombre, fechaNacimiento, peso, raza, microchip)
        {
        }

        public override string ToString()
        {
            return "\nFicha de Perro" +
                "\nNombre :" + Nombre+
                "\nRaza   :" + raza+
                "\nFecha de Nacimiento: " + FechaNacimiento+
                "\nPeso :" + Peso+
                "\nMicrochip: " + microchip+
                "\nComentarios: " + Comentarios 
                ;
        }
    }
  

}
