namespace Prestacao;
class Fisica:contrato
{
 public int cpf{get;set;}
 public int idade {get;set;}

    public override void Detalhes()
    {
        base.Detalhes(); 
        Console.WriteLine("Seu CPF " + cpf);
        Console.WriteLine("Sua idade " + idade);
}

    public override double calcularP()
    {
        double Prestacao = base.calcularP();
        double adicional = 0.0;

        if(idade<=30)
        adicional = 1.0;
         else if(idade<=40)
        adicional = 2.0;
        else if(idade<=50)
        adicional = 3.0;
        else if(idade >= 50)
        adicional = 4.0;

        return adicional + Prestacao;
    
    }
}