using System;
using System.Collections.Generic;

namespace NotaFiscal
{
    public class GerarComponentesDanfe
    {
        private List<ItensNotaFiscal> Lista = new List<ItensNotaFiscal>();
        private ItensNotaFiscal Itens;
        
        public void CadastrarNovoProduto()
        {
            Itens = new ItensNotaFiscal();

            Console.WriteLine("\t\tNOME DO PRODUTO: ");
            Console.Write("\t\t");
            Itens.Produtos = Console.ReadLine();

            Console.WriteLine("\t\tPREÇO DO PRODUTO: ");
            Console.Write("\t\tR$ ");
            Itens.PrecoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\t\tQUANTIDADE DE PRODUTO(S): ");
            Console.Write("\t\t");
            Itens.Quantidade = Convert.ToInt32(Console.ReadLine());
            
            int[] codigoCliente = new int[1];
            Random random = new Random();
            for (int i = 0; i < codigoCliente.Length; i++)
            {
                codigoCliente[i] = random.Next(2000000, 10000000);
                Itens.CodigoDoCliente = codigoCliente[i];
                Console.WriteLine("\t\tCÓDIGO DO CLIENTE: " + codigoCliente[i]);
            }

            int[] CodigoProduto = new int[1];
            Random codigoAleatorio = new Random();

            for (int i = 0; i < CodigoProduto.Length; i++)
            {
                CodigoProduto[i] = codigoAleatorio.Next(200000, 1000000);
                Itens.CodigoDoProduto = CodigoProduto[i];
                Console.WriteLine("\t\tCÓDIGO DO PRODUTO: " + CodigoProduto[i]);
            } 

            if (ChecarCodigoDoProduto(Itens.CodigoDoProduto) == null) 
            { 
              Lista.Add(Itens); 
              Console.WriteLine("\n\t\tCADASTRO REALIZADO COM SUCESSO!");
              Console.WriteLine("\n\t\tPRESSIONE [F8] DUAS VEZES PARA VOLTAR AO MENU PRINCIPAL");
            } 
            else 
            { 
              Console.WriteLine("\t\tO CÓDIGO DO PRODUTO ESTÁ REPETIDO!"); 
            } 
            Console.ReadKey(); 
        } 

        public void MostrarCadastrosEfetuados() 
        { 
            foreach (ItensNotaFiscal item in Lista) 
            {
                item.MostrarItens();               
            } 
            Console.ReadKey(); 
        }  

        private ItensNotaFiscal ChecarCodigoDoProduto(int Codigo)
        {
            foreach(ItensNotaFiscal item in Lista)
            {
                if (item.CodigoDoProduto == Codigo)
                {
                    return item;
                }
            }
            return null;
        }  
    }
}
