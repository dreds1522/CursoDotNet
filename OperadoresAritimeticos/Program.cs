﻿Console.WriteLine("## Operadores aritimeticos ##\n");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nRaiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\nPotencia de x elevado a y = {Math.Pow(x, y)}");
Console.WriteLine($"\nValor minimo entre x e y = {Math.Min(x, y)}");
Console.WriteLine($"\nValor maximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"\nCoseno de x = {Math.Cos(x)}");
Console.WriteLine($"\nSeno de x = {Math.Sin(x)}");
Console.WriteLine($"\nExponensial de x = {Math.Exp(x)}");


Console.ReadKey();

//Console.WriteLine($"soma de x+y é igual a {x + y}");
//Console.WriteLine($"subtração de x-y é igual a {x - y}");
//Console.WriteLine($"multipliucação de x*y é igual a {x * y}");
//double divisao = (double)x / y;
//Console.WriteLine($"divisão de x/y é igual a {divisao}");
//Console.WriteLine($"modulo de x%y é igual a {x % y}");