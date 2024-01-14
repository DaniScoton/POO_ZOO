public class Girafa : Animal //extends
{
    public long TamanhoPescoco { get; set; }
    // seguido de base indica que estamos chamando o construtor da classe base (Animal, no caso). A palavra-chave base é usada para acessar membros da classe base que foram
    // herdados pela classe derivada.
    public Girafa(int id, string nome, int idade, long tamanhoPescoco) : base(id, nome, "Girafa", idade)
    {
        TamanhoPescoco = tamanhoPescoco;
    }
    // Girafas não têm um som característico
}
