using Alura_ScreenSound_Obj.Models;

namespace Alura_ScreenSound_Obj.Menus.Avaliar
{
    internal class MenuAvaliarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            ExibirTituloOpt("Avaliar banda:");

            Console.Write("Digite a banda que deseja avaliar: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Banda banda = bandasRegistradas[nomeBanda];
                Console.Write("Digite a avaliação de 1 a 10: ");
                Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);
                banda.AddNota(avaliacao);

                Console.WriteLine($"A nota {avaliacao.Nota} para a banda {nomeBanda} foi registrada com sucesso!");
                Thread.Sleep(2000);

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
