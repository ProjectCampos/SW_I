namespace Contrato;
class Pjuridica:Contrato2
{
    public override string? MostraDados()
    {
        return base.MostraDados();
    }
    public int cnpj= 1234567891;

    public string? ie = "Numeração atribuída pelo INSS";

    public string? NomeEmpresa= "ETEC MCM";

}