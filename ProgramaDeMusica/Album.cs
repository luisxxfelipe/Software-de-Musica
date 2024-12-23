using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDeMusica
{
    internal class Album
    {

        private List<Musica> musicas = new List<Musica>();

        public Album(string nome)
        {
            Nome = nome;
        }

        public string Nome { get;}
        public int Duracao=> musicas.Sum(m => m.duracao);
        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
            Console.WriteLine("Musica adicionada: " + musica.Nome);
        }

        public void ExibirMusicas()
        {
            Console.WriteLine("\nMúsicas do álbum " + Nome);
            foreach (Musica musica in musicas)
            {
                Console.WriteLine($"Musica: {musica.Nome} ({musica.duracao})s");
            }

            Console.WriteLine($"\nPara ouvir esse album esse album inteiro você precisa de {Duracao}s\n");
        }
    }
}
