using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capers
{
    public interface IDealsDamage
    {
        damageclass DamageClass
        {
            get;
            set;
        }
        damagetype DamageType
        {
            get;
            set;
        }
        HitStruct GetDamage();
    }
}
