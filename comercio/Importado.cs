namespace comercio;
class Importado:Produto
{
    public double Taxa {get;set;}
    public double Taxa_Import {get;set;}

    public override double Calcula_Total()
    {
        return base.Calcula_Total() + (this.Valor*(this.Taxa/100)) + (this.Valor*(this.Taxa_Import/100)); 
    }
}
