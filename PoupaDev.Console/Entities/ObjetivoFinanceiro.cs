using PoupaDev.Console.Enums;

namespace PoupaDev.Console.Entities
{
    class ObjetivoFinanceiro
    {
    public int Id { get; private set; }
    public string Titulo { get; private set; }
    public decimal ValorObjetivo { get; private set; }
    public List<Operacao> Operacoes { get; private set; }
    public decimal Saldo => ObterSaldo();

    public ObjetivoFinanceiro(string titulo, decimal valorObjetivo)
    {
        Id = new Random().Next(0, 1000);
        Titulo = titulo;
        ValorObjetivo = valorObjetivo;

        Operacoes = new List<Operacao>();
    }
    public decimal ObterSaldo() {
        var totaDeposito = Operacoes.
        Where(o => o.Tipo == TipoOperacao.Deposito)
        .Sum(o => o.Valor);

        var totalSaque = Operacoes
        .Where(o => o.Tipo == TipoOperacao.Saque)
        .Sum(o => o.Valor);

        return totaDeposito - totalSaque;

    }
    public virtual string ImprimirResumo() {
        return " Objetivo: "
        + Titulo
        + ", Valor: " 
        + ValorObjetivo
        + " com Saldo Atual: "
        + Saldo;
    }
    }
}