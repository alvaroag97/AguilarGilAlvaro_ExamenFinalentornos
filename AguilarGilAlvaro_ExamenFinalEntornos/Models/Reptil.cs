using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguilarGilAlvaro_ExamenFinalEntornos.Models
{
    class Reptil : Animal
    {
        private string Especie;
        private bool Venenoso;

        public Reptil(string nombre, string fechaNacimiento, double peso, string especie, bool venenoso, string comentario) : base(nombre, fechaNacimiento, peso, especie, venenoso)
        {
        }
        public override string ToString()
        {
            return "\nFicha de Pajaro" +
                "\nNombre :" + Nombre +
                "\nEspecie   :" + Especie +
                "\nFecha de Nacimiento: " + FechaNacimiento +
                "\nPeso :" + Peso +
                "\ncantor: " + Venenoso +
                "\nComentarios: " + Comentarios
                ;
        }
    }
}
