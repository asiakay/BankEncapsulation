using System;
using System.Text.RegularExpressions;



namespace BankEncapsulation
{
    public class PersonalInformation
    {
        public PersonalInformation()
        {
            //constructor
        }

/* TODO Add the savings account and credit card as properties for the customer. */

        public bool CreditCard { get; set; }

        public bool SavingsAccount { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        private string phoneNumber = "";

        public string NumberFormatted
        {
            //read
            get
            {
                return phoneNumber;
            }
            //write
            set
            {  
                phoneNumber = System.Text.RegularExpressions.Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");

            }
        }


    }
}



//Here
//Create a new class called PersonalInformation
//Done
//Create the following Properties that will contain the account holder’s personal information
//Done
//Here is the code for the set accessor, you can copy this into the set block for
//the NumberFormatted property: 
//phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
//Done
//Notice you will need the using directive at the top: 
//using System.Text.RegularExpressions;

//DONE
//In the Main method,
//create an instance of the
//PersonalInformation class and
//ask the user to input their phone number,
//then display the newly formatted phone number
//(NumberFormatted) to the user