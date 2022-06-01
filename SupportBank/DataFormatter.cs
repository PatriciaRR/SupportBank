
// get transactions file ✔️
// split file into separate lines ✔️
// split each line up into an array ✔️
// format each line into a transaction
// return a list of transactions 
namespace SupportBank
{
    class DataFormatter
    {
        public List<Transaction> TransactionReader()
        {
            string path = @".\Transactions2014.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            List<Transaction> transactions = new List<Transaction> { };

            foreach (string line in lines)
            {
                string[] words = line.Split(',');
                if (words[0] == "Date")
                {
                    continue;
                }
                DateTime date = DateTime.Parse(words[0]);
                string from = words[1];
                string to = words[2];
                string narrative = words[3];
                decimal amount = Decimal.Parse(words[4]);

                Transaction newTransaction = new Transaction(date, from, to, narrative, amount);
                transactions.Add(newTransaction);
            }

            return transactions;
        }
    }


}