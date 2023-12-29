using Alura_ScreenSound_Obj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura_ScreenSound_Obj.Menus.Avaliar
{
    internal class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            ExibirTituloOpt("Avaliar álbum:");

            Console.Write("Digite a banda do álbum que deseja avaliar: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Banda banda = bandasRegistradas[nomeBanda];
                Console.Write("\nAgora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;

                if (banda.Albums.Any(a => a.Nome.Equals(tituloAlbum)))
                {
                    Album album = banda.Albums.First(a => a.Nome.Equals(tituloAlbum));
                    Console.Write("Digite a avaliação de 1 a 10: ");
                    Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);

                    album.AddNota(avaliacao);

                    Console.WriteLine($"A nota {avaliacao.Nota} para o álbum {tituloAlbum} foi registrada com sucesso!");
                    Thread.Sleep(2000);

                    Console.Clear();
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
