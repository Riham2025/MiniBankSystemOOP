using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankSystemOOP
{
    class Account
    {
        public  static string AccountNumber; // Static variable to hold the account number
        public static int accountnumberCounter = 0; // Counter for generating unique account numbers

        public string Name { get; set; } // Property to hold the account name
        public double Balance { get; set; } // Property to hold the account balance
        public string NationalID { get; set; } // Property to hold the national ID
        public string phoneNumber { get; set; } // Property to hold the phone number

        public string Password { get; set; } // Property to hold the account password
        public bool IsActive { get; set; } // Property to indicate if the account is active
        public bool Accept { get; set; } // Property to indicate if the account is accepted

        // Constructor to initialize the account with a name, national ID, phone number, and password
        public Account(string name, string nationalID, string phoneNumber, string password)
        {
            Name = name;
            NationalID = nationalID;
            this.phoneNumber = phoneNumber;
            Password = password;
            IsActive = true; // Set the account as active by default
            Accept = false; // Set the account as not accepted by default
            accountnumberCounter++; // Increment the counter for unique account numbers
            AccountNumber = "AC" + accountnumberCounter.ToString("D4"); // Generate a unique account number
        }

        // defult constructor
        public Account() {
            NationalID = "0000000000"; // Set a default national ID
            Password = "defaultPassword"; // Set a default password
            phoneNumber = "0000000000"; // Set a default phone number
            Balance = 0.0; // Initialize the balance to zero
            Name = "Default Name"; // Set a default name
            IsActive = true; // Set the account as active by default
            Accept = false; // Set the account as not accepted by default
            accountnumberCounter++; // Increment the counter for unique account numbers
            AccountNumber = "AC" + accountnumberCounter.ToString("D4"); // Generate a unique account number
        }

    }
}
