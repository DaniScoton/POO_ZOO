public class Zebra : Animal
{
    public Zebra(int id, string nome, int idade) : base(id, nome, "Zebra", idade)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("A zebra relincha.");
    }
}
