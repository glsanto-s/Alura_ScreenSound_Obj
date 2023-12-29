using Alura_ScreenSound_Obj.Menus;
using Alura_ScreenSound_Obj.Menus.Avaliar;
using Alura_ScreenSound_Obj.Menus.Exibir;
using Alura_ScreenSound_Obj.Menus.Registrar;
using Alura_ScreenSound_Obj.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        string msgBoasVindas = "Boas vindas ao Screen Sound!";

        Dictionary<string, Banda> bandasRegistradas = new();
 
        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuRegistrarMusica());
        opcoes.Add(4, new MenuExibirBandas());
        opcoes.Add(5, new MenuAvaliarBanda());
        opcoes.Add(6, new MenuAvaliarAlbum());
        opcoes.Add(7, new MenuAvaliarMusica());
        opcoes.Add(8, new MenuExibirDetalhes());
        opcoes.Add(9, new MenuExibirAlbum());
        opcoes.Add(0, new MenuSair());

        void ExibirMsgBoasVindas()
        {
            Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
            Console.WriteLine(msgBoasVindas);
        }

        void ExibirOptMenu()
        {
            ExibirMsgBoasVindas();
            Console.WriteLine("\n1 - Registrar nova banda");
            Console.WriteLine("2 - Registrar novo álbum");
            Console.WriteLine("3 - Registrar nova música");
            Console.WriteLine("4 - Mostrar todas as bandas");
            Console.WriteLine("5 - Avaliar uma banda");
            Console.WriteLine("6 - Avaliar um álbum");
            Console.WriteLine("7 - Avaliar uma música");
            Console.WriteLine("8 - Exibir detalhes de uma banda");
            Console.WriteLine("9 - Exibir detalhes de um album");
            Console.WriteLine("0 - Sair");

            Console.Write("\nDigite a opção: ");
            int optEscolhida = int.Parse(Console.ReadLine()!);

            if (opcoes.ContainsKey(optEscolhida))
            {
                Menu menu = opcoes[optEscolhida];
                menu.Executar(bandasRegistradas);
                if (optEscolhida > 0) ExibirOptMenu();
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
        ExibirOptMenu();
    }
}

