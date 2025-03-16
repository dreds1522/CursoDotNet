using Microsoft.VisualBasic;

Console.WriteLine("## Conversão de tipos ##\n");

int varInt = 100;
double varDouble = varInt;

//byte -> 1 byte
//short -> 2 bytes
//int -> 4 bytes
//long -> 8 bytes
//float -> 4 bytes
//double -> 8 bytes
//decimal -> 16 bytes

//Conversão implicita - Quando é realizado automaticamente pelo compilador do menor ao maior valor
int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

Console.WriteLine("---------------------------");


// Conversão explicita - Precisa ser realizado manualmente
double vardouble = 12.456; //8 bytes
int varInt2 = (int)vardouble; //4 bytes (perda de precisão)

Console.WriteLine(varInt2);


Console.ReadLine();
