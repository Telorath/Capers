using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capers
{
    public interface IHealth
    {
        int Health
        {
            get;
            set;
        }
        int MaxHealth
        {
            get;
            set;
        }
        void GetHit(HitStruct Hit);
    }
}
