using Alura_ScreenSound_Obj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura_ScreenSound_Obj.Menus.Registrar
{
    internal class MenuRegistrarMusica : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            ExibirTituloOpt("Registro de música");
            Console.Write("\n Digte a banda da música que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];

                Console.Write("\nAgora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                if (banda.Albums.Any(a => a.Nome.Equals(tituloAlbum)))
                {
                    Album album = banda.Albums.First(a => a.Nome.Equals(tituloAlbum));

                    Console.Write("\nAgora digite a música que deseja registrar: ");
                    string nomeMusica = Console.ReadLine()!;

                    Console.Write("\nDigite a duração da música em segundos: ");
                    int duracao = int.Parse(Console.ReadLine()!);

                    Console.Write("\nDigite o gênero na qual ela pertence: ");
                    string genero = Console.ReadLine()!;

                    album.AddMusic(new Musica(banda, nomeMusica, new Genero(genero))
                    {
                        Duracao = duracao
                    });

                    Console.WriteLine($"A música {nomeMusica} do álbum {tituloAlbum} foi registrada com sucesso!");
                    Thread.Sleep(2000);

                    Console.Clear();


                }
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
