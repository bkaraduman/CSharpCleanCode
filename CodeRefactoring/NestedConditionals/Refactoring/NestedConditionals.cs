using System;

namespace CodeRefactoring.Refactoring.NestedConditionals
{
    public class Customer
    {
        public int LoyaltyPoints { get; set; }

        public bool IsGoldCustomer()
        {
            return LoyaltyPoints > 100;
        }
    }

    public class Reservation
    {
        public Reservation(Customer customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }

        public DateTime From { get; set; }
        public Customer Customer { get; set; }
        public bool IsCanceled { get; set; }

        private bool LessThan(int maxHours)
        {
            return (From - DateTime.Now).TotalHours < maxHours;
        }
        public void Cancel()
        {
            if (IsCancellationPeriodOver())
                throw new InvalidOperationException("It's too late to cancel.");

            IsCanceled = true;
        }

        private bool IsCancellationPeriodOver()
        {
            return (Customer.IsGoldCustomer() && LessThan(24)) ||
                !Customer.IsGoldCustomer() && LessThan(48);
        }

    }
}
