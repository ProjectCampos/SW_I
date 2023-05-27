namespace Contrato;
class Contrato2
{
   public virtual string? Nome{get;set;}

    public virtual string? Email {get; set;}

    public virtual int Telefone {get; set;}

    public virtual string? MostraDados(){
        return " Seu nome é: " + this.Nome + " Seu EMail: " + this.Email + " Seu telefone (11): " +this.Telefone;
    }
}