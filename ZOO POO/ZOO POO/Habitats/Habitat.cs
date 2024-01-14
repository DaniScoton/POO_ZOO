public class Habitat
{
    public string Tipo { get; set; }
    public int Capacidade { get; set; }
    public List<Animal> Animais { get; set; }

    public Habitat(string tipo, int capacidade)
    {
        Tipo = tipo;
        Capacidade = capacidade;
        Animais = new List<Animal>();
    }

    // Método para adicionar um animal ao habitat
    public bool AdicionarAnimal(Animal animal)
    {
        //Verifica se tem espaço
        if (Animais.Count < Capacidade)
        {
            Animais.Add(animal);
            return true;
        }
        else
        {
            Console.WriteLine("Não é possível adicionar: Capacidade máxima atingida." + Tipo);
            return false;
        }
    }

    // Método para remover um animal do habitat
    public void RemoverAnimal(int id)
    {
        var animalEncontrado = Animais.FirstOrDefault(animal => animal.Id == id);

        if (animalEncontrado != null)
        {
            Animais.Remove(animalEncontrado);
            Console.WriteLine("Animal Removido");
        }
        else
        {
            Console.WriteLine("Animal não encontrado");
        }
    }
}
