using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_POO.Exibir
{
    internal class ExibirInformacoesFuncionarios : IExibirInformacoes
    {
        public void Exibir()
        {
            Funcionario cuidador1 = new Cuidador("Vitor", 25);
            Funcionario cuidador2 = new Cuidador("Cristiane", 22);
            Funcionario cuidador3 = new Cuidador("Cláudio", 09);
            Funcionario cuidador4 = new Cuidador("Vinicius", 12);
            Funcionario cuidador5 = new Cuidador("Ingrid", 15);

            Console.WriteLine($"Nome: {cuidador1.Nome}, Função: {cuidador1.Funcao}, Identidade: {cuidador1.Id}");
            Console.WriteLine($"Nome: {cuidador2.Nome}, Função: {cuidador2.Funcao}, Identidade: {cuidador2.Id}");
            Console.WriteLine($"Nome: {cuidador3.Nome}, Função: {cuidador3.Funcao}, Identidade: {cuidador3.Id}");
            Console.WriteLine($"Nome: {cuidador4.Nome}, Função: {cuidador4.Funcao}, Identidade: {cuidador4.Id}");
            Console.WriteLine($"Nome: {cuidador5.Nome}, Função: {cuidador5.Funcao}, Identidade: {cuidador5.Id}");

            Funcionario veterinario1 = new Veterinario("Marilene", 24);
            Funcionario veterinario2 = new Veterinario("Alexandre", 20);
            Funcionario veterinario3 = new Veterinario("Danielly", 08);

            Console.WriteLine($"Nome: {veterinario1.Nome}, Função: {veterinario1.Funcao}, Identidade: {veterinario1.Id}");
            Console.WriteLine($"Nome: {veterinario2.Nome}, Função: {veterinario2.Funcao}, Identidade: {veterinario2.Id}");
            Console.WriteLine($"Nome: {veterinario3.Nome}, Função: {veterinario3.Funcao}, Identidade: {veterinario3.Id}");

            Funcionario nutricionista1 = new Nutricionista("Tatiana", 12);
            Funcionario nutricionista2 = new Nutricionista("Ivany", 13);
            Funcionario nutricionista3 = new Nutricionista("Katia", 03);

            Console.WriteLine($"Nome: {nutricionista1.Nome}, Função: {nutricionista1.Funcao}, Identidade: {nutricionista1.Id}");
            Console.WriteLine($"Nome: {nutricionista2.Nome}, Função: {nutricionista2.Funcao}, Identidade: {nutricionista2.Id}");
            Console.WriteLine($"Nome: {nutricionista3.Nome}, Função: {nutricionista3.Funcao}, Identidade: {nutricionista3.Id}");

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
        }
    }
}
