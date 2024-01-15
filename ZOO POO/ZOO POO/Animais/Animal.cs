public abstract class Animal
{
    public string Nome { get; set; }
    public string Especie { get; set; }
    public int Idade { get; set; }
    public int Id { get; set; }

    public Animal()
    {
        
    }

    public Animal(int id, string nome, string especie, int idade)
    {
        Nome = nome;
        Especie = especie;
        Idade = idade;
        Id = id;
    }

    //virtual é um método usado em uma classe base, está dizendo: "Se você criar uma nova classe baseada nesta, você pode mudar este método específico se quiser."
    public virtual void EmitirSom()
    {
        Console.WriteLine("Este animal não emite um som.");
    }

    //só compara Id´s entre objetos de animal
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Animal outro = (Animal)obj;
        return Id == outro.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
