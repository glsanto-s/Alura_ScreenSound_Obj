using Alura_ScreenSound_Obj.Models;
using OpenAI_API;

namespace Alura_ScreenSound_Obj.Menus.Registrar
{
    internal class MenuRegistrarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            ExibirTituloOpt("Registro das bandas:");
            Console.Write("\n Digite o nome da banda que deseja registrar: ");
            string nomeBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeBanda);
            bandasRegistradas.Add(nomeBanda, banda);

            //API OpenAI mas que tem prazo de validade

            //var client = new OpenAIAPI("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");
            //var chat = client.Chat.CreateConversation();

            //chat.AppendSystemMessage($"Resuma a banda {nomeBanda} em 1 parágrafo. Adote um estilo informal.");

            //string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
            //banda.Resumo = resposta;

            Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
            Console.WriteLine("\nDigite algo para voltar");
            Console.ReadKey();

            Console.Clear();
        }
    }
}
