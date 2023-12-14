using AppMusica;

Episodio ep1 = new(1, "Técnica de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Felipe");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(2, "Técnica de aprendizado", 65);
ep2.AdicionarConvidados("João");
ep2.AdicionarConvidados("Flávia");
Console.WriteLine(ep2.Resumo);

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);