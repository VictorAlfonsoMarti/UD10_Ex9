using Ejercicios;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO9
{
    class Test : Generadores
    {
        public static void TestMain()
        {
            /*
             * Metodo test para testear la aplicacion del cine. crea nuevos objetos cine y los ejecuta con diversos
             * prints y comprobadores para revisar que el programa haga lo esperado.
             */

            // Generem el cinema amb el seu revisor
            Cine palaas = new Cine(8, 8, 5);


            Espectador revisor = new Espectador("Revisor", 40, 0);

            // Generem un array de Espectadors
            Espectador[] publico = new Espectador[20];

            // Omplim el array de espectadors amb el mètode
            publico = Generadores.GenerarPublic(publico);

            // Els mostrem
            revisor.MostrarEspectadores(publico);

            // Generem la pelicula i mostrem la seva informació
            Pelicula film1 = new Pelicula("Peli1", 5, 18, "Spilberg");
            Console.WriteLine();

            Console.WriteLine("Se está proyectando {0} con precio de entrada {1} para mayores de {2} años de edad", film1.Titulo, palaas.Precio, film1.EdadMinima);

            Random r = new Random();
            Console.WriteLine();
            // Recorrem cada Espectador i comprobem que pot entrar.
            for (int i = 0; i < publico.Length; i++)
            {
                if (palaas.CheckPrecioEdad(publico[i], palaas.Precio, film1))
                {
                    bool sentado = false;
                    // Si pot entrar, busquem un lloc per asseure'l.
                    while (!sentado)
                    {
                        int pos1 = r.Next(0, palaas.Sala.GetLength(0));
                        int pos2 = r.Next(0, palaas.Sala.GetLength(1));
                        // Si la cadira està ocupada, li busquem un altre. En cas contrari l'assentem.
                        if (palaas.Sala[pos1, pos2].Ocupado == null)
                        {
                            palaas.Sala[pos1, pos2].Asentar(publico[i]);
                            sentado = true;
                            Console.WriteLine("{1} se sentado en {0}", palaas.Sala[pos1, pos2].Etiqueta, publico[i].Nombre);
                        }
                    }
                }
                else
                {
                    // Si no es pot sentar, informem d'aquest fet.
                    Console.WriteLine("{0} no ha pogut entrar a la pelicula", publico[i].Nombre);
                }
            }
            revisor.MostrarEspectadores(publico);
            palaas.PrintarSala();
        }
    }
}
