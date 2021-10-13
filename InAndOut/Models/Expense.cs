using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Expense")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(1.0, double.MaxValue, ErrorMessage ="Amount must be greater than 0!")]
        public double Ammount { get; set; }
        [DisplayName("Expense Type")]
        public int? ExpenseTypeId { get; set; }
        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType ExpenseType { get; set; }
    }
}
