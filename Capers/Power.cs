using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capers;

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
    [Serializable]
    public abstract class Power : Entity, IDisplayable
    {
        protected int mBaseCost;
        protected int mRealCost;
        protected int mActiveCost;
        protected int mEnergyCost;
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
        public int PointCost
        {
           get { return mRealCost; }
        }
    }
    [Serializable]
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
[Serializable]
    public class EnergyBlast : Power, IDealsDamage
    {
        int mDice = 1;
        public damagetype mDamageType;
        public damageclass mDamageClass = damageclass.energy;
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

        public damagetype DamageType
        {
            get
            {
                return mDamageType;
            }

            set
            {
                mDamageType = value;
            }
        }

        public damageclass DamageClass
        {
            get
            {
                return mDamageClass;
            }

            set
            {
                mDamageClass = value;
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
            Damage.DamageClass = DamageClass;
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
    [Serializable]
    public class EnergyReserve : Power, IEnergy, IRecovery
    {
        int mEnergy;
        int mMaxEnergy;
        int mRecovery = 1;
        int mUsedBy = 0;
        public int UsedBy
        {
            get
            {
                return mUsedBy;
            }
            set
            {
                mUsedBy = value;
            }
        }
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

        public int Recovery
        {
            get
            {
                return mRecovery;
            }

            set
            {
                mRecovery = value;
            }
        }

        public override void Display()
        {
            Console.WriteLine("Power Name: " + Name);
            Console.WriteLine("Power Type: Endurance Reserve");
            Console.WriteLine("Energy: " + Energy + "/" + MaxEnergy);
            Console.WriteLine("Point Cost: " + mActiveCost + "(Active)/" + mRealCost + "(real)");
        }
        public void TakeRecovery()
        {
            Energy += 1;
        }
        public override void calculatecost()
        {
            mBaseCost = MaxEnergy / 2 + Recovery * 2;
            mActiveCost = (int)(mBaseCost * (1 + mAdvantageMult));
            mRealCost = (int)(mActiveCost / (1 + mDisadvantageMult));
            mEnergyCost = 0;
        }
    }
    [Serializable]
    public class HandtoHand : Power, IDealsDamage
    {
        public int MeleeBonusDice = 0;
        private damagetype mDamageType;
        private damageclass mDamageClass = damageclass.physical;

        public damagetype DamageType
        {
            get
            {
                return mDamageType;
            }

            set
            {
                mDamageType = value;
            }
        }

        public damageclass DamageClass
        {
            get
            {
                return mDamageClass;
            }

            set
            {
                mDamageClass = value;
            }
        }

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
            Damage.DamageClass = DamageClass;
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
    [Serializable]
   public class KillingAttack : Power, IDealsDamage
    {
        public int Dice;
        private int StunMult = 5;
        public damagetype mDamageType;
        private damageclass mDamageClass;

        public damagetype DamageType
        {
            get
            {
                return mDamageType;
            }

            set
            {
                mDamageType = value;
            }
        }

        public damageclass DamageClass
        {
            get
            {
                return mDamageClass;
            }

            set
            {
                mDamageClass = value;
            }
        }
        public HitStruct GetDamage()
        {
            calculatecost();
            HitStruct Damage = new HitStruct();
            Damage.DamageClass = DamageClass;
            for (int i = 0; i < Dice; i++)
            {
                int damage = Program.prng.Next(1, 7);
                Damage.HealthDamage += damage;
                Damage.StunDamage += damage * StunMult;
            }
            DrawEnergy();
            return Damage;
        }
    }
    [Serializable]
    public class Heal : Power
    {
        int mDice = 1;
        public override void calculatecost()
        {
            mBaseCost = mDice * 10;
            mActiveCost = (int)(mBaseCost * (1 + mAdvantageMult));
            mRealCost = (int)(mActiveCost / (1 + mDisadvantageMult));
            mEnergyCost = mActiveCost / 10;
        }
    }
    [Serializable]
    public class Armor : Buff
    {
        int mRPDEF;
        int mREDEF;
        #region Interfaces
        public int RPDEF
        {
            get
            {
                return mRPDEF;
            }

            set
            {
                mRPDEF = value;
                if (mRPDEF < 0)
                {
                    mRPDEF = 0;
                }
            }
        }

        public int REDEF
        {
            get
            {
                return mREDEF;
            }

            set
            {
                mREDEF = value;
                if (mREDEF < 0)
                {
                    mREDEF = 0;
                }
            }
        }
        #endregion
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
        public override void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Resistant Physical Defense: " + RPDEF);
            Console.WriteLine("Resistant Energy Defense: " + REDEF);
            Console.WriteLine("Point Cost: " + mActiveCost + "(Active)/" + mRealCost + "(real)");
        }
        public override void calculatecost()
        {
            mBaseCost = (int)(RPDEF * 1.5 + REDEF * 1.5);
            mActiveCost = (int)(mBaseCost * (1 + mAdvantageMult));
            mRealCost = (int)(mActiveCost / (1 + mDisadvantageMult));
            mEnergyCost = 0;
        }
    } 
    public struct HitStruct
    {
        private int mHealthDamage;
        private int mStunDamage;
        public damageclass DamageClass;

        public int HealthDamage
        {
            get
            {
                return mHealthDamage;
            }

            set
            {
                mHealthDamage = value;
                if (mHealthDamage < 0)
                {
                    mHealthDamage = 0;
                }
            }
        }

        public int StunDamage
        {
            get
            {
                return mStunDamage;
            }

            set
            {
                mStunDamage = value;
                if (mStunDamage < 0)
                {
                    mStunDamage = 0;
                }
            }
        }
    }
}