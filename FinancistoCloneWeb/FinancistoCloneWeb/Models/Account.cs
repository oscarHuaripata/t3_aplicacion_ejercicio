using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb.Models
{
    public class Account
    {
        public int Id { get; set; }        
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public string ImagePath { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Limit { get; set; }

        // relaciones
        public Type Type { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
