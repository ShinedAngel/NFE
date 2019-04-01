namespace NotaFiscal
{
    public class NotaFiscal
    {
        public int CodigoDoCliente { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        private double valorTotalDosItens;

        public double GetValorTotalDosItens()
        {
            return PrecoUnitario * Quantidade;
        }

        private void SetValorTotalDosItens(double PrecoUnitario, int Quantidade)
        {
            valorTotalDosItens = PrecoUnitario * Quantidade;
        }

        private double valorDeICMS;
        public double GetValorDeICMS()
        {
            return valorDeICMS = (PrecoUnitario * Quantidade) * 0.25;
        }

        private void SetValorDeICMS(double PrecoUnitario, int Quantidade)
        {
            valorDeICMS = (PrecoUnitario * Quantidade) * 0.25;
        }
    }
}
