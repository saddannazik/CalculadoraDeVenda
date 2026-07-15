namespace CalculadoraDeVenda.Services
{
    internal class CalculadoraService
    {
        public decimal CalcularVenda(decimal valorCusto)
        {
            decimal valorVenda = (valorCusto + 50m) * 1.3m * 1.3m;

            return Math.Floor(valorVenda);
        }
    }
}