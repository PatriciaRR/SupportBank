using NLog;
using NLog.Config;
using NLog.Targets;

namespace SupportBank
{
    class DataFormatter
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        public List<Transaction> TransactionReader()
        {
            string path = @".\Transactions2014.csv";
            string path2015 = @".\Transactions2015.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            string[] lines2015 = System.IO.File.ReadAllLines(path2015);
            List<Transaction> transactions = new List<Transaction> { };

            foreach (string line in lines2015)
            {
                string[] words = line.Split(',');
                if (words[0] == "Date")
                {
                    continue;
                }

                DateTime date = default;

                try
                {
                    date = DateTime.Parse(words[0]);
                }

                catch (FormatException exception)
                {
                    Console.WriteLine($"Unable to process supplied data. Invalid DATE provided: {line} ");
                    Logger.Error($"Incorrect DATE information contained in the file provided, see {line}");
                    //throw e;
                    continue;
                }

                string from = words[1];
                string to = words[2];
                string narrative = words[3];
                decimal amount = 0;

                try
                {
                    amount = Decimal.Parse(words[4]);
                }

                catch (FormatException exception)
                {
                    Console.WriteLine($"Unable to process supplied data. Invalid AMOUNT provided: {line}");
                    Logger.Error($"Incorrect AMOUNT information contained in the file provided, see {line}");
                    //throw e;
                    continue;
                }


                Transaction newTransaction = new Transaction(date, from, to, narrative, amount);
                transactions.Add(newTransaction);
            }

            return transactions;
        }

    }




}