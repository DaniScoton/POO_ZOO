public class Nutricionista : Funcionario
{
    public Nutricionista(string nome, int id) : base(nome, "Nutricionista", id)
    {
    }

    public override void Salario()
    {
        Console.WriteLine("O salário do Veterinario é de R$15,400.");
    }
}
