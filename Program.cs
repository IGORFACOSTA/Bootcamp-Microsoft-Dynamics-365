class Program
{
    static void Main(string[] args)
    {
        Pessoa hospede = new Pessoa
        {
            Nome = "João",
            QuantidadeHospedes = 2
        };

        Suíte suite = new Suíte
        {
            Numero = "101",
            ValorDiaria = 150
        };

        Reserva reserva = new Reserva
        {
            Hospede = hospede,
            Suite = suite,
            DataInicio = new DateTime(2023, 5, 1),
            DataFim = new DateTime(2023, 5, 15)
        };

        int quantidadeDias = reserva.CalcularQuantidadeDias();
        decimal valorTotal = reserva.CalcularValorTotal();

        Console.WriteLine("Reserva para: " + hospede.Nome);
        Console.WriteLine("Suíte: " + suite.Numero);
        Console.WriteLine("Período: " + quantidadeDias + " dias");
        Console.WriteLine("Valor total: R$" + valorTotal);
    }
}
