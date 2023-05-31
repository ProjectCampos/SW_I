namespace comercio;
class Nacional:Produto
{
    public double Taxa {get;set;}

    public override double Calcula_Total()
    {
        return base.Calcula_Total() + (this.Valor*(this.Taxa/100)); 
    }
}
