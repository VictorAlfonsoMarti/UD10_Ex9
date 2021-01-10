using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Silla
    {
        /*
         * clase silla crea un objeto que se usa en la construccion del objeto cine. se insertan varias sillas
         * en un array multidimensional para formar el conjunto de butacas que forman en cine.
         * 
         * el objeto silla es usado tambien para revisar la ocupacion (variable objeto Espectador ocupado) del cine 
         * 
         */

        // ATRIBUTOS
        private string etiqueta;
        private Espectador ocupado;

        // GETTERS Y SETTERS
        public string Etiqueta
        {
            get { return etiqueta; }
            set { etiqueta = value; }
        }
        internal Espectador Ocupado
        {
            get { return ocupado; }
        }

        // CONSTRUCTORES
        public Silla(string etiqueta)
        {
            this.etiqueta = etiqueta;
            this.ocupado = null;
        }
        public Silla()
        {
            this.ocupado = null;
        }
        
        // METODOS
        public void Asentar(Espectador espectador)
        {
            // metodo usado para que el objeto espectador ocupe una silla, cambia el valor de la variable ocupado.
            // por defecto está en null, este metodo le asigna el objeto Espectador
            this.ocupado = espectador;
        }
        public void Aixecar () 
        {
            // metodo usador para desocupar una silla del cine, cambia el varlo de la variable ocupado
            // al inicio de este metodo, variable ocupado contendra un objeto Espectador, que eliminamos y seteamos a null
            this.ocupado = null;
        }

    }
}
