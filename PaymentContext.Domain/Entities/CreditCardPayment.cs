namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment
    {
        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}
