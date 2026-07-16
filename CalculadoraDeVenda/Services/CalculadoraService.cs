namespace CalculadoraDeVenda.Services
{
    internal class CalculadoraService
    {
        public decimal CalcularVendaNacional(decimal custoEmReais)
        {
            decimal valorVenda = (custoEmReais + 50m) * 1.3m * 1.3m;

            return Math.Floor(valorVenda);
        }

        public decimal CalcularVendaImportacao(decimal custoEmDolares)
        {
            decimal valorVenda =
                (custoEmDolares + custoEmDolares * 0.10m + 20m)
                * 4m
                * 2.5m;

            return Math.Floor(valorVenda);
        }
    }
}