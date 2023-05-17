namespace heranca_polimorfismo;
class FuncionarioN3:Funcionario
{
    
    public override double Participacao()
    {
        return base.Participacao()*0.03;
    }

}
