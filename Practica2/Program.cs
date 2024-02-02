// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Reflection.Emit;


int[] numeros = new int[5];
numeros[0] = 10;
numeros[1] = 15;
numeros[2] = 3;
numeros[3] = 1;
numeros[4] = 2;

string[] nombres = { "Carlos", "Sofia", "Laura" };
//                      0          1       2

/*
 * > mayor que
 * < menor que
 * >= mayor o igual que
 * <= menor o igual que
 * != diferente a
 * 
 */
//for (int i = 2; i>= 0; i--)  // 2 true 1 sofia 
//{
//    Console.WriteLine(nombres[i]);
//}

int[,] matriz = new int[3, 3];
int contador = 1;
int sumatoria = 0;

//  Asignarle un valor a la matriz
for (int f = 0; f<3; f++)  // filas
{
    for (int c = 0; c<3; c++) // columnas
    {
        matriz[c,f] = contador++;  // acumulador
        
    }
    Console.WriteLine();
}


// ciclo para imprmir la matriz
    for (int f = 0; f < 3; f++)  // filas
    {
        for (int c = 0; c < 3; c++) // columnas
        {
            if (c==f)
            {
                sumatoria = sumatoria + matriz[f, c];
            }

        }
        Console.WriteLine();
    }



for (int f = 0; f < 3; f++)  // filas
{
    for (int c = 0; c < 3; c++) // columnas
    {
        Console.Write($"    {matriz[f,c]}");
    }
    Console.WriteLine();
}

Console.WriteLine($"{sumatoria}");

//Console.WriteLine($"suma de numeros es {numeros.Sum()}");
//Console.WriteLine($"Promedio de los numeros {numeros.Average()}");
//Console.WriteLine($"El maximo es {numeros.Max()}");
//Console.WriteLine($"El maximo es {numeros.Min()}");
//nombres = Enumerable.Repeat("-", 3).ToArray<string>();

numeros = Enumerable.Repeat(0, 5).ToArray<int>();

//for (int i = 0; i < numeros.Length; i++)
//{

//    Console.WriteLine(numeros[i]);
//}


//int indice = 0;
//while (indice < numeros.Length)
//{
//    Console.WriteLine(numeros[indice]);
//    indice++;
//}


//foreach (var numero in numeros)
//{
//    Console.WriteLine(numero);
//}

