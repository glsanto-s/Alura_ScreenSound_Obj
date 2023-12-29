using Alura_ScreenSound_Obj.Models;

namespace Alura_ScreenSound_Obj.Menus.Avaliar
{
    internal class MenuAvaliarMusica : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            ExibirTituloOpt("Avaliar música:");

            Console.Write("Digite o nome da banda: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Banda banda = bandasRegistradas[nomeBanda];
                Console.Write("\nAgora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;

                if (banda.Albums.Any(a => a.Nome.Equals(tituloAlbum)))
                {
                    Album album = banda.Albums.First(a => a.Nome.Equals(tituloAlbum));

                    Console.Write("\nAgora digite a música que deseja avaliar: ");
                    string NomeMusica = Console.ReadLine()!;

                    if (album.Musicas.Any(m => m.NomeMusic.Equals(NomeMusica)))
                    {
                        Musica musica = album.Musicas.First(m => m.NomeMusic.Equals(NomeMusica));

                        Console.Write("Digite a avaliação de 1 a 10: ");
                        Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);

                        musica.AddNota(avaliacao);

                        Console.WriteLine($"A nota {avaliacao.Nota} para o álbum {tituloAlbum} foi registrada com sucesso!");
                        Thread.Sleep(2000);

                        Console.Clear();
                    }

                }
                else
                {
                    Console.WriteLine($"O álbum {tituloAlbum} não foi encontrado!");

                    Console.WriteLine("\nDigite algo para voltar");
                    Console.ReadKey();

                    Console.Clear();
                }
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
