namespace SupportBank
{
    public class Transaction
    {
        public DateTime Date { get; }
        public string From { get; }
        public string To { get; }
        public string Narrative { get; }
        public decimal Amount { get; }

        public Transaction(DateTime date, string from, string to, string narrative, decimal amount)
        {
            Date = date;
            From = from;
            To = to;
            Narrative = narrative;
            Amount = amount;
        }

        public void LogOutTransaction()
        {
            Console.WriteLine($"On {Date.ToShortDateString()}, {From}. lent {To} £{Amount} for {Narrative}.");
        }

    }
}
