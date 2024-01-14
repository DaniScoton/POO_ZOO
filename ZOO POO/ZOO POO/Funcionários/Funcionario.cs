public class Funcionario
{
    public string Nome { get; set; }
    public string Funcao { get; set; }
    public int Id { get; set; }

    public Funcionario(string nome, string funcao, int id)
    {
        Nome = nome;
        Funcao = funcao;
        Id = id;
    }

    public virtual void Salario()
    {
        Console.WriteLine("Este funcionario recebe um salário.");
    }
}
