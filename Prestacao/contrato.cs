namespace Prestacao;
class contrato
{
public string? Descricao{get;set;}
public double Valor {get;set;}

public int prazo{get;set;}


public virtual void Detalhes(){
 Console.WriteLine("Seu Valor " + Valor);
 Console.WriteLine("Seu Prazo " + prazo);
 Console.WriteLine("Sua descrição " + Descricao);
}


public virtual double calcularP(){
    return Valor/prazo;
}
}

