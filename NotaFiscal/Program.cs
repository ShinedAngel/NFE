using System;

namespace NotaFiscal
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo OpcaoDoUsuario;
            GerarComponentesDanfe notaFiscal = new GerarComponentesDanfe();

            do
            {
                Console.WriteLine(
                    "\n\t\t[F1] NOVO CADASTRO" +
                    "\n\t\t[F2] LISTA DE CADASTRADOS" +
                    "\n\t\t[F8] SAIR");
                OpcaoDoUsuario = Console.ReadKey();
                Console.Clear();
                if (OpcaoDoUsuario.Key == ConsoleKey.F1)
                {
                    notaFiscal.CadastrarNovoProduto();
                    Console.Clear();
                }
                if (OpcaoDoUsuario.Key == ConsoleKey.F2)
                {
                    notaFiscal.MostrarCadastrosEfetuados();
                    Console.Clear();
                }
                Console.ReadKey();
            } while (OpcaoDoUsuario.Key != ConsoleKey.F8);
        }
    }
}
