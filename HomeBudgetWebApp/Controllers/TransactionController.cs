using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeBudgetWebApp.ViewModels;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeBudgetWebApp.Controllers
{
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {

        [HttpGet("{id}")]
        public IActionResult getTransactionByID(int id)
        {
            var transactionId = new TransactionViewModel()
            {
                Id = id,
                Amount = 23,
                Title = "ssss",
                Note = "dadsdasdasdasd",
                Category = "Food",
                IDVallet = 2,
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            };

            return new JsonResult(
                transactionId,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }

        // GET api/<controller>/5
        [HttpGet("Latest/{num?}")]
        public IActionResult Latest(int num = 10)
        {
            var sampleTransactions = new List<TransactionViewModel>();

            sampleTransactions.Add(new TransactionViewModel()
            {
                Id = 1,
                Amount = 23,
                Title = "ssss",
                Note = "dadsdasdasdasd",
                Category = "Food",
                IDVallet = 2,
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            });

            for (int i = 2; i < num; i++)
            {
                sampleTransactions.Add(new TransactionViewModel()
                {
                    Id = i,
                    Amount = 23,
                    Title = "ssss",
                    Note = "dadsdasdasdasd",
                    Category = "Food",
                    IDVallet = 3,
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }

            return new JsonResult(
                sampleTransactions,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }

    }
}
