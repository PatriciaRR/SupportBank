namespace SupportBank
{
    public class Person
    {
        public string Name { get; }
        public List<Transaction> OutGoingPayment { get; }
        public List<Transaction> InComingPayment { get; }

        public Person(string name, List<Transaction> outGoingPayment, List<Transaction> inComingPayment)
        {
            Name = name;
            OutGoingPayment = outGoingPayment;
            InComingPayment = inComingPayment;
        }
    }
}