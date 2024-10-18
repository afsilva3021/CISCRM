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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

