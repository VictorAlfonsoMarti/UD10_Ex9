using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Espectador
    {
        /*
         * clase espectador que crea un objeto usado par rellenar el objeto sillas del objeto cine.
         * 
         */

        // ATRIBUTOS
        private string nombre;
        private int edad;
        private double dinero;
        
        // CONSTRUCTOR
        public Espectador(string nombre, int edad, double dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }

        public Espectador()
        {
        }

        // GETTERS Y SETTERS
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Dinero { get => dinero; set => dinero = value; }

        // METODOS
        public void MostrarEspectadores(Espectador[] Gent)
        {
            // printa las variables del objeto espectador que se pasa por array de objetos espectador.
            int cantitat=Gent.Length;
            for (int i = 0; i < cantitat; i++)
            {
                Console.WriteLine("Espectador n{0}: {1}, {2}, {3}€",i+1,Gent[i].Nombre,Gent[i].Edad,Gent[i].Dinero);
            }
        }
    }
}
