Banda metalica = new Banda("Metalica");
 
Album albumDoMetalica = new Album("Master of Puppets");

Musica musica1 = new Musica(metalica, "Welcome home")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(metalica, "Disposable heroes")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoMetalica.AdicionarMusica(musica1);
albumDoMetalica.AdicionarMusica(musica2);
metalica.AdicionarAlbum(albumDoMetalica);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoMetalica.ExibirMusicasDoAlbum();
metalica.ExibirDiscografia();
