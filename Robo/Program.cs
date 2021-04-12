using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo
{
    class Program
    {
        static void Main(string[] args)
        {

            string comando = " ";
            double X = 0, Y = 0, x = 0, y = 0;
            char[] mychars = { ',', ' ', '.', '-', '_' };

                Console.WriteLine("================================== Robô Tupiniquim =====================================");
                
                Console.WriteLine(" \nInforme as coordenadas (X e Y respectivamente) do canto superior direito da área desejada: ");

                string cantoSupDir = Console.ReadLine();

                string[] cordenadasTotal = cantoSupDir.Split(mychars);

                x = Convert.ToDouble(cordenadasTotal[0]);
                y = Convert.ToDouble(cordenadasTotal[1]);

                while (true)
                {
                Console.Write("\nInforme as coordenadas (X e Y respectivamente) da posição inicial do robô e para onde sua face está virada (N, S, L, O): ");

                string coordenadasFace = Console.ReadLine();

                string[] names = coordenadasFace.Split(mychars);

                X = Convert.ToDouble(names[0]);
                Y = Convert.ToDouble(names[1]);

                if (names[2] != "N" && names[2] != "n" && names[2] != "S" && names[2] != "s" && names[2] != "O" && names[2] != "o" && names[2] != "L" && names[2] != "l")
                {
                    Console.WriteLine("Caracter: " + names[2] + " não aceito, tente novamente");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else
                {
                    if (x < X || y < Y || X<0 || Y<0)
                    {
                        Console.WriteLine("\nSeu robô está fora da área permitida, tente novamente");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nInforme os comandos para mexer o seu robo: ");

                        comando = Console.ReadLine();
                        char[] array = comando.ToCharArray();

                        string direcao = names[2];

                        if (direcao == "N" || direcao == "n")
                        {
                            direcao = "N";
                        }
                        if (direcao == "S" || direcao == "s")
                        {
                            direcao = "S";
                        }
                        if (direcao == "L" || direcao == "l")
                        {
                            direcao = "L";
                        }
                        if (direcao == "O" || direcao == "o")
                        {
                            direcao = "O";
                        }




                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i].Equals('m') || array[i].Equals('M'))
                            {
                                if (direcao == "N")
                                {
                                    Y = Y + 1;
                                }
                                else if (direcao == "S")
                                {
                                    Y = Y - 1;
                                }
                                else if (direcao == "L")
                                {
                                    X = X + 1;
                                }
                                else if (direcao == "O")
                                {
                                    X = X - 1;
                                }
                            }
                            else if (array[i].Equals('e') || array[i].Equals('E'))
                            {
                                if (direcao == "N")
                                {
                                    direcao = "O";
                                }
                                else if (direcao == "S")
                                {
                                    direcao = "L";
                                }
                                else if (direcao == "L")
                                {
                                    direcao = "N";
                                }
                                else if (direcao == "O")
                                {
                                    direcao = "S";
                                }
                            }
                            else if (array[i].Equals('d') || array[i].Equals('D'))
                            {
                                if (direcao == "N")
                                {
                                    direcao = "L";
                                }
                                else if (direcao == "S")
                                {
                                    direcao = "O";
                                }
                                else if (direcao == "L")
                                {
                                    direcao = "S";
                                }
                                else if (direcao == "O")
                                {
                                    direcao = "N";
                                }
                            }

                        }
                            if (x < X || y < Y || X<0 || Y<0)
                            {
                                Console.WriteLine("\nSeu robô saiu da área permitida, tente novamente");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nA posição final do seu Robô é (" + X + ", " + Y + ") " + direcao);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            Console.WriteLine("\nDeseja acionar mais 1 robo? (1-sim 2-não): ");

                            double maisRobo = Convert.ToDouble(Console.ReadLine());

                            if (maisRobo == 1)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        
                    }
                }
            }
        }
    }
}
