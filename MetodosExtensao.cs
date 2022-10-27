namespace CSharp_ExtensionsMethods
{
    public static class MetodosExtensao
    {
        public static double CalculaCaixaCantinaComDespesa(this Funcionario obj, List<Produto> produtos, double despesa)
        {
            double soma = 0;
            int quantidadeMensal = 30;
            foreach (var produto in produtos)
            {
                soma += produto.ValorAlimento * produto.QuantidadeItens;
            }
            return Math.Round(((soma* quantidadeMensal) - despesa), 2);
        }
    }
}
