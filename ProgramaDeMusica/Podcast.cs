using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDeMusica
{
    internal class Podcast
    {
        private List<Episodio> episodios = new();

        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        public string Host { get; }
        public string Nome { get; }
        public int totalEpisodios => episodios.Count;

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("\nPodcast: " + Nome);
            Console.WriteLine("Host: " + Host);
            Console.WriteLine("Total de episódios: " + totalEpisodios);

            foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Resumo);
            }
        }
    }
}
