using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capers
{
    public enum damageclass
    {
        physical,
        energy,
        mental
    }
    public enum damagetype
    {
        impact,
        piercing,
        slashing,
        heat,
        cold,
        sonic,
        electric,
        mental,
        arcane
    }
    public abstract class Power : Entity, IDisplayable
    {
        public int mBaseCost;
        public int mRealCost;
        public int mActiveCost;
        public int mEnergyCost;
        public float mAdvantageMult;
        public float mDisadvantageMult;
        public IEnergy EnergySource;
        public Entity User;
        public virtual void Display()
        {
        }
        public bool CanUse()
        {
            if (this is IEnergy)
            {
                return true;
            }
            if (EnergySource.Energy >= mEnergyCost)
            {
                return true;
            }
            else { return false; }
        }
        protected void DrawEnergy()
        {
            EnergySource.Energy -= mEnergyCost;
        }
        public virtual void calculatecost()
        {
            //Exists to be overridden.
        }
    }
    public abstract class Buff : Power
    {
        public virtual void Apply(Character Target)
        {
            //Exists to be overriden;
        }
        public virtual void Remove(Character Target)
        {
            //Exists to be overrriden
        }
    }
    public class EnergyBlast : Power, IDealsDamage
    {
        int mDice = 1;
        public damagetype mDamageType;

        public int Dice
        {
            get
            {
                return mDice;
            }

            set
            {
                mDice = value;
            }
        }

        public override void Display()
        {
            Console.WriteLine("Power Name: " + Name);
            Console.WriteLine("Power Type: Energy Blast");
            Console.WriteLine("Dice: " + Dice + "d6");
            Console.WriteLine("Damage Type: " + Enum.GetNames(typeof(damagetype))[(int)mDamageType]);
            Console.WriteLine("Point Cost: " + mActiveCost + "(Active)/" + mRealCost + "(real)");
            Console.WriteLine("Energy Cost: " + mEnergyCost);
        }
        public override void calculatecost()
        {
            mBaseCost = Dice * 10;
            mActiveCost = (int)(mBaseCost * (1 + mAdvantageMult));
            mRealCost = (int)(mActiveCost / (1 + mDisadvantageMult));
            mEnergyCost = mActiveCost / 10;
        }
        public HitStruct GetDamage()
        {
            HitStruct Damage = new HitStruct();
            for (int i = 0; i < Dice; i++)
            {
                int damage = Program.prng.Next(1, 7);
                if (damage > 1)
                {
                    Damage.HealthDamage += 1;
                }
                if (damage == 6)
                {
                    Damage.HealthDamage += 1;
                }
                Damage.StunDamage += damage;
            }
            DrawEnergy();
            return Damage;
        }
    }
    public class EnergyReserve : Power, IEnergy
    {
        int mEnergy;
        int mMaxEnergy;
        public int Energy
        {
            get
            {
                return mEnergy;
            }
            set
            {
                mEnergy = value;
                if (mEnergy > mMaxEnergy)
                {
                    mEnergy = mMaxEnergy;
                }
            }
        }
        public int MaxEnergy
        {
            get
            {
                return mMaxEnergy;
            }
            set
            {
                mMaxEnergy = value;
            }
        }
        public override void Display()
        {
            Console.WriteLine("Power Name: " + Name);
            Console.WriteLine("Power Type: Endurance Reserve");
            Console.WriteLine("Energy: " + Energy + "/" + MaxEnergy);
            Console.WriteLine("Point Cost: " + mActiveCost + "(Active)/" + mRealCost + "(real)");
        }
    }
    public class HandtoHand : Power, IDealsDamage
    {
        int MeleeBonusDice = 0;
        public HitStruct GetDamage()
        {
            calculatecost();
            int Dice = 0;
            if (User is Character)
            {
                Dice = (User as Character).Str / 10;
            }
            Dice += MeleeBonusDice;
            HitStruct Damage = new HitStruct();
            for (int i = 0; i < Dice; i++)
            {
                int damage = Program.prng.Next(1, 7);
                if (damage > 1)
                {
                    Damage.HealthDamage += 1;
                }
                if (damage == 6)
                {
                    Damage.HealthDamage += 1;
                }
                Damage.StunDamage += damage;
            }
            DrawEnergy();
            return Damage;
        }
        public override void calculatecost()
        {
            mBaseCost = MeleeBonusDice * 10 + (User as Character).Str;
            mActiveCost = (int)(mBaseCost * (1 + mAdvantageMult));
            mRealCost = (int)(mActiveCost / (1 + mDisadvantageMult));
            mEnergyCost = mActiveCost / 10;
        }
    }
    public class Armor : Buff
    {
        int RPDEF;
        int REDEF;
        public override void Apply(Character Target)
        {
            Target.RPDEF += RPDEF;
            Target.REDEF += REDEF;
        }
        public override void Remove(Character Target)
        {
            Target.RPDEF -= RPDEF;
            Target.REDEF -= REDEF;
        }
    } 
    public struct HitStruct
    {
        public int HealthDamage;
        public int StunDamage;
        public damageclass DamageClass;
    }
}