using System;

class Pessoa
{
    public string Nome { get; set; }
    public int QuantidadeHospedes { get; set; }
}

class Suíte
{
    public string Numero { get; set; }
    public decimal ValorDiaria { get; set; }
}

class Reserva
{
    public Pessoa Hospede { get; set; }
    public Suíte Suite { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public int CalcularQuantidadeDias()
    {
        TimeSpan duracao = DataFim - DataInicio;
        return duracao.Days;
    }

    public decimal CalcularValorTotal()
    {
        int quantidadeDias = CalcularQuantidadeDias();
        decimal valorTotal = quantidadeDias * Suite.ValorDiaria;

        if (quantidadeDias > 10)
        {
            valorTotal *= 0.9m; // Aplica o desconto de 10%
        }

        return valorTotal;
    }
}










