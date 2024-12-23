using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDeMusica
{
    internal class Banda
    {
        public Banda(string nome)
        { 
            this.nome = nome;
        }

        private List<Album> albuns = new List<Album>();
        public string nome { get;}

        public void adicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void exibirAlbuns()
        {
            Console.WriteLine("\nDiscografia da banda " + nome);
            foreach (Album album in albuns)
            {
                Console.WriteLine($"Album: {album.Nome} - {album.Duracao}s");
            }
        }
    }
}
