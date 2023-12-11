namespace Alura_POO
{
    class Album(List<Musica> musicas, string tituloAlbum)
    {
        private List<Musica> musicas = musicas;
        public string TituloAlbum { get; set; } = tituloAlbum;
        public int DuracaoTotalAlbum => musicas.Sum(musica => musica.DuracaoMusica);

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine(
                $"Álbum: {TituloAlbum} - Duração do álbum com as músicas selecionadas: {DuracaoTotalAlbum}s");
            musicas.ForEach(musica =>
                Console.WriteLine(
                    $"Música: {musica.TituloMusica} - {musica.DuracaoMusica}s\nGenero: {musica.GeneroMusical}"));
            Console.WriteLine("\n\n");
        }
    }
}