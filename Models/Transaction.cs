using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLab1.Models
{
    public class Transaction
    {
        //Id, sourceAccNumber, operation, amount
        [Key]
        public int Tid { get; set; }
        [Required]
        public int SourceAccNumber { get; set; }
        [Required]
        public string Operation { get; set; }
        [Required]
        public decimal Amount { get; set; }

        //navigation property
        [ForeignKey(nameof(Owner))]
        public int UserId { get; set; }
        public virtual User Owner { get; set; }

        [ForeignKey(nameof(owner))]
        public int Id { get; set; }
        public virtual BankAccount owner { get; set; }



    }
}
