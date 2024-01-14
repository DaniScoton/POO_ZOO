public class Cuidador : Funcionario
{
    public Cuidador(string nome, int id) : base(nome, "Cuidador", id)
    {
    }

    public override void Salario()
    {
        Console.WriteLine("O salário do cuidador é de R$5,700.");
    }
}