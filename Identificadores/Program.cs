Console.WriteLine("Definindo identificadores");
Console.WriteLine();

//Identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//Identificadores invalidos
//int 5idade;
//int $valor;
//int valor#total;

//Para nomes e variáveis usar (Camel case)
string descontoTotal;
string desconto_Total;

//Para constantes (Maiusculas)
double PI = 3.14;
string PREFIXO = "14";
string PREFIXO_SP = "11";

Console.ReadLine();

//Nomes de classes e metodos (Pascal Case)
class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Marcoratti");
    }
}