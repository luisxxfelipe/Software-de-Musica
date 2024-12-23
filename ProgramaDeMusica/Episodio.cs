using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDeMusica
{
    internal class Episodio
    {
        private List<string> convidados = new List<string>();
        public Episodio(int ordem, string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;
            Ordem = ordem;
        }
        public int Duracao { get; }
        public string Titulo { get; }
        public string Resumo => $"Episódio {Ordem} - {Titulo} - ({Duracao} minutos) - {string.Join(", ", convidados)}";
        public int Ordem { get; }

        public void AdicionarConvidados(string nome)
        {
            convidados.Add(nome);
        }
    }
}
