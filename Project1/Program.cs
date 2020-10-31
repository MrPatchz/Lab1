using System;

namespace Project1
{
    class Program
    {
        static void Main(String[] args)
        {
            CashPayment p1 = new CashPayment(567.00);
            CashPayment p2 = new CashPayment(345.65) ;

            CreditCardPayment ccp1 = new CreditCardPayment(255.25, "Elton John", 444444);
            CreditCardPayment ccp2 = new CreditCardPayment(478.59, "James Dean", 653564);

            p1.PaymentDetails();
            p2.PaymentDetails();
            ccp1.PaymentDetails();
            ccp2.PaymentDetails();

        }
    }
    class Payment
    {
        private double amount;
        public Payment()
        {
            this.amount = 0.0;
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Payment (double amount)
        {
            this.amount = amount;
        }
        public void PaymentDetails() {
                Console.WriteLine("Your payment amount is " + amount);
            }

    }
    class CashPayment : Payment
    {
        public CashPayment(double amount)
        {
            this.Amount = amount;
        }
        public void PaymentDetails()
        {
            Console.WriteLine("Cash payment for the amount of " + Amount);
        }
    }
    class CreditCardPayment : Payment
    {
        private String name;
        private int cardNumber;
        public CreditCardPayment (double amount, String name, int cardNumber)
        {
            this.Amount = amount;
            this.name = name;
            this.cardNumber = cardNumber;
        }
        public void PaymentDetails()
        {
            Console.WriteLine("Credit card payment for the amount of " + Amount + " using card " + cardNumber + " with the card owner name, " + name);
        }
    }
}
