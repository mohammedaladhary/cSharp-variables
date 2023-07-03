using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    internal class BankAccount
    {
        private const double sal = 250.000;
        private String accountNumber;
        private float salary;
        public String accNo
        {
            get { return accountNumber; }
            set { accountNumber = "0102 XXXX XXXX 3213"; }
        }
        public float accSalary
        {
            get { return salary; }
            set { salary = (float)sal; }
        }
    }
}
