using Alura_ScreenSound_Obj.Models;

namespace Alura_ScreenSound_Obj.Menus.Exibir
{
    internal class MenuExibirDetalhes : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            ExibirTituloOpt("Exibir detalhes da banda");

            Console.Write("Digite a banda que deseja ver os detalhes: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Banda banda = bandasRegistradas[nomeBanda];
                Console.WriteLine(banda.Resumo);
                Console.WriteLine($"\nA média da banda {nomeBanda} é: {banda.Media}");
                Console.WriteLine("\nDiscografia:");
                foreach (Album album in banda.Albums)
                {
                    Console.WriteLine($"{album.Nome} -> {album.Media}");
                }

                Console.WriteLine("\nDigite algo para voltar");
                Console.ReadKey();

                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Banda {nomeBanda} não foi encontrada!");

                Console.WriteLine("\nDigite algo para voltar");
                Console.ReadKey();

                Console.Clear();
            }
        }
    }
}
