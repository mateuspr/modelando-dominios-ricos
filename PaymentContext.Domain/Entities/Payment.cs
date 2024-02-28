using System.Reflection.Metadata;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment 
    {
        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Payer { get; private set; }
        public Document Document { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
    }
}