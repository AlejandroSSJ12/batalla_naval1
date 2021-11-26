using System;


namespace NavalBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] posBarco1 = new string[3];
            string[] posBarco2 = new string[3];

            string[,] coordenadaJugador1 = new string[1, 6];

            string[,] coordenadaJugador2 = new string[1, 6];

            for (int i = 0; i < 1; i++)
            {
                for (int n = 0; n < 6; n++)
                {
                    coordenadaJugador1[i, n] = "";
                    coordenadaJugador2[i, n] = "";
                }
            }

            

            mostrarCoordenadas(coordenadaJugador1, posBarco2, 1);
            Console.WriteLine("Hola a el juego Batalla Naval. \nRecuerda que este es un juego de coordenadas y el tablero solo sera de 1*6");
            Console.WriteLine("JUGADOR 1");
            Console.WriteLine("Escriba la posicion de sus barcos");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Barco " + (i + 1) + ": ");
                posBarco1[i] = Console.ReadLine();
                posBarco1[i] = posBarco1[i].ToUpper();
            }

            Console.Clear();

            mostrarCoordenadas(coordenadaJugador2, posBarco1, 2);
            Console.WriteLine("Hola a el juego Batalla Naval. \nRecuerda que este es un juego de coordenadas y el tablero solo sera de 1*6");
            Console.WriteLine("JUGADOR 2");
            Console.WriteLine("Escriba la posicion de sus barcos");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Barco " + (i + 1) + ": ");
                posBarco2[i] = Console.ReadLine();
                posBarco2[i] = posBarco2[i].ToUpper();
            }

            Console.Clear();

            int vidas1 = 3;
            int vidas2 = 3;

            for (int i = 0; i < 1; i++)
            {
                for (int n = 0; n < 6; n++)
                {
                    mostrarCoordenadas(coordenadaJugador1, posBarco2, 1);
                    Console.WriteLine("JUGADOR 1");
                    Console.Write("Escoja una coordenada: o");
                    
                    coordenadaJugador1[i, n] = Console.ReadLine();
                    coordenadaJugador1[i, n] = coordenadaJugador1[i, n].ToUpper();
                    Console.WriteLine("Cuando escribas tu coordenada presiona ENTER");
                    for (int a = 0; a < 3; a++)
                    {
                        if (posBarco1[a] == coordenadaJugador1[i, n])
                        {
                            Console.WriteLine("Le diste a un barco");
                            vidas2 = vidas2 - 1;
                            Console.ReadKey();
                        }
                    }

                    Console.Clear();
                    if (vidas2 == 0)
                    {
                        Console.WriteLine("JUGADOR 1 GANO");
                        Console.ReadKey();
                        return;
                    }
                    mostrarCoordenadas(coordenadaJugador2, posBarco1, 2);
                    Console.WriteLine("JUGADOR 2");
                    Console.Write("Escoja una coordenada: \nRecuerda poner letra y numero");
                    coordenadaJugador2[i, n] = Console.ReadLine();
                    coordenadaJugador2[i, n] = coordenadaJugador2[i, n].ToUpper();
                    Console.WriteLine("Cuando escribas tu coordenada presiona ENTER");
                    for (int a = 0; a < 3; a++)
                    {
                        if (posBarco1[a] == coordenadaJugador2[i, n])
                        {
                            Console.WriteLine("Le diste a un barco");
                            vidas1 = vidas1 - 1;
                            Console.ReadKey();
                        }
                    }
                    Console.Clear();

                    if (vidas1 == 0)
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
