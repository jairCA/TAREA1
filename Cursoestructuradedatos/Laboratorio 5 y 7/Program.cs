
//// ---------------- ***** RECURSIVIDAD ***** ---------------------- //////
//// EJERCICIO 01
//using System.Numerics;

//class Program
//{
//    static void Main(String[] args)
//    {
//        int contador = 1;
//        while (contador <= 100)
//        {
//            if (contador % 2 == 0)
//            {
//                Console.WriteLine(contador);
//            }
//            contador++;
//        }
//    }
//}

//  EJERCICIO 02 
//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 10; // Cambia el valor de n según necesites
//        Console.WriteLine($"La suma de los números del 1 al {n} es: {SumOfNumbers(n)}");
//    }

//    static int SumOfNumbers(int n)
//    {
//        if (n == 1)
//        {
//            return 1; // Caso base: si n es 1, devuelve 1
//        }
//        else
//        {
//            return n + SumOfNumbers(n - 1); // Llamada recursiva con n-1 y se suma con n
//        }
//    }
//}

//EJERCICIO 03
//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 5; // Cambia el valor de n según necesites
//        PrintNumberPyramid(n);
//    }

//    static void PrintNumberPyramid(int n, int row = 1)
//    {
//        if (row > n)
//        {
//            return; // Si la fila actual supera el número n, termina la recursión
//        }

//        Imprime los números de la fila actual
//        for (int i = 1; i <= row; i++)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine(); // Salto de línea después de imprimir la fila

//        Llamada recursiva para imprimir la siguiente fila
//        PrintNumberPyramid(n, row + 1);
//    }
//}

////  EJERCICIO 04 
//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 5; // Cambia el valor de n según necesites
//        PrintInvertedNumberPyramid(n);
//    }

//    static void PrintInvertedNumberPyramid(int n, int row = 1)
//    {
//        if (row > n)
//        {
//            return; // Si la fila actual supera el número n, termina la recursión
//        }

//        // Imprime los espacios en blanco para la alineación
//        for (int i = 0; i < n - row; i++)
//        {
//            Console.Write(" ");
//        }

//        // Imprime los números de la fila actual en orden inverso
//        for (int i = row; i >= 1; i--)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine(); // Salto de línea después de imprimir la fila

//        // Llamada recursiva para imprimir la siguiente fila
//        PrintInvertedNumberPyramid(n, row + 1);
//    }
//}

//// EJERCICIO 05
//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 5; // Cambia el valor de n según necesites
//        PrintMultiplicationTable(n);
//    }

//    static void PrintMultiplicationTable(int n, int multiplier = 1)
//    {
//        if (multiplier > 10)
//        {
//            return; // Termina la recursión cuando el multiplicador supera 10
//        }

//        Console.WriteLine($"{n} x {multiplier} = {n * multiplier}");

//        // Llamada recursiva para imprimir la siguiente fila de la tabla
//        PrintMultiplicationTable(n, multiplier + 1);
//    }
//}

//// ---------------- ***** ARREGLOS Y MATRICES ***** ---------------------- //////
//// EJERCICIO 06
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Definir una matriz de tamaño 3x3 de números reales
//        double[,] matriz = new double[3, 3];

//        // Asignar valores a la matriz
//        matriz[0, 0] = 1.1;
//        matriz[0, 1] = 2.2;
//        matriz[0, 2] = 3.3;
//        matriz[1, 0] = 4.4;
//        matriz[1, 1] = 5.5;
//        matriz[1, 2] = 6.6;
//        matriz[2, 0] = 7.7;
//        matriz[2, 1] = 8.8;
//        matriz[2, 2] = 9.9;

//        // Imprimir la matriz
//        Console.WriteLine("Matriz de números reales:");
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write(matriz[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////  EJERCICIO 07 
//using System.Numerics; // Necesario para números complejos

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Definir una matriz de tamaño 2x2 de números complejos
//        Complex[,] matriz = new Complex[2, 2];

//        // Asignar valores a la matriz
//        matriz[0, 0] = new Complex(1, 2); // 1 + 2i
//        matriz[0, 1] = new Complex(3, 4); // 3 + 4i
//        matriz[1, 0] = new Complex(5, 6); // 5 + 6i
//        matriz[1, 1] = new Complex(7, 8); // 7 + 8i

//        // Imprimir la matriz
//        Console.WriteLine("Matriz de números complejos:");
//        for (int i = 0; i < 2; i++)
//        {
//            for (int j = 0; j < 2; j++)
//            {
//                Console.Write(matriz[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////EJERCICIO 08 
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Definir una matriz de matrices (arreglos)
//        int[][] matrizDeMatrices = new int[3][];

//        // Inicializar cada fila de la matriz con un arreglo diferente
//        matrizDeMatrices[0] = new int[] { 1, 2, 3 };
//        matrizDeMatrices[1] = new int[] { 4, 5, 6, 7 };
//        matrizDeMatrices[2] = new int[] { 8, 9 };

//        // Imprimir la matriz de matrices
//        Console.WriteLine("Matriz de matrices:");
//        for (int i = 0; i < matrizDeMatrices.Length; i++)
//        {
//            Console.Write("[ ");
//            for (int j = 0; j < matrizDeMatrices[i].Length; j++)
//            {
//                Console.Write(matrizDeMatrices[i][j] + " ");
//            }
//            Console.WriteLine("]");
//        }
//    }
//}

////  EJERCICIO 09
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] matriz = new int[,] {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        // Coordenadas del elemento central
//        int filaCentral = filas / 2;
//        int columnaCentral = columnas / 2;

//        // Acceder al elemento central
//        int elementoCentral = matriz[filaCentral, columnaCentral];

//        Console.WriteLine("El elemento central de la matriz es: " + elementoCentral);
//    }
//}

//// EJERCICIO 10 
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] matrizA = {
//            {1, 2, 3},
//            {4, 5, 6}
//        };

//        int[,] matrizB = {
//            {7, 8},
//            {9, 10},
//            {11, 12}
//        };

//        int[,] resultado = SumarMatrices(matrizA, matrizB);

//        // Imprimir el resultado
//        Console.WriteLine("Resultado de la suma de las matrices:");
//        ImprimirMatriz(resultado);
//    }

//    static int[,] SumarMatrices(int[,] matrizA, int[,] matrizB)
//    {
//        int filasA = matrizA.GetLength(0);
//        int columnasA = matrizA.GetLength(1);
//        int filasB = matrizB.GetLength(0);
//        int columnasB = matrizB.GetLength(1);

//        int filasComunes = Math.Min(filasA, filasB);
//        int columnasComunes = Math.Min(columnasA, columnasB);

//        int[,] resultado = new int[filasComunes, columnasComunes];

//        for (int i = 0; i < filasComunes; i++)
//        {
//            for (int j = 0; j < columnasComunes; j++)
//            {
//                resultado[i, j] = matrizA[i, j] + matrizB[i, j];
//            }
//        }

//        return resultado;
//    }

//    static void ImprimirMatriz(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(matriz[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////  EJERCICIO 11 
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] matriz = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        int numero = 2; // El número por el cual se multiplicará la matriz

//        int[,] resultado = MultiplicarMatrizPorNumero(matriz, numero);

//        // Imprimir el resultado
//        Console.WriteLine("Resultado de la multiplicación de la matriz por el número:");
//        ImprimirMatriz(resultado);
//    }

//    static int[,] MultiplicarMatrizPorNumero(int[,] matriz, int numero)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        int[,] resultado = new int[filas, columnas];

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                resultado[i, j] = matriz[i, j] * numero;
//            }
//        }

//        return resultado;
//    }

//    static void ImprimirMatriz(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(matriz[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////EJERCICIO 12 
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] matriz = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        double media = CalcularMediaMatriz(matriz);

//        Imprimir la media
//        Console.WriteLine("La media de los elementos de la matriz es: " + media);
//    }

//    static double CalcularMediaMatriz(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        int sumaTotal = 0;
//        int totalElementos = filas * columnas;

//        Sumar todos los elementos de la matriz
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                sumaTotal += matriz[i, j];
//            }
//        }

//        Calcular la media
//        double media = (double)sumaTotal / totalElementos;
//        return media;
//    }
//}


//// ----------------***** MATRICES ***** ---------------------- //////
// EJERCICIO 01
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear una matriz de tamaño 100x100
//        int[,] matriz = new int[100, 100];

//        // Crear una instancia de Random para generar números aleatorios
//        Random rand = new Random();

//        // Llenar la matriz con números aleatorios
//        for (int i = 0; i < 100; i++)
//        {
//            for (int j = 0; j < 100; j++)
//            {
//                matriz[i, j] = rand.Next(1, 101); // Números aleatorios entre 1 y 100
//            }
//        }

//        // Imprimir algunos elementos para verificar
//        Console.WriteLine("Algunos elementos de la matriz:");
//        Console.WriteLine("Matriz[0,0]: " + matriz[0, 0]);
//        Console.WriteLine("Matriz[50,50]: " + matriz[50, 50]);
//        Console.WriteLine("Matriz[99,99]: " + matriz[99, 99]);
//    }
//}

//eJERCICIO 03 
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear una matriz de ejemplo
//        int[,] matriz = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        // Encontrar el elemento máximo
//        int maximo = EncontrarElementoMaximo(matriz);

//        // Imprimir el resultado
//        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
//    }

//    static int EncontrarElementoMaximo(int[,] matriz)
//    {
//        int maximo = matriz[0, 0]; // Asignar el primer elemento como máximo

//        // Iterar sobre cada elemento de la matriz y actualizar el máximo si es necesario
//        foreach (int elemento in matriz)
//        {
//            if (elemento > maximo)
//            {
//                maximo = elemento;
//            }
//        }

//        return maximo;
//    }
//}

