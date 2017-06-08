using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguilarGilAlvaro_ExamenFinalEntornos.Models
{
    class Gato : Animal
    {
        private string raza;
        private string microchip;

        public Gato(string nombre, string raza, string fechaNacimiento, double peso, string microchip,string comentario) : base(nombre, fechaNacimiento, peso, raza, microchip)
        {
        }

        public override string ToString()
        {
            return "\nFicha de Gato\n" +
                "\nNombre :" + Nombre +
                "\nRaza   :" + raza +
                "\nFecha de Nacimiento: " + FechaNacimiento +
                "\nPeso :" + Peso +
                "\nMicrochip: " + microchip +
                "\nComentarios: " + Comentarios
                ;
        }
    }
}
