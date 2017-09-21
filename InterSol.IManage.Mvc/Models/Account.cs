using System.Collections.Generic;

namespace InterSol.IManage.Mvc.Models
{
    public class Account
    {
        public Account()
        {
            this.Transactions = new HashSet<Transaction>();
        }

        public int AccountId { get; set; }
        public int PersonId { get; set; }
        public string AccountNumber { get; set; }
        public decimal OutstandingBalance { get; set; }

        public virtual Person Person { get; set; }        
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}