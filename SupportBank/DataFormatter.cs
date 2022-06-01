
// get transactions file 
// split file into separate lines
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
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            return new List<Transaction> { };
        }
    }


}