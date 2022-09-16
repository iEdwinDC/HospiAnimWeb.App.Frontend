using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiAnimWeb.App.Frontend.Pages
{
    public class FindDoctorModel : PageModel
    {
        private readonly ILogger<FindDoctorModel> _logger;

        public FindDoctorModel(ILogger<FindDoctorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}