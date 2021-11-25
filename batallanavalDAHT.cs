using System;


namespace BataallaNavalDAHT
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] posicionBarcoJugador1 = new string[3];
            string[] posicionBarcoJugador2 = new string[3];

            string[,] coordenadaElegidaJugador1 = new string[1, 6];

            string[,] coordenadaElegidaJugador2 = new string[1, 6];

            for (int i = 0; i < 1; i++)
            {
                for (int n = 0; n < 6; n++)
                {
                    coordenadaElegidaJugador1[i, n] = "";
                    coordenadaElegidaJugador2[i, n] = "";
                }
            }

            int vidasJugador1 = 3;
            int vidasJugador2 = 3;

            mostrarCoordenadas(coordenadaElegidaJugador1, posicionBarcoJugador2, 1);
            Console.WriteLine("Hola a el juego Batalla Naval. \nRecuerda que este es un juego de coordenadas y el tablero solo sera de 1*6");
            Console.WriteLine("JUGADOR 1");
            Console.WriteLine("Escriba la posicion de sus barcos");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Barco " + (i + 1) + ": ");
                posicionBarcoJugador1[i] = Console.ReadLine();
                posicionBarcoJugador1[i] = posicionBarcoJugador1[i].ToUpper();
            }

            Console.Clear();

            mostrarCoordenadas(coordenadaElegidaJugador2, posicionBarcoJugador1, 2);
            Console.WriteLine("Hola a el juego Batalla Naval. \nRecuerda que este es un juego de coordenadas y el tablero solo sera de 1*6");
            Console.WriteLine("JUGADOR 2");
            Console.WriteLine("Escriba la posicion de sus barcos");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Barco " + (i + 1) + ": ");
                posicionBarcoJugador2[i] = Console.ReadLine();
                posicionBarcoJugador2[i] = posicionBarcoJugador2[i].ToUpper();
            }

            Console.Clear();


            for (int i = 0; i < 1; i++)
            {
                for (int n = 0; n < 6; n++)
                {
                    //Turno primer jugador
                    mostrarCoordenadas(coordenadaElegidaJugador1, posicionBarcoJugador2, 1);
                    Console.WriteLine("JUGADOR 1");
                    Console.Write("Escoja una coordenada: o");
                    
                    coordenadaElegidaJugador1[i, n] = Console.ReadLine();
                    coordenadaElegidaJugador1[i, n] = coordenadaElegidaJugador1[i, n].ToUpper();
                    Console.WriteLine("Cuando escribas tu coordenada presiona ENTER");
                    for (int a = 0; a < 3; a++)
                    {
                        if (posicionBarcoJugador2[a] == coordenadaElegidaJugador1[i, n])
                        {
                            Console.WriteLine("Le diste a un barco");
                            vidasJugador2 = vidasJugador2 - 1;
                            Console.ReadKey();
                        }
                    }

                    Console.Clear();
                    if (vidasJugador2 == 0)
                    {
                        Console.WriteLine("JUGADOR 1 GANO");
                        Console.ReadKey();
                        return;
                    }


                    //Turno segundo jugador
                    mostrarCoordenadas(coordenadaElegidaJugador2, posicionBarcoJugador1, 2);
                    Console.WriteLine("JUGADOR 2");
                    Console.Write("Escoja una coordenada: \nRecuerda poner letra y numero");
                    coordenadaElegidaJugador2[i, n] = Console.ReadLine();
                    coordenadaElegidaJugador2[i, n] = coordenadaElegidaJugador2[i, n].ToUpper();
                    Console.WriteLine("Cuando escribas tu coordenada presiona ENTER");
                    for (int a = 0; a < 3; a++)
                    {
                        if (posicionBarcoJugador1[a] == coordenadaElegidaJugador2[i, n])
                        {
                            Console.WriteLine("Le diste a un barco");
                            vidasJugador1 = vidasJugador1 - 1;
                            Console.ReadKey();
                        }
                    }
                    Console.Clear();

                    if (vidasJugador1 == 0)
                    {
                        Console.WriteLine("JUGADOR 2 GANO");
                        Console.ReadKey();
                        return;
                    }
                }
            }


            Console.ReadKey();
        }
        private static void mostrarCoordenadas(string[,] coordenadasAcumuladas, string[] posicionBarcos, int crearTabla)
        {
            string[,] coordenadas = new string[1, 6];

            for (int i = 0; i < 1; i++)
            {
                for (int n = 0; n < 6; n++)
                {
                    switch (i)
                    {
                        case 0:
                            coordenadas[i, n] = "A" + n;
                            break;
                        case 1:
                            coordenadas[i, n] = "B" + n;
                            break;
                        default:
                            Console.WriteLine("Error: error al asignar coordenadas");
                            break;
                    }

                    for (int a = 0; a < 1; a++)
                    {
                        for (int b = 0; b < 6; b++)
                        {
                            if (coordenadas[i, n] == coordenadasAcumuladas[a, b])
                            {

                                coordenadas[i, n] = "\x1A\x6A";

                                if (coordenadasAcumuladas[a, b] == posicionBarcos[0] )
                                {
                                    coordenadas[i, n] = "XX";
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < 1; i++)
            {
                for (int n = 0; n < 6; n++)
                {
                    if (crearTabla == 1)
                    {
                        Console.Write("|" + coordenadas[i, n] + "|");
                    }
                    else
                    {
                        Console.Write("|" + coordenadas[i, n] + "|");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
