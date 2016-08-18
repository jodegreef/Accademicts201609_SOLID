using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srp1
{
    public class BankAccount
    {
        public void Withdraw(long amount)
        {
            // withdraws the given amount and returns the transation success/failure status
        }

        public long GetAccountBalance()
        {
            // returns Account balance
            throw new NotImplementedException();
        }

        public TransactionHistory GetTransactionHistory(int lastXDays)
        {
            // returns a transaction history of last 'X' days
            throw new NotImplementedException();
        }

        public int RegisterComplaint(ComplaintDetails complaint)
        {
            // returns complaintId
            throw new NotImplementedException();
        }

        public Status GetComplaintProgressStatus(long complaintId)
        {
            // Returns the Status the progress of the given Complain ID
            throw new NotImplementedException();
        }
    }
}
