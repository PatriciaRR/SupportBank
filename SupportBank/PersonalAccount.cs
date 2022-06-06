namespace SupportBank
{
    public class PersonalAccount
    {
        public string Name { get; set; }
        public List<Transaction> OutGoingPayment { get; set; }
        public List<Transaction> InComingPayment { get; set; }



        public void CreateAccountFromTransactions(List<Transaction> transactions, string name)
        {
            OutGoingPayment = new List<Transaction>();
            InComingPayment = new List<Transaction>();

            for (int i = 0; i < transactions.Count; i++)
            {
                Transaction transaction = transactions[i];

                if (transaction.From == name)
                {
                    OutGoingPayment.Add(transaction);
                }

                if (transaction.To == name)
                {
                    InComingPayment.Add(transaction);
                }
            }

        }

        public decimal CalculateTotalBalance()
        {
            decimal balance = 0;

            for (int i = 0; i < OutGoingPayment.Count; i++)
            {
                balance -= OutGoingPayment[i].Amount;
            }

            for (int i = 0; i < InComingPayment.Count; i++)
            {
                balance += InComingPayment[i].Amount;
            }

            return balance;
        }

    }
}

//single out data in transactions according to name
//filter 'from' and 'to' data
//Sum of outgoing - 
//Sum of incoming




