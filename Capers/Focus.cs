using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capers
{
    public class Focus : Entity, IEnergy
    {
        List<Power> Powers;
        IEnergy EnergySource;
        public int Energy
        {
            get
            {
                if (EnergySource == null)
                    return 0;
                return EnergySource.Energy;
            }

            set
            {
                if (EnergySource == null)
                    return;
                EnergySource.Energy = value;
            }
        }

        public int MaxEnergy
        {
            get
            {
                if (EnergySource == null)
                    return 0;
                return EnergySource.MaxEnergy;
            }
            set
            {
                if (EnergySource == null)
                    return;
                EnergySource.MaxEnergy = value;
            }
        }
    }
}
