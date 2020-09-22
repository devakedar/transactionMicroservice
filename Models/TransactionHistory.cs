using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionModule.Models
{
    public class TransactionHistory
    {
        public int Transaction_ID { get; set; }
        public int Account_ID { get; set; }
        public int Counterparty_ID { get; set; }
        public string  PaymentMethod{ get; set; }
        public int Service_ID { get; set; }
        public string transactionStatus { get; set; }
        public string transactionType { get; set; }
        public DateTime Date_of_transcaton { get; set; }
        public int Amount { get; set; }


    }

    /*public enum PaymentMethodCode
    {
        Amex=1,
        BankTransfer,
        Cash,
        Cheque,
        MasterCard,
        Visa,
        DinersClub
    }*/

   /* public enum TransactionStatusCode
    {
        Completed,
        Cancelled,
        Disputed
    }*/

    /*public enum TransactionType
    {
        Adjustment,
        Paymment,
        Refund,
        Withdraw,
        Deposit
    }*/
}
