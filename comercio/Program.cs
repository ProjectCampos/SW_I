namespace comercio;
class Program
{
    static void Main(string[] args)
    {
        Estadual prodEstadual = new Estadual();
        Nacional prodNacional = new Nacional();
        Importado prodImport = new Importado();

        Console.WriteLine("Escolha: \n1 para Estadual \n2 para Nacional \n3 para Importado:");
        int opcao = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Você escolheu a opção: " + opcao);


        
        prodEstadual.Descricao = "Lapis Estadual";
        prodEstadual.Valor = 1000;
        prodEstadual.Imposto = 10;

        Console.WriteLine("Valor deste produto é: " + prodEstadual.Calcula_Total());
        Console.WriteLine("******************************************************");

        prodNacional.Descricao = "Lapis Nacional";
        prodNacional.Valor = 1000;
        prodNacional.Imposto = 10;
        prodNacional.Taxa = 5;
        Console.WriteLine("Valor deste produto é: " + prodNacional.Calcula_Total());
        Console.WriteLine("******************************************************");

        prodImport.Descricao = "Lápis Importado";
        prodImport.Valor = 1000;
        prodImport.Imposto = 10;
        prodImport.Taxa = 5;
        prodImport.Taxa_Import = 5;
        Console.WriteLine("Valor deste produto é: " + prodImport.Calcula_Total());
        Console.WriteLine("******************************************************");


    }
}
