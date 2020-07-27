using System;
namespace BankEncapsulation
{
    public class CreditCard
    {
        public CreditCard()
        {
        }

// TODO Create a property for adding CreditCard. 

        public bool isAddingCredit { get; set; }

// TODO Create a private field of type double named ccbalance with a value of 0.

        private double ccbalance = 0;

// TODO Set the properties of the public CCBalance field.

        public double CCBalance { get; set; }

// TODO Define a method named CCPurchase that will accept a double and store that value in the balance field.

        public void CCPurchase(double cc_owed)
        {
            ccbalance = cc_owed;
        }

// TODO Define a method named "GetCCBalance()" that will return the amount stored in the "balance" field.

        public double GetCCBalance()
        {
            return ccbalance;
        }

    }
}
