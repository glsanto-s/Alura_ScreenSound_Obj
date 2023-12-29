using Alura_ScreenSound_Obj.Models;

namespace Alura_ScreenSound_Obj.Menus
{
    internal class Menu
    {
        public void ExibirTituloOpt(string titulo)
        {
            int qtdLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
        }
    }
}
