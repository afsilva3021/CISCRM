using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models;
public class Cliente
{
    public int ID { get; set; }
    public string? Nome { get; set; }
    public string? CNPJ { get; set; }
    public bool Ativo { get; set; }
    public string? RazaoSocial { get; set; }
    public string? Fantasia { get; set; }
    public int EiRg { get; set; }
    public string? Nacionalidade { get; set; }
    public string? DataDeNascionalidade { get; set; }
    public string? Municipal { get; set; }
    public DateTime DataCadastrada { get; set; }
    public int Cep { get; set; }
    public string? Endereco { get; set; }
    public string? Complemento { get; set; }
    public int Numero { get; set; }
}