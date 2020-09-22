using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionModule.Models
{
    public class Transfers
    {
        public int From_Account_Id { get; set; }
        public int To_Account_Id { get; set; }
        public int From_Balance { get; set; }
        public int To_Balance { get; set; }
    }
}
