namespace Contrato;
class Program
{
    static void Main(string[] args)
    {
      PFisica fisica = new PFisica();
      Pjuridica juridica = new Pjuridica();
      Contrato2 contrato = new Contrato2();  

    fisica.Nome = "Giovana";
    fisica.Email = "giovanacampos@gmail.com";
    fisica.Telefone= 999156441 ;

    juridica.Nome = "Giovana02";
    juridica.Email ="giovanacruz@gmail.com";
    juridica.Telefone = 995482978;


      Console.WriteLine(" Seu contrato é: " + fisica.MostraDados());
      Console.WriteLine(" Seu cpf: " + fisica.Cpf );
      Console.WriteLine(" Seu Email: " + fisica.Email);
      Console.WriteLine(" Sua idade: "+ fisica.idade);

      Console.WriteLine( " Seu contrato é: " + juridica.MostraDados()); 
      Console.WriteLine(" Seu cnpj: " + juridica.cnpj );
      Console.WriteLine(" Seu IE: " + juridica.ie);
      Console.WriteLine(" O nome da sua empresa é: " + juridica.NomeEmpresa);


    }
}
