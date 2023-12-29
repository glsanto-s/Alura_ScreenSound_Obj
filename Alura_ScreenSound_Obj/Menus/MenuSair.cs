using Alura_ScreenSound_Obj.Models;

namespace Alura_ScreenSound_Obj.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            Console.WriteLine("Tchauzinho!");
        }
    }
}
