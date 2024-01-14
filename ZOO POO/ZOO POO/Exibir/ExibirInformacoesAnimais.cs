using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_POO.Exibir
{
    internal class ExibirInformacoesAnimais : IExibirInformacoes
    {

        public HashSet<Animal> AnimaisSavana = new HashSet<Animal>(); //HashSet: não permite elementos duplicados
        public HashSet<Animal> AnimaisAquario = new HashSet<Animal>();

        public ExibirInformacoesAnimais()
        {
            AnimaisSavana.Add(new Girafa(1, "Melman", 8, 19));
            AnimaisSavana.Add(new Girafa(2, "Bobby", 5, 8));
            AnimaisSavana.Add(new Girafa(3, "Joe", 12, 12));
            AnimaisSavana.Add(new Leao(4, "Alex", 3));
            AnimaisSavana.Add(new Leao(5, "Zuba", 10));
            AnimaisSavana.Add(new Leao(6, "Teetsi", 10));
            AnimaisSavana.Add(new Zebra(7, "Marty", 7));
            AnimaisSavana.Add(new Hipopotamo(8, "Gloria", 4));
            AnimaisSavana.Add(new Hipopotamo(9, "Moto", 7));

            AnimaisAquario.Add(new Pinguim(10, "Capitão", 10));
            AnimaisAquario.Add(new Pinguim(11, "Recruta", 6));
            AnimaisAquario.Add(new Pinguim(12, "Kowalski", 8));
            AnimaisAquario.Add(new Pinguim(13, "Rico", 9));
        }

        public void Exibir()
        {

            foreach(Animal animal in AnimaisSavana)
            {
                PrintarInformacoesAnimal(animal);
            }

            foreach (Animal animal in AnimaisAquario)
            {
                PrintarInformacoesAnimal(animal);
            }

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
        }

       private void PrintarInformacoesAnimal(Animal animal)
        {
            Console.WriteLine($"Id: {animal.Id}, Nome: {animal.Nome}, Espécie: {animal.Especie}, Idade: {animal.Idade}");
            


        }

    }
}
