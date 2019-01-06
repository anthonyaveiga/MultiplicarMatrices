using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicarMatrices
{
	class Program
	{
		public static void Multiplicar()
		{
			int i, j, k, fila1, colm1, fila2, colm2, sum = 0;

			int[,] a = new int[50, 50];
			int[,] b = new int[50, 50];
			int[,] c = new int[50, 50];

			Console.Write("\nIngrese numero de filas y columnas de la primera matriz\n");
			Console.Write("Filas : ");
			fila1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Columnas : ");
			colm1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("\nIngrese numero de filas y columnas de la segunda matriz\n");
			Console.Write("Filas : ");
			fila2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Columnas : ");
			colm2 = Convert.ToInt32(Console.ReadLine());

			if (colm1 != fila2)
			{
				Console.Write("No se puede realizar la multiplicacion");
				Console.Write("\nEl numero de filas de la primera matriz debe ser igual al de columnas de la segunda matriz\n");
			}
			else
			{
				Console.Write("\nIngrese los elementos de la primera matiz\n");
				for (i = 0; i < fila1; i++)
				{
					for (j = 0; j < colm1; j++)
					{
						Console.Write("Ingrese posicion ({0} , {1}) : ", i + 1, j + 1);
						a[i, j] = Convert.ToInt32(Console.ReadLine());
					}
				}
				Console.Write("\nIngrese los elementos de la segunda matiz\n");
				for (i = 0; i < fila2; i++)
				{
					for (j = 0; j < colm2; j++)
					{
						Console.Write("Ingrese posicion ({0} , {1}) : ", i + 1, j + 1);
						b[i, j] = Convert.ToInt32(Console.ReadLine());
					}
				}
				Console.Write("\nLa primera matriz es:\n");
				for (i = 0; i < fila1; i++)
				{
					Console.Write("\n");
					for (j = 0; j < colm1; j++)
						Console.Write("{0}\t", a[i, j]);
				}

				Console.Write("\n\nLa segunda matriz es:\n");
				for (i = 0; i < fila2; i++)
				{
					Console.Write("\n");
					for (j = 0; j < colm2; j++)
						Console.Write("{0}\t", b[i, j]);
				}

				for (i = 0; i < fila1; i++)
					for (j = 0; j < colm2; j++)
						c[i, j] = 0;
				for (i = 0; i < fila1; i++)
				{
					for (j = 0; j < colm2; j++)
					{
						sum = 0;
						for (k = 0; k < colm1; k++)
							sum = sum + a[i, k] * b[k, j];
						c[i, j] = sum;
					}
				}
				Console.Write("\n\nLa multiplicacion es: \n");
				for (i = 0; i < fila1; i++)
				{
					Console.Write("\n");
					for (j = 0; j < colm2; j++)
					{
						Console.Write("{0}\t", c[i, j]);
					}
				}
			}

			Console.ReadKey();

		}
		static void Main(string[] args)
		{
			Multiplicar();
		}
	}
}
