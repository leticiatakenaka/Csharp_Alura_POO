using Alura_POO;

var queen = new Banda(nome: "Queen");

Musica musica1 = new("Cool Cat", queen, 196, true, GeneroMusical.NomeGeneroMusical.Rock);
Musica musica2 = new("Spread Your Wings", queen, 259, true, GeneroMusical.NomeGeneroMusical.Rock);
Album album1 = new([musica1,musica2], "News of the World");

Musica musica3 = new("Sleeping On the Sidewalk", queen, 185, true, GeneroMusical.NomeGeneroMusical.Rock);
Album album2 = new([musica3], "Hot Space");

album1.ExibirMusicasDoAlbum();
album2.ExibirMusicasDoAlbum();

queen.AdicionarAlbum(album1);
queen.ExibirDiscografia();