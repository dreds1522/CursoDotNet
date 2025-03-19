Console.WriteLine("## Inferencia de tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

//Var limitações:
//var x; //Erro: Não é possível declarar uma variável var sem inicializá-la
//x = 10; //Erro: Não é possível atribuir um valor de outro tipo a uma variável var
//var y = null; //Erro: Não é possível atribuir null a uma variável var sem inicializá-la
//var z = 10, w = 20; //Erro: Não é possível declarar várias variáveis na mesma linha
//var a = 10; a = "Maria"; //Erro: Não é possível atribuir um valor de outro tipo a uma variável var
//var b = 10; b = null; //Erro: Não é possível atribuir null a uma variável var
//var c = 10; c = 10.5; //Erro: Não é possível atribuir um valor de outro tipo a uma variável var



Console.ReadKey();
