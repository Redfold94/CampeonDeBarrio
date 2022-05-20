using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_CampeonDeBarrio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Campeón del Barrio *** \n\n");

            Console.WriteLine("Se registrarán la cantidad de campañas y puntos totales para 5 jugadores");
            Console.WriteLine("El campeón será quien tenga mejor promedio de puntos por campaña");
            Console.WriteLine("Si hay empate con el mejor promedio, se indicará el nombre de los jugadores");

            Jugador[] losJugadores = new Jugador[5];

            //Aqui inicializamos cada posición del arreglo
            for (int i = 0; i < losJugadores.Length; i++)
                losJugadores[i] = new Jugador();

            //Aqui ingresamos el nombre de los jugadores, validando que no hayan datos nulos en el nombre
            //y que los valores de cantidades de puntos y campañas correspondan a los requisitos
            int jugador = 0;
            while (jugador < losJugadores.Length)
            {
                Console.Write($"\nIngresa el nombre del jugador No. {(jugador + 1)}: ");
                losJugadores[jugador].Nombre = Console.ReadLine();

                //Aqui validamos si el dato es nulo
                if (losJugadores[jugador].Nombre.Length == 0)
                    Console.WriteLine("El nombre del jugador no pueder ser nulo. Intenta nuevamente");
                else
                {
                    try
                    {
                        Console.Write("Cantidad de campañas jugadas: ");
                        losJugadores[jugador].Campañas = int.Parse(Console.ReadLine());

                        //Si la cantidad de campañas es diferente de cero, se pregunta por los puntos totales
                        if (losJugadores[jugador].Campañas != 0)
                        {
                            Console.Write("Cantidad de puntos obtenidos: ");
                            losJugadores[jugador].Puntos = int.Parse(Console.ReadLine());

                            //Si los puntos están en el rango y la cantidad de campañas son válidas,
                            //se pasa al siguiente jugador
                            if (losJugadores[jugador].Puntos >= 100 && losJugadores[jugador].Puntos <= 400 && losJugadores[jugador].Campañas >= 0)
                                jugador++;
                            else
                                Console.WriteLine("Las cantidades deben ser enteros positivos. " +
                                    "Los puntos deben estar en un rango [100-400]. " +
                                    "Intenta nuevamente!");
                        }
                        else
                        {
                            // Si las campañas son cero, los puntos son cero y se pasa al siguiente jugador
                            losJugadores[jugador].Puntos = 0;
                            jugador++;
                        }
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("Las cantidades deben ser enteros positivos. Intenta nuevamente!");
                        Console.WriteLine($"Error: {elError.Message}");
                    }
                }
            }

            //Visualizamos datos ingresados
            Console.WriteLine("\n\nLos datos ingresados para los jugadores son: \n");

            foreach (Jugador unJugador in losJugadores)
                Console.WriteLine(unJugador.InfoJugador());

            //Finalmente, identificamos quien es el campeón invocando la función
            IdentificaCampeon(losJugadores);
        }

        /// <summary>
        /// Identifica quien es el campeón entre los jugadores a partir del criterio definido
        /// </summary>
        /// <param name="losJugadores">Arreglo de los jugadores</param>
        static void IdentificaCampeon(Jugador[] arregloJugadores)
        {
            //Arbitrariamente seleccionamos el campeón como el primer jugador del arreglo
            Jugador jugadorCampeon = arregloJugadores[0];


            //Comparamos con el resto de jugadores
            for (int i = 1; i < arregloJugadores.Length; i++)
                //Si hay un jugador con mejor promedio, es el nuevo campeón
                if (jugadorCampeon.Promedio < arregloJugadores[i].Promedio)
                    jugadorCampeon = arregloJugadores[i];

            //Contamos cuantos jugadores tienen ese mejor puntaje
            int cantidadCampeones = 0;

            foreach (Jugador unJugador in arregloJugadores)
                if (unJugador.Promedio == jugadorCampeon.Promedio)
                    cantidadCampeones++;

            //Aqui visualizamos resultados
            if (cantidadCampeones == 1)
                Console.WriteLine($"\n\nEl Campeón del Barrio es {jugadorCampeon.Nombre}\n" +
                $" que obtuvo promedio de {jugadorCampeon.Promedio.ToString("0.00")} puntos por campaña.");
            else
            {
                Console.WriteLine($"\n\nSe presentó empate con un puntaje de {jugadorCampeon.Promedio.ToString("0.00")} entre: ");

                foreach (Jugador unJugador in arregloJugadores)
                    if (unJugador.Promedio == jugadorCampeon.Promedio)
                        Console.WriteLine($"- {unJugador.Nombre} con {unJugador.Campañas} campaña(s) jugadas");
            }
        }
    }
}
