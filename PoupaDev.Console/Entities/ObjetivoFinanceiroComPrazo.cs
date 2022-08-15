using System;

namespace PoupaDev.Console.Entities
{
    class ObjetivoFinanceiroComPrazo : ObjetivoFinanceiro
    {
        public ObjetivoFinanceiroComPrazo(DateTime prazo, string titulo, decimal valorObjetivo)
         : base(titulo, valorObjetivo)
    {
        Prazo = prazo;
    }

    public DateTime Prazo { get; private set; }

    public override string ImprimirResumo()
    {
        base.ImprimirResumo();

        var diasRestantes = (Prazo - DateTime.Now).TotalDays;
        var valorRestante = ValorObjetivo - Saldo;

        return($"Faltam {diasRestantes} para o prazo de seu objetivo, e faltam R${valorRestante} para completar.");
    }
    }
}