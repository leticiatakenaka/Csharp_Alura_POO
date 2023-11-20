using System;

class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string TituloAlbum { get; set; }
    public int DuracaoTotalAlbum { get; set; }

    public void AdicionarMusicaAoAlbum(Musica musica)
    {
        musicas.Add(musica);
    }
}