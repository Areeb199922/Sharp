using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    interface ISavingAccount
    {
        double Balance { get; }
        void Deposit();
        void Withdraw();

    }
}
