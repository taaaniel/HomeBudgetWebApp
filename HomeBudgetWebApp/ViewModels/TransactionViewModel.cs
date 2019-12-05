using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetWebApp.ViewModels
{
    public class TransactionViewModel
    {
        public TransactionViewModel()
        {

        }

        public int Id { get; set; }
        public int Amount { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Category { get; set; }
        public string Vallet { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
