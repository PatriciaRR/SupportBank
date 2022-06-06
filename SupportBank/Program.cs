namespace SupportBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataFormatter dataFormatter = new DataFormatter();
            List<Transaction> transactions = dataFormatter.TransactionReader();

            // foreach (var transaction in transactions)
            // {
            //     transaction.LogOutTransaction();
            // }


            PersonalAccount personalAccount = new PersonalAccount();
            personalAccount.CreateAccountFromTransactions(transactions, args[1]);

            Console.WriteLine($"{args[1]}, £{personalAccount.CalculateTotalBalance()}");

        }
    }
}