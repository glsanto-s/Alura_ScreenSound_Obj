using Alura_ScreenSound_Obj.Models;

namespace Alura_ScreenSound_Obj.Interfaces
{
    internal interface IAvaliavel
    {
        //assinatura
        void AddNota(Avaliacao nota);
        double Media { get; }
    }
}
