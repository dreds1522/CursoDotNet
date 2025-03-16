Console.WriteLine("Saida de Dados : Formatação ");
Console.WriteLine();

int idade = 25;
string nome = "Maria";

Console.WriteLine(nome);
Console.WriteLine(idade);

//Escrever na mesma linha: 'Maria tem 25 anos.'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos.");
Console.WriteLine();
Console.WriteLine("--------------------------");

//Usando concatenação : usando o operador +
Console.WriteLine(nome + " tem " + idade + " anos.");
Console.Write(nome + " tem " + idade + " anos.");
Console.WriteLine();
Console.WriteLine("--------------------------");


//Usando interpolação de strings ; $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos.");
Console.WriteLine();
Console.WriteLine("--------------------------");

//Usando place holders : usa {} com numeração com inicio zero
Console.WriteLine("{0} tem {1} anos.", nome, idade);


Console.ReadLine();
