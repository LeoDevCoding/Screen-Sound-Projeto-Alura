﻿ class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de música  do álbum {Nome}:\n");
        foreach(var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}"); 
        }
        Console.WriteLine($"\nPara ouvir este àlbum inteiro você precisa de {DuracaoTotal} segundos");
    }
}