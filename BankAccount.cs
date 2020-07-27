using System;

namespace BankEncapsulation

/*  SETUP
 TODO = DONE Create a new Console Application in your repos folder
 TODO = DONE name it BankEncapsulation
 TODO = DONE Create a new Console Application in your repos folder
 TODO = DONE name it BankEncapsulation

    HERE
 TODO = DONE Create a new public class named BankAccount

 TODO = DONE In your BankAccount class, create the following:

 TODO = DONE 1. A private field of type double
                    - named balance with a value of 0
 TODO = DONE 2. A Deposit() method that will accept a double
                    - store that value in the balance field

 TODO = DONE Declare a method named GetBalance that will
        return the amount stored in the balance field.

    MAIN
 TODO = DONE In the main method of your application,
 TODO = DONE create a new instance of the BankAccount class.
 TODO = DONE Allow the user of the application to Deposit money and retrieve their balance through the console.
 TODO = DONE** BONUS Use a property for Encapsulation
*/


{
    public class BankAccount
    {

// TODO Create a private field of type double named balance with a value of 0
        private double balance = 100;

// TODO Set the properties of the public Balance field.

        public double Balance { get; set; }
        
// TODO
        //Define a method named Deposit that will accept a double and store that value in the balance field
        
        
        public void Deposit(double amount)
        {
            balance = amount;
        }
// TODO
        //Define a method named GetBalance that will return the amount stored in the balance field

        public double GetBalance()
        {
            return balance;
        }
    }
}
// Notes and Definitions 
// "BankAccount.balance" is a private class member of type field used only inside of the class
// for the purpose of hiding the information contained in the class property. See "GetBalance()" method
// Encapsulation is information hiding. In this case, we are hiding the "private balance" field
// within the "public Balance" property.

