using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetWebApp.ViewModels
{
    public class WalletViewModel
    {
        public WalletViewModel()
        {

        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Descryption { get; set; }
        public string Icon { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

    }
}
