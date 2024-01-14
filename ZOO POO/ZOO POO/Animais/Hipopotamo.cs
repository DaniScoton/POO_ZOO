public class Hipopotamo : Animal
{
    public Hipopotamo(int id, string nome, int idade) : base(id, nome, "Hipopotamo", idade)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("O hipopotamo grunhe.");
    }
}
