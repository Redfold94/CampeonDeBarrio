using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex03_CampeonDeBarrio;

namespace CampeonDeBarrioTest
{
    [TestClass]
    public class IdentificaCampeonTest
    {
        [TestMethod]
        public void TestIdentificaCampeon1()
        {
            Jugador[] losJugadores = new Jugador[5];

            for (int i = 0; i < losJugadores.Length; i++)
                losJugadores[i] = new Jugador();

            losJugadores[0].Nombre = "M";
            losJugadores[0].Campañas = 1;
            losJugadores[0].Puntos = 100;

            losJugadores[1].Nombre = "E";
            losJugadores[1].Campañas = 2;
            losJugadores[1].Puntos = 150;

            losJugadores[2].Nombre = "J";
            losJugadores[2].Campañas = 3;
            losJugadores[2].Puntos = 152;

            losJugadores[3].Nombre = "S";
            losJugadores[3].Campañas = 4;
            losJugadores[3].Puntos = 300;

            losJugadores[4].Nombre = "L";
            losJugadores[4].Campañas = 2;
            losJugadores[4].Puntos = 100;


            string actual = Program.IdentificaCampeon(losJugadores);
            string expected = "\n\nEl Campeón del Barrio es M\n que obtuvo promedio de 100,00 puntos por campaña.";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestIdentificaCampeon2()
        {
            Jugador[] losJugadores = new Jugador[5];

            for (int i = 0; i < losJugadores.Length; i++)
                losJugadores[i] = new Jugador();

            losJugadores[0].Nombre = "M";
            losJugadores[0].Campañas = 1;
            losJugadores[0].Puntos = 100;

            losJugadores[1].Nombre = "E";
            losJugadores[1].Campañas = 1;
            losJugadores[1].Puntos = 100;

            losJugadores[2].Nombre = "J";
            losJugadores[2].Campañas = 2;
            losJugadores[2].Puntos = 150;

            losJugadores[3].Nombre = "S";
            losJugadores[3].Campañas = 4;
            losJugadores[3].Puntos = 310;

            losJugadores[4].Nombre = "L";
            losJugadores[4].Campañas = 2;
            losJugadores[4].Puntos = 110;


            string actual = Program.IdentificaCampeon(losJugadores);
            string expected = "\n\nSe presentó empate con un puntaje de 100,00 entre: \n M con 1 campaña(s) jugadas\n E con 1 campaña(s) jugadas";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestIdentificaCampeon3()
        {
            Jugador[] losJugadores = new Jugador[5];

            for (int i = 0; i < losJugadores.Length; i++)
                losJugadores[i] = new Jugador();

            losJugadores[0].Nombre = "M";
            losJugadores[0].Campañas = 3;
            losJugadores[0].Puntos = 100;

            losJugadores[1].Nombre = "E";
            losJugadores[1].Campañas = 2;
            losJugadores[1].Puntos = 200;

            losJugadores[2].Nombre = "J";
            losJugadores[2].Campañas = 3;
            losJugadores[2].Puntos = 152;

            losJugadores[3].Nombre = "S";
            losJugadores[3].Campañas = 4;
            losJugadores[3].Puntos = 300;

            losJugadores[4].Nombre = "L";
            losJugadores[4].Campañas = 2;
            losJugadores[4].Puntos = 100;


            string actual = Program.IdentificaCampeon(losJugadores);
            string expected = "\n\nEl Campeón del Barrio es E\n que obtuvo promedio de 100,00 puntos por campaña.";
            Assert.AreEqual(expected, actual);
        }
    }
}