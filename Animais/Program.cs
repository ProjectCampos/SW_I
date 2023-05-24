namespace Animais;
class Program
{
    static void Main(string[] args)
    {
      Homem homem = new Homem();
      Cao cachorro = new Cao();
      Gato gato = new Gato();

      Console.WriteLine("O homem faz" + homem.Fala());
      Console.WriteLine("O homem faz" + cachorro.Fala());
      Console.WriteLine("O homem faz" + gato.Fala());


    }
}
