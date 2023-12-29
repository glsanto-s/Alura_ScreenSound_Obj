namespace Alura_ScreenSound_Obj.Models;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    }

    public int Nota { get;} 
    
    //O static significa que o que será executado dentro, não usa nenhuma instância da avaliação
    //podemos usar sem instanciar
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
