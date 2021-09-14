using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseInterface
{
    interface ISavingAccount
    {
        double Balance { get;}
        void deposit();
        void withdraw();
        
    }
}
