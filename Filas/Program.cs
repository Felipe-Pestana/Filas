using Filas;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Fila!");

        FilaPessoa filaPessoa = new();

        filaPessoa.Push(new Pessoa("Odair"));
        filaPessoa.Push(new Pessoa("Alexa"));
        filaPessoa.Push(new Pessoa("Tio Paulo"));

        filaPessoa.Pop();
        filaPessoa.Pop();
        filaPessoa.Pop();
    }
}