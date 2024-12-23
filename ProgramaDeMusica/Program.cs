using ProgramaDeMusica;

Banda banda = new Banda("Coldplay");

Album album = new Album("Parachutes");
banda.adicionarAlbum(album);

Musica musica1 = new Musica(banda, "Yellow");
{
    musica1.duracao = 266;
    musica1.Disponivel = true;
};
album.AdicionarMusica(musica1);

Musica musica2 = new Musica(banda, "Shiver");
{
    musica2.duracao = 300;
    musica2.Disponivel = false;
};
album.AdicionarMusica(musica2);

Musica musica3 = new Musica(banda, "Sparks");
{
    musica3.duracao = 267;
    musica3.Disponivel = true;
};
album.AdicionarMusica(musica3);

Musica musica4 = new Musica(banda, "Trouble");
{
    musica4.duracao = 266;
    musica4.Disponivel = true;
};
album.AdicionarMusica(musica4);


banda.exibirAlbuns();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();


Console.WriteLine("------------------------------------");
Console.WriteLine("PARTE DA CRIAÇÃO DO PODCAST");

Episodio episodio1 = new(1, "O que é um podcast?", 300);
episodio1.AdicionarConvidados("Luis Felipe");
episodio1.AdicionarConvidados("Lucas França");
Console.WriteLine(episodio1.Resumo);

Episodio episodio2 = new(2, "Como criar um podcast?", 400);
episodio2.AdicionarConvidados("Marcos Ferreira");
episodio2.AdicionarConvidados("João Neves");
Console.WriteLine(episodio2.Resumo);

Podcast podcast = new("Luis Felipe", "Podcast sobre podcasts");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.ExibirDetalhes();

Podcast podcast2 = new("Lucas França", "Podcast sobre programação");
podcast2.AdicionarEpisodio(episodio1);
podcast2.AdicionarEpisodio(episodio2);
podcast2.ExibirDetalhes();

Console.WriteLine("------------------------------------");