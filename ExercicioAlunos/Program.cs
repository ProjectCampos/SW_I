namespace ExercicioAlunos;
class Program
{ 
     static void Main(string[] args){
       Aluno aluno1 = new Aluno();
        
Console.WriteLine("Digite seu nome: ");
aluno1.nome = Console.ReadLine();
Console.WriteLine("Digite sua primeira nota: ");
aluno1.nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua segunda nota: ");
aluno1.nota2 = Convert.ToDouble(Console.ReadLine());

aluno1.mensagem();


    }  
      
}
