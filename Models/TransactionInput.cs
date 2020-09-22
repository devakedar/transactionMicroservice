using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionModule.Models
{
    public class TransactionInput
    {
        [Required]
        public int AccountId { get; set; }
        [Required]  
        public int Balance { get; set; }
       
    }


}
