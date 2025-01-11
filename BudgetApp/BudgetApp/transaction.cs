using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    internal class transaction
    {
        public int id { get; set; }
        public int amount { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public DateOnly date { get; set; }

    }
}
