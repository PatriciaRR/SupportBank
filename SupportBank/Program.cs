using NLog;
using NLog.Config;
using NLog.Targets;

namespace SupportBank
{
    public class Program
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

            var config = new LoggingConfiguration();
            var target = new FileTarget { FileName = @"C:\Training\SupportBank\SupportBank\Logging.log", Layout = @"${longdate} ${level} - ${logger}: ${message}" };
            config.AddTarget("File Logger", target);
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, target));
            LogManager.Configuration = config;


            DataFormatter dataFormatter = new DataFormatter();
            List<Transaction> transactions = dataFormatter.TransactionReader();

            foreach (var transaction in transactions)
            {
                transaction.LogOutTransaction();
            }


            PersonalAccount personalAccount = new PersonalAccount();
            personalAccount.CreateAccountFromTransactions(transactions, args[1]);

            Console.WriteLine($"{args[1]}, £{personalAccount.CalculateTotalBalance()}");
            //dotnet run list "individual name"

        }
    }
}