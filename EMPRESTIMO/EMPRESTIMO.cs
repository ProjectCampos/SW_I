namespace EMPRESTIMO;
class EMPRESTIMO
{
    public double saldo {get;set;}

    public double dinheiro {get;set;}

    public double meses {get;set;}


        public void depositar(double valor){
        this.saldo += valor;
    }


    public void saque (double valor){
    this.saldo -= valor;
}


public double emprestimo(){
    return this.saldo = this.dinheiro / this.meses;
}

public double juros(){
     return  this.saldo = this.dinheiro * 0.06;
}

}