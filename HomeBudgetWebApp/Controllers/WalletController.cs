using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeBudgetWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeBudgetWebApp.Controllers
{
    [Route("api/[controller]")]
    public class WalletController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult GetAllWallets()
        {
            var sampleWallets = new List<WalletViewModel>();

            sampleWallets.Add(new WalletViewModel()
            {
                Id = 1,
                Title = "sasa",
                Descryption = "agsglGOI",
                Icon = "DDDDD",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now

            });

            return new JsonResult(
                sampleWallets,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }

    }
}
