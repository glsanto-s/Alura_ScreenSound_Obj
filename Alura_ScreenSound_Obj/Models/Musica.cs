using Alura_ScreenSound_Obj.Interfaces;

namespace Alura_ScreenSound_Obj.Models;

internal class Musica : IAvaliavel
{
    private List<Avaliacao> notas = new List<Avaliacao>();

    //construtor não tem return, void, ele é um tipo
    //infos obrigatórias
    public Musica(Banda artista, string musica, Genero genero)
    {
        Artista = artista;
        NomeMusic = musica;
        Genero = genero;
    }
    //propriedade PascalCase
    public string NomeMusic { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }


    public Genero Genero { get; }
    //esse arrow fuction => é chamada lambda
    //lambda são funcoes anonimas que podem ser usadas para criar blocos de códigos compactos e concisos
    public string Descricao =>
        $"Música: {NomeMusic} | Duração: {Duracao}s | Disponível: {Disponivel} | Gênero: {Genero.Nome}";

    public double Media
    {
        get
        {
            if (notas.Count() == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AddNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {NomeMusic}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}s");
        Console.WriteLine($"Gênero: {Genero.Nome}");
        if(Disponivel)
            Console.WriteLine("Disponível no plano");
        else
            Console.WriteLine("Apenas no plano plus");
    }
}