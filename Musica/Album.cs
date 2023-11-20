using Alura_POO;
using System;
using System.Runtime.CompilerServices;

class Album(List<Musica> musicas, string tituloAlbum, int duracaoTotalAlbum)
{
    private List<Musica> musicas = musicas;
    public string TituloAlbum { get; set; } = tituloAlbum;
    public int DuracaoTotalAlbum { get; set; } = duracaoTotalAlbum;

    public void AdicionarMusicaAoAlbum(Musica musica)
    {
        musicas.Add(musica);
    }
}