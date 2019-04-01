using System;

namespace NotaFiscal
{
    public class ItensNotaFiscal : NotaFiscal
    {
        public string Produtos { get; set; }
        public int CodigoDoProduto { get; set; }    

        public void MostrarItens()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════╗");
            Console.WriteLine("\t\t** ITENS **");
            Console.WriteLine("\n\tPRODUTO: " + Produtos +
                              "\n\tCÓDIGO DO PRODUTO: #" + CodigoDoProduto +
                              "\n\tPREÇO UNITÁRIO: R$ " + PrecoUnitario +
                              "\n\tQUANTIDADE: " + Quantidade +
                              " UNIDADE(S)");

            Console.WriteLine("\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            Console.WriteLine("\n\t\t** NOTA FISCAL **");
            Console.WriteLine("\n\tCÓDIGO DO CLIENTE: @" + CodigoDoCliente +
                              "\n\tTAXA DE ICMS: R$" + GetValorDeICMS() +
                              "\n\tVALOR TOTAL: R$" + GetValorTotalDosItens());
            Console.WriteLine("╚═══════════════════════════════════════════════╝");

        }
        
    }    
}
