using Alura_ScreenSound_Obj.Models;

namespace Alura_ScreenSound_Obj.Menus.Registrar
{
    internal class MenuRegistrarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            ExibirTituloOpt("Registro de Album");
            Console.Write("\n Digte a banda cujo álbum deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write("\nAgora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeDaBanda];
                banda.AddAlbum(new Album(tituloAlbum));
                Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                Thread.Sleep(4000);

                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Banda {nomeDaBanda} não foi encontrada!");

                Console.WriteLine("\nDigite algo para voltar");
                Console.ReadKey();

                Console.Clear();
            }
        }
    }
}
