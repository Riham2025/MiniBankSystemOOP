using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankSystemOOP
{
    class Validator
    {
        // Validate name (non-empty, no digits)
        public bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && !name.Any(char.IsDigit);
        }

        // Validate National ID (exactly 8 digits)
        public bool IsValidNationalID(string nationalID)
        {
            return !string.IsNullOrWhiteSpace(nationalID) &&
                   nationalID.Length == 8 &&
                   nationalID.All(char.IsDigit);
        }

        // Validate password (length and confirmation)
        public bool IsValidPassword(string pw1, string pw2)
        {
            return pw1 == pw2 && pw1.Length >= 4;
        }

        // Validate deposit amount
        public bool IsValidDepositAmount(string input, out double amount)
        {
            return double.TryParse(input, out amount) && amount > 0;
        }
    }
}
