namespace SupportBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataFormatter dataFormatter = new DataFormatter();
            List<Transaction> transactions = dataFormatter.TransactionReader();

            foreach (var transaction in transactions)
            {
                transaction.LogOutTransaction();
            }
        }
    }
}