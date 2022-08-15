using PoupaDev.Console.Enums;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace PoupaDev.Console.Entities
{
    class Operacao
    {
    public int Id { get; private set; }
    public decimal Valor { get; private set; }
    public TipoOperacao Tipo { get; private set;}
    public int IdObjetivo { get; private set; }

    public Operacao(decimal valor, TipoOperacao tipo, int idObjetivo)
    {
       Id = new Random().Next(0, 1000);
        Valor = valor;
        Tipo = tipo;
        IdObjetivo = idObjetivo;
    }
    
    }
}