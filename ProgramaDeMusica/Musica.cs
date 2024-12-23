using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDeMusica
{
    internal class Musica
    {
        public Musica(Banda Artista, string nome)
        {
            this.Artista = Artista;
            Nome = nome;
        }
        public string Nome { get; }
        public Banda Artista { get; }
        public int duracao { get; set; }
        public bool Disponivel {  get; set; }
        public string DescricaoResumida => $"{Nome} - {Artista} ({duracao}s)";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine("\nNome: " + Nome);
            Console.WriteLine("Artista: " + Artista.nome);
            Console.WriteLine("Duração: " + duracao + "s");
            Console.WriteLine("Disponível: " + Disponivel);

            if (Disponivel)
            {
                Console.WriteLine("\nA música está disponível para ser ouvida.");
            }
            else
            {
                Console.WriteLine("A música não está disponível para ser ouvida.");
            }
        }
    }
}
