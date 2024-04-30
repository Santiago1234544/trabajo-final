class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa de multiplicación de matrices 4x4");

        int[,] matriz1 = new int[4, 4];
        int[,] matriz2 = new int[4, 4];
        int[,] resultado = new int[4, 4];

        int multiplicacionesRealizadas = 0;

        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nIngrese los elementos de la primera matriz:");
            CapturarMatriz(matriz1);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nIngrese los elementos de la segunda matriz:");
            CapturarMatriz(matriz2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMatriz 1:");
            MostrarMatriz(matriz1);
            Console.WriteLine("\nMatriz 2:");
            MostrarMatriz(matriz2);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nResultado de la multiplicación:");
            MultiplicarMatrices(matriz1, matriz2, resultado);
            MostrarMatriz(resultado);

            multiplicacionesRealizadas++;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n¿Desea realizar otra multiplicación de matrices? (s/n): ");
        } while (Console.ReadLine().ToLower() == "s");

        Console.WriteLine($"\nSe realizaron un total de {multiplicacionesRealizadas} multiplicaciones de matrices.");
    }

    static void CapturarMatriz(int[,] matriz)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void MultiplicarMatrices(int[,] matriz1, int[,] matriz2, int[,] resultado)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                resultado[i, j] = 0;
                for (int k = 0; k < 4; k++)
                {
                    resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                }
            }
        }
    }

    static void MostrarMatriz(int[,] matriz)
    {
        Console.WriteLine("+----+----+----+----+");

        for (int i = 0; i < 4; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matriz[i, j] + " | ");
            }
            Console.WriteLine();
            Console.WriteLine("+----+----+----+----+");
        }
    }
}