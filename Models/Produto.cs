using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace CRM.Models;
public class Produto
{
    public string? Nome { get; set; }
    public string? Codigo { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataLancamento { get; set; }
    public decimal Valor { get; set; }
}
