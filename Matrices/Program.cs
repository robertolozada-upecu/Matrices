using System;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[,] LeerMatrices(int filaMatriz, int columnaMatriz)
			{
				Console.Clear();
				Console.WriteLine("Ingrese los valores de la Matriz");
				int[,] matriz = new int[filaMatriz,columnaMatriz];
				for (int i = 0; i < filaMatriz; i++)
				{
                    for (int j = 0; j < columnaMatriz; j++)
                    {
						Console.Write("Ingrese el valor (" + (i + 1) + "," + (j + 1) + "): ");
						matriz[i,j] = int.Parse(Console.ReadLine());
					}
				}
				return matriz;

			}
			void ImprimirMatrices(int[,] matriz, int filaMatriz, int columnaMatriz)
            {
				for(int i = 0; i < filaMatriz; i++)
                {
					for(int j= 0; j < columnaMatriz; j++)
                    {
						Console.Write(matriz[i, j]);
						if (j < columnaMatriz - 1)
							Console.Write("\t");
                    }
					Console.WriteLine();
                }
            }
			
			string opcionMenu;
			do
			{
				Console.Clear();
				Console.WriteLine("--------------------------------------------------");
				Console.WriteLine("------------- Ejercicios con Matrices ------------");
				Console.WriteLine("--------------------------------------------------");
				Console.WriteLine("Menú de opciones:");
				Console.WriteLine("1. Suma");
				Console.WriteLine("2. Resta");
				Console.WriteLine("3. Multiplicación");
				Console.WriteLine("4. Salir");
				// ingresar una opcion
				Console.Write("Elija una opción (1-4): ");
				opcionMenu = Console.ReadLine();
				int filaMatriz, columnaMatriz, columnaMatrizB;
				int[,] matrizA, matrizB;
				// procesar esa opción
				switch (opcionMenu)
				{
					case "1":
						Console.WriteLine();
						Console.WriteLine("Ingrese la dimensión de las matrices");
						Console.Write("Ingrese el número de filas: ");
						filaMatriz = int.Parse(Console.ReadLine());
						Console.Write("Ingrese el número de columnas: ");
						columnaMatriz = int.Parse(Console.ReadLine());
						matrizA = LeerMatrices(filaMatriz, columnaMatriz);
						matrizB = LeerMatrices(filaMatriz, columnaMatriz);
						int[,] matrizResultadoSuma = new int[filaMatriz, columnaMatriz];
						for (int i = 0; i < filaMatriz; i++)
						{
							for (int j = 0; j < columnaMatriz; j++)
							{
								matrizResultadoSuma[i, j] = matrizA[i, j] + matrizB[i, j];
							}
						}
						Console.WriteLine();
						Console.WriteLine("Matriz A");
						ImprimirMatrices(matrizA, filaMatriz, columnaMatriz);
						Console.WriteLine();
						Console.WriteLine("Matriz B");
						ImprimirMatrices(matrizB, filaMatriz, columnaMatriz);
						Console.WriteLine();
						Console.WriteLine("Matriz A+B");
						ImprimirMatrices(matrizResultadoSuma, filaMatriz, columnaMatriz);
						break;
					case "2":
						Console.WriteLine();
						Console.WriteLine("Ingrese la dimensión de las matrices");
						Console.Write("Ingrese el número de filas: ");
						filaMatriz = int.Parse(Console.ReadLine());
						Console.Write("Ingrese el número de columnas: ");
						columnaMatriz = int.Parse(Console.ReadLine());
						matrizA = LeerMatrices(filaMatriz, columnaMatriz);
						matrizB = LeerMatrices(filaMatriz, columnaMatriz);
						int[,] matrizResultadoResta = new int[filaMatriz, columnaMatriz];
						for (int i = 0; i < filaMatriz; i++)
						{
							for (int j = 0; j < columnaMatriz; j++)
							{
								matrizResultadoResta[i, j] = matrizA[i, j] - matrizB[i, j];
							}
						}
						Console.WriteLine();
						Console.WriteLine("Matriz A");
						ImprimirMatrices(matrizA, filaMatriz, columnaMatriz);
						Console.WriteLine();
						Console.WriteLine("Matriz B");
						ImprimirMatrices(matrizB, filaMatriz, columnaMatriz);
						Console.WriteLine();
						Console.WriteLine("Matriz A-B");
						ImprimirMatrices(matrizResultadoResta, filaMatriz, columnaMatriz);
						break;
					case "3":
						Console.WriteLine();
						Console.WriteLine("Ingrese la dimensión de la primera matriz");
						Console.Write("Ingrese el número de filas: ");
						filaMatriz = int.Parse(Console.ReadLine());
						Console.Write("Ingrese el número de columnas: ");
						columnaMatriz = int.Parse(Console.ReadLine());
						Console.Write("Ingrese el número de columnas de la segunda matriz: ");
						columnaMatrizB = int.Parse(Console.ReadLine());
						matrizA = LeerMatrices(filaMatriz, columnaMatriz);
						matrizB = LeerMatrices(filaMatriz, columnaMatrizB);
						int[,] matrizResultadoMultiplicacion = new int[filaMatriz, columnaMatrizB];
						int totalAux;
						for (int i = 0; i < filaMatriz; i++)
						{
							for (int j = 0; j < columnaMatrizB; j++)
							{
								totalAux = 0;
								for(int k=0; k < columnaMatriz; k++)
                                {
									totalAux += matrizA[i, k] * matrizB[k, j];
								}
								matrizResultadoMultiplicacion[i, j] = totalAux;
							}
						}
						Console.WriteLine();
						Console.WriteLine("Matriz A");
						ImprimirMatrices(matrizA, filaMatriz, columnaMatriz);
						Console.WriteLine();
						Console.WriteLine("Matriz B");
						ImprimirMatrices(matrizB, filaMatriz, columnaMatrizB);
						Console.WriteLine();
						Console.WriteLine("Matriz A*B");
						ImprimirMatrices(matrizResultadoMultiplicacion, filaMatriz, columnaMatrizB);
						break;
					case "4":
						Console.WriteLine();
						Console.WriteLine("Gracias, vuelva pronto!");
						break;
					default:
						Console.WriteLine();
						Console.WriteLine("Opción no válida!");
						break;
				}
				Console.WriteLine();
				Console.Write("Presione enter para continuar ");
				Console.ReadKey();
			} while (opcionMenu != "4");
		}
    }
}
