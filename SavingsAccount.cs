using System;
namespace BankEncapsulation
{
    public class SavingsAccount : PersonalInformation
    {
        public SavingsAccount()
        {
        }
// TODO Create a property for adding Savings Account.

        public bool isAddingSavings { get; set; }

// TODO Create a private field of type double named sbalance with a value of 0.

        private double s_balance = 0;

// TODO Set the properties of the public savBalance field.

        public double savBalance { get; set; }

// TODO Define a method named SavDeposit that will accept a double and store that value in the balance field.

        public void SavDeposit(double s_amount)
        {
            s_balance = s_amount;
        }

// TODO Define a method named "GetSavBalance()" that will return the amount stored in the "balance" field.

        public double GetSavBalance()
        {
            return s_balance;
        }

    }
}
