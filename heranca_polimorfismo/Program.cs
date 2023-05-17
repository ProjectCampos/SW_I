namespace heranca_polimorfismo;
class Program
{
    static void Main(string[] args)
    {
        FuncionarioN1 n1 = new FuncionarioN1();
        FuncionarioN2 n2 = new FuncionarioN2();
        FuncionarioN3 n3 = new FuncionarioN3();

        n1.Nome = "Fulano";
        n2.Nome = "Ciclano";
        n3.Nome = "Beltrano";

        Console.WriteLine("Funcionário: " + n1.Nome + "Participção: " + n1.Participacao());
        Console.WriteLine("Funcionário: " + n2.Nome + "Participção: " + n2.Participacao());
        Console.WriteLine("Funcionário: " + n3.Nome + "Participção: " + n3.Participacao());











    }
        
    
}
