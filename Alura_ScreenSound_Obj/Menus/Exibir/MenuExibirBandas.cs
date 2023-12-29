using Alura_ScreenSound_Obj.Models;

namespace Alura_ScreenSound_Obj.Menus.Exibir
{
    internal class MenuExibirBandas : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloOpt("Exibindo bandas registradas:");

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite algo para voltar");
            Console.ReadKey();

            Console.Clear();
        }
    }
}
