using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguilarGilAlvaro_ExamenFinalEntornos.Models
{
    class Pajaro : Animal
    {
        private string Especie;
        private bool Cantor;

        public Pajaro(string nombre, string fechaNacimiento, double peso, string especie, bool cantor, string comentario) : base(nombre, fechaNacimiento, peso, especie, cantor)
        {
        }
        public override string ToString()
        {
            return "\nFicha de Pajaro" +
                "\nNombre :" + Nombre +
                "\nEspecie   :" + Especie +
                "\nFecha de Nacimiento: " + FechaNacimiento +
                "\nPeso :" + Peso +
                "\ncantor: " + Cantor +
                "\nComentarios: " + Comentarios
                ;
        }
    }
}
