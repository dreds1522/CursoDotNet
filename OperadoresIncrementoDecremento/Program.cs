Console.WriteLine("## Operadores incremento e decremento ##\n");

//int x = 10;
//x++; //x = x + 1;
//Console.WriteLine(x);

int x = 0;
Console.WriteLine($"x = {x}"); //Imprime 0

//Pós incremento -> Primeiro resolve depois incrementa
int resultado1 = x++ + 10;
Console.WriteLine($"pós-incremento ==> {resultado1}");
Console.WriteLine($"valor de x ==> {x}\n");

//Pré incremento -> Primeiro incrementa depois resolve
int y = 0;
Console.WriteLine($"y = {y}");
int resultado2 = ++y + 10;
Console.WriteLine($"pré-incremento ==> {resultado2}");
Console.WriteLine($"valor de y ==> {y}\n");

Console.ReadKey();  
