using Alura_ScreenSound_Obj.Interfaces;

namespace Alura_ScreenSound_Obj.Models;

internal class Banda : IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string banda)
    {
        Nome = banda;
    }
    public string Nome { get; }
    public double Media
    {
        get
        {
            if(notas.Count() == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public List<Album> Albums => albuns;
    public string? Resumo { get; set; }
    public void AddAlbum(Album album)
    {
        albuns.Add(album);
    }
    public void AddNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ShowDisco()
    {
        Console.WriteLine($"\nDiscografia da banda {Nome}");
        foreach(Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal}s)");
        }
    }

}