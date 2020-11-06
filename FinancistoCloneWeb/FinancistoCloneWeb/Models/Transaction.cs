using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Summary { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get;  set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
    }
}
