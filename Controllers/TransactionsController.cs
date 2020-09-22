using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransactionModule.Models;


namespace TransactionModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {

        public static List<TransactionInput> inputs = new List<TransactionInput>
        {
            new TransactionInput{AccountId=11011,Balance=2500},
            new TransactionInput{AccountId=11012,Balance=2700},
            new TransactionInput{AccountId=11013,Balance=1500}
        };

        //. TransactionInput obj = new TransactionInput();

        // GET: api/<CustomerController>


        // POST api/<CustomerController>
        [HttpPost]
        public string Deposit(int Id, int amount)
        {
            TransactionInput obj = inputs.Find(m => m.AccountId == Id);
            //(a => a.AccountId == value.AccountId);
            obj.Balance += amount;
            return "Amount credited";

        }

        [HttpPost("[action]")]
        public string Withdraw(int Id, int amount)
        {
            TransactionInput obj1 = inputs.Find(m => m.AccountId == Id);
            //(a => a.AccountId == value.AccountId);
            // var minBal = 500;
            if ((obj1.Balance - amount) > 500)
            {
                obj1.Balance -= amount;
                return "Withdrawal Successfull";
            }
            else
                return "Withdrawal Denied";

        }


        [HttpGet]
        public IEnumerable<TransactionInput> Get()
        {
            return inputs;
        }

        public List<Transfers> transfers = new List<Transfers>
        {
            new Transfers{From_Account_Id=11011,From_Balance=2000,To_Account_Id=11012,To_Balance=1500}
        };

        [HttpPost("transfer")]
        public string Transfer(int Fromaccount, int toaccount,int amount)
        {
            Transfers obj1 = transfers.Find(m => m.From_Account_Id == Fromaccount);
            Transfers obj = transfers.Find(m => m.To_Account_Id == toaccount);


            if ((obj1.From_Balance - amount) > 500)
            {
                obj1.From_Balance -= amount;
                obj.To_Balance += amount;
                return "Tranfer Successfull";
            }
            else
                return "Tranfer Denied";

        }
                        

    }
}
