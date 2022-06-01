namespace SupportBank
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string To { get; }
        public string From { get; }
        public string Narrative { get; }

        public Transaction(decimal amount, DateTime date, string to, string from, string narrative)
        {
            Amount = amount;
            Date = date;
            To = to;
            From = from;
            Narrative = narrative;
        }

    }
}