using AppMusica;

namespace Alura_POO
{
    class Banda(string nome)
    {
        private readonly List<Album> _albums = new ();

        public string Nome { get; set; } = nome;

        public void AdicionarAlbum(Album album)
        {
            _albums.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach (Album album in _albums)
            {
                Console.WriteLine($"Álbum: {album.TituloAlbum} ({album.DuracaoTotalAlbum})");
            }
        }
    }
}
