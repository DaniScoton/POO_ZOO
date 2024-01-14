using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_POO.Exibir
{
    internal class ExibirInformacoesHabitat : IExibirInformacoes
    {
        public void Exibir()
        {
            ExibirInformacoesAnimais exibirInformacoesAnimais = new ExibirInformacoesAnimais();

            Habitat savana = new Habitat("Savana", 10);

            foreach (Animal animalSavana in exibirInformacoesAnimais.AnimaisSavana)
            {
                savana.AdicionarAnimal(animalSavana);
            }

            Habitat aquario = new Habitat("Aquário", 20);

            foreach (Animal animalAquario in exibirInformacoesAnimais.AnimaisAquario)
            {
                aquario.AdicionarAnimal(animalAquario);
            }

            Printar(savana);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");

            Printar(aquario);
        }

        private void Printar(Habitat habitat)
        {
            Console.WriteLine($"Habitat: {habitat.Tipo}");
            Console.WriteLine($"Capacidade máxima: {habitat.Capacidade}");
            Console.WriteLine("Animais no habitat:");
            foreach (Animal animal in habitat.Animais)
            {
                Console.WriteLine($"- {animal.Nome} ({animal.Especie})");
            }
            Console.WriteLine();
        }
    }
}
