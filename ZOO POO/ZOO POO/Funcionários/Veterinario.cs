public class Veterinario : Funcionario
{
    public Veterinario(string nome, int id) : base(nome, "Veterinário", id)
    {
    }

    public override void Salario()
    {
        Console.WriteLine("O salário do Veterinario é de R$10,800.");
    }
}
