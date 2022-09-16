using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiAnimWeb.App.Frontend.Pages
{
    public class FindPetModel : PageModel
    {
        private readonly ILogger<FindPetModel> _logger;

        public FindPetModel(ILogger<FindPetModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
