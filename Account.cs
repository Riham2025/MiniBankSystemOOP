using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankSystemOOP
{
    class Account
    {
        private  static string AccountNumber; // Static variable to hold the account number
        private static int accountnumberCounter = 0; // Counter for generating unique account numbers

        public string Name { get; set; } // Property to hold the account name
        public double Balance { get; private set; } // Property to hold the account balance
        public string NationalID { get; set; } // Property to hold the national ID
        public string phoneNumber { get; set; } // Property to hold the phone number

        public string Password { get; set; } // Property to hold the account password
        public bool IsActive { get; private set; } // Property to indicate if the account is active



    }
}
