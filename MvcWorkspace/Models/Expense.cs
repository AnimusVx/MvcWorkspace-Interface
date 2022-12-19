﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcWorkspace.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Expense Name")]
        public string ExpenseName { get; set; }
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Yanlış Değer köşende ağlayabilirsin EZİK")]
        public int Amount { get; set; }
        
        [ForeignKey("ExpenseCategory")]
        public int C_Id {get; set;}
        public ExpenseCategory ExpenseCategory {get; set;}
    }
}
