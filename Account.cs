using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankSystemOOP
{
    public class Account
    {
        public static int accountnumberCounter = 0;

        public string AccountNumber { get; private set; }  // Now instance-level
        public string Name { get; set; }
        public double Balance { get; set; }
        public string NationalID { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public bool IsActive { get; set; }
        public bool Accept { get; set; }

        public Account(string name, string nationalID, string phoneNumber, string password)
        {
            Name = name;
            NationalID = nationalID;
            PhoneNumber = phoneNumber;
            Password = password;
            Balance = 0.0;
            IsActive = true;
            Accept = false;
            accountnumberCounter++;
            AccountNumber = "AC" + accountnumberCounter.ToString("D4");
        }

        public Account()
        {
            Name = "Default Name";
            NationalID = "0000000000";
            PhoneNumber = "0000000000";
            Password = "defaultPassword";
            Balance = 0.0;
            IsActive = true;
            Accept = false;
            accountnumberCounter++;
            AccountNumber = "AC" + accountnumberCounter.ToString("D4");
        }











        // Deposit Method
        public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    TransactionHistory.Add($"Deposited: {amount:C} | New Balance: {Balance:C}");
                }
            }

            // Withdraw Method
            public bool Withdraw(double amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    TransactionHistory.Add($"Withdrew: {amount:C} | New Balance: {Balance:C}");
                    return true;
                }
                else
                {
                    TransactionHistory.Add($"Failed withdrawal: {amount:C} | Insufficient balance");
                    return false;
                }
            }

            // Show Balance
            public void ShowBalance()
            {
                Console.WriteLine($"Account {AccountNumber} - Owner: {OwnerName}");
                Console.WriteLine($"Current Balance: {Balance:C}");
            }

            // Show transaction history
            public void ShowTransactionHistory()
            {
                Console.WriteLine($"Transaction History for Account {AccountNumber}:");
                foreach (var entry in TransactionHistory)
                {
                    Console.WriteLine(entry);
                }
            }
    }    


}   

