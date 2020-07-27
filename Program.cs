using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;

namespace BankEncapsulation
/*
 TODO Create a new Console Application in your repos folder
 TODO = DONE name it BankEncapsulation
 TODO = DONE Create a new Console Application in your repos folder
 TODO = DONE name it BankEncapsulation
 TODO = DONE Create a new public class named BankAccount
 TODO = DONE In your BankAccount class, create the following:
 TODO = DONE A private field of type double named balance with a value of 0
 TODO = DONE Define a method named Deposit that will accept a double and store that value in the balance field
 TODO = DONE Define a method named GetBalance that will return the amount stored in the balance field
 TODO = DONE In the main method of your application,
 TODO = DONE create a new instance of the BankAccount class.
 TODO = DONE Allow the user of the application to Deposit money and retrieve their balance through the console.
 TODO = DONE** BONUS Use a property for Encapsulation
 TODO = DONE Add a SavingsAccount class and a CreditCard Class to the project - give each properties.
 TODO = DONE In the main program, ask the user if they want to create a Savings Account and A Credit Card
 TODO = DONE Add the savings account and credit card as properties for the customer.*/
{
    class Program
    {
        public static void Main(string[] args)
        {
/*TODO In the Main method, create an instance of the PersonalInformation class. */ 

            var NewPhoneWhoDis = new PersonalInformation();

/*TODO Ask the user to input their phone number. */

            Console.WriteLine("Enter your 10 digit phone number");
            NewPhoneWhoDis.NumberFormatted = Console.ReadLine();

/*TODO Display the newly formatted phone number to the user.*/

            Console.WriteLine($"{NewPhoneWhoDis.NumberFormatted} is your phone number");

/*TODO Create a new public class, "BankAccount.cs". */

/*TODO Create a new instance of "BankAccunt.cs". */

            var ba = new BankAccount();

/*TODO Create a new instance of the BankAccount class to pass through
       the GetBalance() Method. */

            var bb = ba.GetBalance();

/*TODO Show the user their current balance. */ 

            Console.WriteLine($" Your current balance is {bb} \nPlease, enter your deposit amount.");

/*TODO Allow the user to Deposit money and retrieve their
       balance through the console. Use the ".Parse()" method to convert type
       double to type string.*/

            var depAmount = double.Parse(Console.ReadLine());

/*TODO Take users input, store in variable, add to balance. */

            var ubalance = bb + depAmount;

/*TODO Write user's updated balance to the console. */

            Console.WriteLine($" Your new balance is {ubalance}.");

/*TODO Ask the user if they want to create a Savings Account and A Credit Card */

            Console.WriteLine($"Would you like to add a Savings Account?");

/* TODO Add the savings account and credit card as properties for the customer.
             * Looking for the parameter that correspods to the info */

            var addSavingsAccount = new PersonalInformation().SavingsAccount;
            var addCreditCard = new PersonalInformation().CreditCard;


            var savResponse = Console.ReadLine();

            switch (savResponse.ToLower())
            {
                case "yes": // is adding savings

/*TODO nest switch statements to accomodate user input */

                    Console.WriteLine("Great! Your info has been added." + 
                        "Would you like to apply for a credit card?");  // asking to add credit card

                    var ccResponse = Console.ReadLine();
                    switch(ccResponse.ToLower())
                    {
                        case "yes":
                            Console.WriteLine("Great! Your info has been added. Thank you, have a nice day!"); // confirmation credit card added.
                            break;
                        case "no":
                            Console.WriteLine("Ok, maybe another time, take care!"); // confirmation credit card not added.
                            break;
                        case null:
                            Console.WriteLine("It's never to early to build your credit!");
                            break;
                    }

                    break;

                case "no":
                    Console.WriteLine("Ok, would you like to apply for a credit card?");

                    var ccResponse2 = Console.ReadLine();

                    switch (ccResponse2.ToLower())
                    {
                        case "yes":
                            Console.WriteLine("Great! Your info has been added. Thank you, have a nice day!"); // confirmation credit card added.
                            break;

                        case "no":
                            Console.WriteLine("Ok, maybe another time, take care!"); // confirmation credit card not added.
                            break;

                        case null:
                            Console.WriteLine("It's never to early to build your credit!");
                            break;
                    }
                    break;

                case null:
                    Console.WriteLine("It's never to early to start saving!");
                    break;

            }
        }
    }
}

