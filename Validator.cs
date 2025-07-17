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
    }
}
