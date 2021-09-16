using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string acao = "")
        {
            try
            {
                if (acao.ToUpper() == "E")
                    throw new Exception("Não foi possível prosseguir.");

                _logger.LogInformation("Você deu um get!!!!");                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Seu código tem um bug!!!");
            }
        }
    }
}
