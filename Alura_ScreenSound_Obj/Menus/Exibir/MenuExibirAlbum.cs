using Alura_ScreenSound_Obj.Models;

namespace Alura_ScreenSound_Obj.Menus.Exibir
{
    internal class MenuExibirAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloOpt("Exibir detalhes da banda");

            Console.Write("Digite a banda da qual o album pertence: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Banda banda = bandasRegistradas[nomeBanda];
                Console.Write("Digite o album que deseja ver os detalhes: ");
                string nomeAlbum = Console.ReadLine()!;

                if(banda.Albums.Any(a => a.Nome.Equals(nomeAlbum)))
                {
                    foreach (Album album in banda.Albums)
                    {
                        Console.WriteLine($"{album.Nome} -> {album.Media}");
                        foreach(Musica musica in album.Musicas)
                        {
                            Console.WriteLine(musica.Descricao);
                        }
                    }
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
