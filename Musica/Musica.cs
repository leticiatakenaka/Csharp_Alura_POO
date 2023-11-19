using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura_POO
{
    class Musica(string tituloMusica, string artistaMusica, int duracaoMusica, bool disponivelMusica)
    {
        public string tituloMusica = tituloMusica;
        public string artistaMusica = artistaMusica;
        public int duracaoMusica = duracaoMusica;
        public bool disponivelMusica = disponivelMusica;

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Título: {tituloMusica}");
            Console.WriteLine($"Artista: {artistaMusica}");
            Console.WriteLine($"Duração: {duracaoMusica}");
            Console.WriteLine($"Disponível: {disponivelMusica}");
        }
        public void ExibirTituloEArtista()
        {
            Console.WriteLine($"Título: {tituloMusica}\nArtista: {artistaMusica}");
        }

        public void DisponivelNoPlano()
        {
            string mensagem = disponivelMusica ? "Disponível no plano" : "Adiquira o plano Plus"; ;
            Console.WriteLine(mensagem);
        }

    }
}
