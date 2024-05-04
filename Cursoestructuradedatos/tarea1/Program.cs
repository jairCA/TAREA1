 //EJERCICIO 01 
// Solicitar al usuario que ingrese dos números
Console.WriteLine("Ingrese el primer número:");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
double n2 = Convert.ToDouble(Console.ReadLine());

// Realizar las operaciones
double suma = n1 + n2;
double resta = n1 - n2;
double multiplicacion = n1 * n2;
double division = n1 / n2;

// Mostrar los resultados
Console.WriteLine($"La suma de {n1} y {n2} es: {suma}");
Console.WriteLine($"La resta de {n1} y {n2} es: {resta}");
Console.WriteLine($"La multiplicación de {n1} y {n2} es: {multiplicacion}");
Console.WriteLine($"La división de {n1} entre {n2} es: {division}");

Console.ReadLine();

 //EJERCICIO 02 
// Solicitar al usuario que ingrese un número
Console.WriteLine("Ingrese un número:");
int numero = Convert.ToInt32(Console.ReadLine());

// Verificar si el número es par o impar
if (numero % 2 == 0)
    Console.WriteLine($"{numero} es un número par.");
else
    Console.WriteLine($"{numero} es un número impar.");

Console.ReadLine();


 //EJERCICIO 03
// Solicitar al usuario que ingrese la base del triángulo
Console.WriteLine("Ingrese la base del triángulo:");
double baseTriangulo = Convert.ToDouble(Console.ReadLine());

// Solicitar al usuario que ingrese la altura del triángulo
Console.WriteLine("Ingrese la altura del triángulo:");
double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

// Calcular el área del triángulo
double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

// Mostrar el resultado
Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {alturaTriangulo} es: {areaTriangulo}");

Console.ReadLine();

 //EJERCICIO 04
using System;
class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número
        Console.WriteLine("Ingrese un número para calcular su factorial:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Calcular el factorial del número ingresado
        long factorial = CalcularFactorial(numero);

        // Mostrar el resultado
        Console.WriteLine($"El factorial de {numero} es: {factorial}");

        Console.ReadLine();
    }

    // Función para calcular el factorial de un número
    static long CalcularFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}

//EJERCICIO 05
using System;
class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número
        Console.WriteLine("Ingrese un número para verificar si es primo:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Verificar si el número es primo
        bool esPrimo = VerificarPrimo(numero);

        // Mostrar el resultado
        if (esPrimo)
        {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número primo.");
        }

        Console.ReadLine();
    }

    // Función para verificar si un número es primo
    static bool VerificarPrimo(int n)
    {
        // Si el número es 1 o menor, no es primo
        if (n <= 1)
        {
            return false;
        }

        // Verificar divisibilidad por números menores que el número mismo
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false; // Si es divisible por otro número que no sea 1 o sí mismo, no es primo
            }
        }

        return true; // Si no es divisible por ningún número excepto 1 y él mismo, es primo
    }
}


//EJERCICIO 06 
class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese una cadena de texto
        Console.WriteLine("Ingrese una cadena de texto:");
        string texto = Console.ReadLine();

        // Invertir la cadena de texto
        string textoInvertido = InvertirCadena(texto);

        // Mostrar el resultado
        Console.WriteLine($"La cadena invertida es: {textoInvertido}");

        Console.ReadLine();
    }

    // Función para invertir una cadena de texto
    static string InvertirCadena(string cadena)
    {
        char[] caracteres = cadena.ToCharArray(); // Convertir la cadena en un arreglo de caracteres
        Array.Reverse(caracteres); // Invertir el arreglo de caracteres
        return new string(caracteres); // Convertir el arreglo invertido de caracteres de nuevo a cadena
    }
}

//EJERCICIO 07
class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario el inicio del rango
        Console.WriteLine("Ingrese el número inicial del rango:");
        int inicio = Convert.ToInt32(Console.ReadLine());

        // Solicitar al usuario el final del rango
        Console.WriteLine("Ingrese el número final del rango:");
        int fin = Convert.ToInt32(Console.ReadLine());

        // Calcular la suma de los números pares en el rango especificado
        int sumaPares = CalcularSumaPares(inicio, fin);

        // Mostrar el resultado
        Console.WriteLine($"La suma de los números pares en el rango [{inicio}, {fin}] es: {sumaPares}");

        Console.ReadLine();
    }

    // Función para calcular la suma de los números pares en un rango
    static int CalcularSumaPares(int inicio, int fin)
    {
        int suma = 0;
        // Iterar a través del rango y sumar los números pares
        for (int i = inicio; i <= fin; i++)
        {
            if (i % 2 == 0) // Si el número es par
            {
                suma += i; // Sumarlo
            }
        }
        return suma;
    }
}


// EJERCICIO 08 
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista para almacenar los cuadrados
        List<int> cuadrados = new List<int>();

        // Calcular y agregar los cuadrados de los primeros 10 números naturales
        for (int i = 1; i <= 10; i++)
        {
            cuadrados.Add(i * i);
        }

        // Mostrar los cuadrados
        Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
        foreach (int cuadrado in cuadrados)
        {
            Console.WriteLine(cuadrado);
        }

        Console.ReadLine();
    }
}


// EJERCICIO 09 
class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese una cadena de texto
        Console.WriteLine("Ingrese una cadena de texto:");
        string texto = Console.ReadLine();

        // Contar el número de vocales en la cadena de texto
        int contadorVocales = ContarVocales(texto);

        // Mostrar el resultado
        Console.WriteLine($"El número de vocales en la cadena es: {contadorVocales}");

        Console.ReadLine();
    }

    // Función para contar el número de vocales en una cadena de texto
    static int ContarVocales(string cadena)
    {
        // Convertir la cadena a minúsculas para simplificar el conteo
        cadena = cadena.ToLower();

        int contador = 0;

        // Iterar sobre cada caracter de la cadena y verificar si es una vocal
        foreach (char caracter in cadena)
        {
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                contador++;
            }
        }

        return contador;
    }
}


//EJERCICIO 10 
class Program
{
    static void Main(string[] args)
    {
        // Generar los primeros 10 números de la serie Fibonacci
        int[] fibonacci = GenerarFibonacci(10);

        // Mostrar los números de la serie Fibonacci
        Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
        foreach (int numero in fibonacci)
        {
            Console.WriteLine(numero);
        }

        Console.ReadLine();
    }

    // Función para generar los primeros n números de la serie Fibonacci
    static int[] GenerarFibonacci(int n)
    {
        int[] fibonacci = new int[n];

        if (n >= 1)
        {
            fibonacci[0] = 0;
        }
        if (n >= 2)
        {
            fibonacci[1] = 1;
        }

        // Calcular los siguientes números de la serie Fibonacci
        for (int i = 2; i < n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        return fibonacci;
    }
}


// EJERCICIO 11 
class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese los números separados por comas
        Console.WriteLine("Ingrese una lista de números separados por comas:");
        string entrada = Console.ReadLine();

        // Dividir la entrada en una matriz de cadenas
        string[] numerosComoCadena = entrada.Split(',');

        // Convertir las cadenas a números enteros
        int[] numeros = new int[numerosComoCadena.Length];
        for (int i = 0; i < numerosComoCadena.Length; i++)
        {
            numeros[i] = Convert.ToInt32(numerosComoCadena[i]);
        }

        // Ordenar la lista de números de menor a mayor
        Array.Sort(numeros);

        // Mostrar los números ordenados
        Console.WriteLine("Lista de números ordenados de menor a mayor:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.ReadLine();
    }
}

// EJERCICIO 12 
class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese una palabra
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine().ToLower(); // Convertir la palabra a minúsculas para ignorar diferencias de caso

        // Verificar si la palabra es un palíndromo
        bool esPalindromo = EsPalindromo(palabra);

        // Mostrar el resultado
        if (esPalindromo)
        {
            Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
        }

        Console.ReadLine();
    }

    // Función para verificar si una palabra es un palíndromo
    static bool EsPalindromo(string palabra)
    {
        // Comparar la palabra original con su versión invertida
        int inicio = 0;
        int fin = palabra.Length - 1;
        while (inicio < fin)
        {
            if (palabra[inicio] != palabra[fin])
            {
                return false; // Si los caracteres no coinciden, la palabra no es un palíndromo
            }
            inicio++;
            fin--;
        }
        return true; // Si todos los caracteres coinciden, la palabra es un palíndromo
    }
}


//EJERCICIO 13
class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número
        Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Generar la tabla de multiplicar del número ingresado
        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }

        Console.ReadLine();
    }
}

//EJERCICIO 14
class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese el radio del círculo
        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Calcular el área del círculo
        double area = CalcularAreaCirculo(radio);

        // Mostrar el resultado
        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");

        Console.ReadLine();
    }

    // Función para calcular el área del círculo
    static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * radio * radio; // Utilizando la fórmula: π * r^2
    }
}

//EJERCICIO 15 
class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número entero
        Console.WriteLine("Ingrese un número entero:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Calcular la suma de los dígitos del número
        int sumaDigitos = CalcularSumaDigitos(numero);

        // Mostrar el resultado
        Console.WriteLine($"La suma de los dígitos de {numero} es: {sumaDigitos}");

        Console.ReadLine();
    }

    // Función para calcular la suma de los dígitos de un número entero
    static int CalcularSumaDigitos(int numero)
    {
        int suma = 0;

        // Iterar sobre cada dígito del número
        while (numero != 0)
        {
            int digito = numero % 10; // Obtener el último dígito
            suma += digito; // Sumar el dígito al total
            numero /= 10; // Eliminar el último dígito
        }

        return suma;
    }
}
