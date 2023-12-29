using Alura_ScreenSound_Obj.Interfaces;

namespace Alura_ScreenSound_Obj.Models;

internal class Album : IAvaliavel
{
    private List<Musica> musicList = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Album(string album)
    {
        Nome = album;
    }
    public string Nome { get;}
    public int DuracaoTotal => musicList.Sum(m => m.Duracao);
    public IEnumerable<Musica> Musicas => musicList;
    public double Media
    {
        get
        {
            if (notas.Count() == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AddMusic(Musica musica)
    {
        musicList.Add(musica);
    }

    public void AddNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ShowAlbum()
    {
        Console.WriteLine($" Album: {Nome}\n");
        foreach (var musica in musicList)
        {
            Console.WriteLine($" Música {musica.NomeMusic}");
        }
        Console.WriteLine($"\n A duração total do album é: {DuracaoTotal}s");
    }
}