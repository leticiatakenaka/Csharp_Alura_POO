﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura_POO
{
    class Musica(string tituloMusica, string artistaMusica, int duracaoMusica, bool disponivelMusica)
    {
        public string TituloMusica { get; set; } = tituloMusica;
        public string ArtistaMusica { get; set; } = artistaMusica;
        public int DuracaoMusica { get; set; } = duracaoMusica;
        public bool DisponivelMusica { get; set; } = disponivelMusica;
        //propriedade DescricaoMusica é somente leitura, e utiliza expressão Lambda ao invés do get com return
        public string DescricaoMusica => $"A música {TituloMusica} pertence ao artista {ArtistaMusica}";
        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Título: {TituloMusica}");
            Console.WriteLine($"Artista: {ArtistaMusica}");
            Console.WriteLine($"Duração: {DuracaoMusica}");
            Console.WriteLine($"Disponível: {DisponivelMusica}");
        }
        public void ExibirTituloEArtista()
        {
            Console.WriteLine($"Título: {TituloMusica}\nArtista: {ArtistaMusica}");
        }

        public void DisponivelNoPlano()
        {
            string mensagem = DisponivelMusica ? "Disponível no plano" : "Adiquira o plano Plus"; ;
            Console.WriteLine(mensagem);
        }

    }
}
