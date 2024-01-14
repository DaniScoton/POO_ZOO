using ZOO_POO.Exibir;

class Program
{
    static void Main(string[] args)
    {
        ExibirInformacoesAnimais exibirInformacoesAnimais = new ExibirInformacoesAnimais();
        exibirInformacoesAnimais.Exibir();

        ExibirInformacoesFuncionarios exibirInformacoesFuncionarios = new ExibirInformacoesFuncionarios();
        exibirInformacoesFuncionarios.Exibir();

        ExibirInformacoesHabitat exibirInformacoesHabitat = new ExibirInformacoesHabitat();
        exibirInformacoesHabitat.Exibir();

    }
}

