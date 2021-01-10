using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Pelicula
    {
        /* 
         * clase que crea un objeto pelicula usado para la creacion del objeto cine. Tambien se usa en los metodos de 
         * espectador para revisar si este es apto para ver la pelicula usando la variable de edadMinima.
         * 
         */

        // ATRIBUTOS
        private string titulo;
        private int duracion;
        private int edadMinima;
        private string director;

        // CONSTRUCTOR
        public Pelicula(string titulo, int duracion, int edadMinima, string director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
        }

        // GETTERS Y SETTERS
        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int EdadMinima { get => edadMinima; set => edadMinima = value; }
        public string Director { get => director; set => director = value; }
    }
}