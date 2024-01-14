public class Leao : Animal
{
    public Leao(int id, string nome, int idade) : base(id, nome, "Leão", idade)
    {
    }

    //override é como dizer: "Eu sei que já existe uma maneira de fazer isso na classe base, mas quero fazer do meu jeito nesta classe específica".
    public override void EmitirSom()
    {
        Console.WriteLine("O leão ruge.");
    }
}
