namespace comercio;
class Produto
{
    public string? Descricao {get;set;}
    public double Valor {get;set;} // 1000
    public double Imposto {get;set;} // 5.6 -> 0.056

    public virtual double Calcula_Total(){
        double total = this.Valor + (this.Valor*(this.Imposto/100));
        return total;
    }
}
