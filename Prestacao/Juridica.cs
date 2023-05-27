namespace Prestacao;
class Juridica : contrato
{
   public int cnpj{get;set;}
    public int inscricao{get;set;}

    public override void Detalhes()
    {
        base.Detalhes();
        Console.WriteLine("Seu CNPJ " + cnpj) ;
        Console.WriteLine("Sua inscrição  " + inscricao) ;
    }

    public override double calcularP()
    {
       double Prestacao = base.calcularP();
       return Prestacao + 3.0;
    }
}