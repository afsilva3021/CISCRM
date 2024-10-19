using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRM.Models;

namespace CRM.Controllers;

public class CadastroController : Controller
{
    public IActionResult Produto()
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto
            {
                Nome = "Fone de Ouvido Sem Fio",
                Codigo = "FO-001",
                Descricao = "Fone de ouvido Bluetooth com cancelamento de ruído, bateria de longa duração e design ergonômico.",
                DataLancamento = DateTime.Parse("2005/02/11"),
                Valor = Decimal.Parse("299,90")
            },
             new Produto
            {
                Nome = "Smartwatch Fitness",
                Codigo = "SW-002",
                Descricao = "Relógio inteligente com monitoramento de atividades, batimentos cardíacos e notificações do celular.",
                DataLancamento = DateTime.Parse("1999/04/07"),
                Valor = Decimal.Parse("399,00")
            },
             new Produto
            {
                Nome = "Caderno Uplay",
                Codigo = "9958",
                Descricao = "Cafeteira com 12 xícaras e função de programação.",
                DataLancamento = DateTime.Parse("2005/02/11"),
                Valor = Decimal.Parse("249,00")
            },
             new Produto
            {
                Nome = "Fone de Ouvido Sem Fio",
                Codigo = "FO-001",
                Descricao = "Fone de ouvido Bluetooth com cancelamento de ruído, bateria de longa duração e design ergonômico.",
                DataLancamento = DateTime.Parse("2005/02/11"),
                Valor = Decimal.Parse("299,90")
            },
             new Produto
            {
                Nome = "Fone de Ouvido Sem Fio",
                Codigo = "FO-001",
                Descricao = "Fone de ouvido Bluetooth com cancelamento de ruído, bateria de longa duração e design ergonômico.",
                DataLancamento = DateTime.Parse("2005/02/11"),
                Valor = Decimal.Parse("299,90")
            },
             new Produto
            {
                Nome = "Fone de Ouvido Sem Fio",
                Codigo = "FO-001",
                Descricao = "Fone de ouvido Bluetooth com cancelamento de ruído, bateria de longa duração e design ergonômico.",
                DataLancamento = DateTime.Parse("2005/02/11"),
                Valor = Decimal.Parse("299,90")
            }
        };

        return View(produtos);
    }

    public IActionResult Cliente()
    {
        List<Cliente> clientes = new List<Cliente>();


        for (int i = 1; i <= 20; i++)
        {
            clientes.Add(new Cliente
            {
                ID = i,
                Nome = $"Cliente {i}",
                CNPJ = "10000000000000" + i, // Exemplo de CNPJ fictício incrementado
                Ativo = i % 2 == 0, // Alterna entre true e false
                RazaoSocial = $"Empresa {i} LTDA",
                Fantasia = $"Fantasia {i}",
                EiRg = 100000000 + i, // Exemplo de EI/RG fictício
                Nacionalidade = "Brasileiro",
                DataDeNascionalidade = new DateTime(1980 + i % 10, i % 12 + 1, i % 28 + 1).ToString("yyyy-MM-dd"),
                Municipal = i % 2 == 0 ? "São Paulo" : "Rio de Janeiro",
                DataCadastrada = DateTime.Now.AddDays(-i), // Data de cadastro fictícia
                Cep = 12345000 + i, // Exemplo de CEP fictício
                Endereco = $"Rua Exemplo {i}",
                Complemento = $"Apto {i * 10}",
                Numero = 100 + i
            });

            if (i == 1)
            {
                string dados = Convert.ToString(i);
                string Ativo = "Desativado";
                dados = Ativo;
                
            }
            else if (i == 2)
            {
                string dados = Convert.ToString(i);
                string Ativo = "Ativo";
                dados = Ativo;
            }
        }

        return View(clientes);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

