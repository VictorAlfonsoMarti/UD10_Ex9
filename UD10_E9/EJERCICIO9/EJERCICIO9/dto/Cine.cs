using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Cine
    {
        /*
         * clase principal del programa, genera una sala de objetos sillas con un array multidimensional
         * en el constructor rellenamos la sala con objetos sillas generados en el mismo constructor, donde 
         * se le asigna un número de fila o una letra dependiendo de su posicion:
         * 
         *    8 A 8 B 8 C 8 D 8 E 8 F
         *    7 A 7 B 7 C 7 D 7 E 7 F
         *    6 A 6 B 6 C 6 D 6 E 6 F
         *    5 A 5 B 5 C 5 D 5 E 5 F
         *    4 A 4 B 4 C 4 D 4 E 4 F
         *    3 A 3 B 3 C 3 D 3 E 3 F
         *    2 A 2 B 2 C 2 D 2 E 2 F
         *    1 A 1 B 1 C 1 D 1 E 1 F
         *  
         * 
         */

        // ATRIBUTOS
        private Silla[,] sala;
        private Pelicula reproduccion;
        private double precio;

        // GETTERS Y SETTERS
        public double Precio 
        { 
            get { return precio; }
            set { precio = value; }
        }
        internal Pelicula Reproduccion 
        { 
            get { return reproduccion; } 
            set { reproduccion = value; }
        }
        internal Silla[,] Sala
        { 
            get { return sala; }
            set { sala = value; }
        }

        // CONSTRUCTOR
        public Cine(int numero, int letra, int precio)
        {
            // generamos una sala nueva con sillas. filas y columnas
            int numFila = 0;
            
            string lletres = "ABCDEFGHIJKLMNOPQRST";
            this.Precio = precio;
            sala = new Silla[numero,letra]; // creamos la sala
            for (int i = numero - 1; i >= 0; i--) // recorre la fila
            {
                numFila++;
                for (int j = 0; j < letra; j++) // recorre cada columna de la fila
                {
                    this.sala[i,j] = new Silla("" + numFila + lletres[j]); // creamos un objeto Silla nuevo pasandole como valor un número o una letra
                }
            }
        }

        // METODES
        public Boolean CheckPrecioEdad(Espectador espectador, double precio, Pelicula pelicula) 
        {
            // comprueba que el espectador tenga dinero y edad suficiente para entrar
            int edadEspectador = espectador.Edad;
            double dineroEspectador = espectador.Dinero;
            int edadMinima = pelicula.EdadMinima;

            if (edadEspectador < edadMinima || dineroEspectador < precio) //si es menor que la edad minima o no tiene suficiente dinero
            {
                return false;
            }

            // restamos el precio de la entrada al dinero del espectador
            espectador.Dinero = espectador.Dinero - precio;

            return true;

        }
        public void PrintarSala()
        {
            /* metodo para printar una matriz con las dimensiones de la sala. cada posicion corresponde a las posiciones de los objetos Silla
            * de la matriz multidimensional Cine. si la variable ocupado del objeto silla es null, printa una O (silla vacia). si esta asignado
            * un objeto Espectador, silla ocupada, printa una X.
            */

            for (int i = 0; i<Sala.GetLength(0); i++) // recorre la primera posicion del array mulridimensional
            {
                for (int j = 0;j< Sala.GetLength(1); j++) // recorre la segunda posicion del array multidimensionañ
                {
                    if (this.sala[i,j].Ocupado==null) // si la variable ocupada del objeto silla esta null
                    {
                        Console.Write(" O ");
                    }
                    else
                    {
                        Console.Write(" X ");
                    }
                }
                Console.WriteLine(); 
            }
        }
    }
}