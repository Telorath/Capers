using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capers
{
    public interface ICharges
    {
        int Charges
        {
            get;
            set;
        }
        int MaxCharges
        {
            get;
            set;
        }
    }
}
