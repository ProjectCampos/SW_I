namespace Prestacao;
class Program
{
    static void Main(string[] args)
    {
        Fisica f = new Fisica();
        Juridica j = new Juridica();

    f.Descricao= "contrato de pessoa fisica ";
    f.Valor = 30;
    f.prazo = 3;
    f.cpf = 124573535-23;
    f.idade= 15;

    f.Detalhes();
    Console.WriteLine("Valor da sua prestação " + f.calcularP());
    Console.WriteLine();


    j.Descricao= "contrato de pessoa juridica ";
    j.Valor=50;
    j.prazo = 6;
    j.cnpj = 345257537;
    j.inscricao = 3465478;

    j.Detalhes();
    Console.WriteLine("Valor da sua prestação " + j.calcularP());
    Console.WriteLine();
    }
}
