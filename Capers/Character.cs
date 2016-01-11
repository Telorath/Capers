using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capers
{
    public class Character : Entity, IEnergy, IHealth, IStun
    {
        public List<Power> Powers = new List<Power>();
        int mHealth = 10;
        int mMaxHealth = 10;
        int mStun = 10;
        int mMaxStun = 10;
        int mEnergy = 10;
        int mMaxEnergy = 10;
        int mStr = 10;
        int mPDEF = 0;
        int mRPDEF = 0;
        int mEDEF = 0;
        int mREDEF = 0;
        public IDealsDamage DefaultAttack;
        public bool mKO = false;
        public bool mDead = false;
        #region Interfaces
        public int Health
        {
            get
            {
                return mHealth;
            }
            set
            {
                mHealth = value;
                if (mHealth > mMaxHealth)
                {
                    mHealth = mMaxHealth;
                }
                if (mHealth < 0)
                {
                    mDead = true;
                }
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

        public int MaxHealth
        {
            get
            {
                return mMaxHealth;
            }

            set
            {
                mMaxHealth = value;
            }
        }

        public int Stun
        {
            get
            {
                return mStun;
            }

            set
            {
                mStun = value;
                if (mStun > mMaxStun)
                {
                    mStun = mMaxStun;
                }
                if (mStun < 0)
                {
                    mKO = true;
                }
            }
        }
        public int MaxStun
        {
            get
            {
                return mMaxStun;
            }

            set
            {
                mMaxStun = value;
            }
        }
        public bool KO
        {
            get
            { return mKO; }
        }
        public bool Dead
        {
            get { return mDead; }
        }

        public int Str
        {
            get
            {
                return mStr;
            }

            set
            {
                mStr = value;
            }
        }

        public int PDEF
        {
            get
            {
                return mPDEF;
            }

            set
            {
                mPDEF = value;
            }
        }

        public int RPDEF
        {
            get
            {
                return mRPDEF;
            }

            set
            {
                mRPDEF = value;
            }
        }

        public int EDEF
        {
            get
            {
                return mEDEF;
            }

            set
            {
                mEDEF = value;
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
            }
        }
        #endregion
        public Character()
        {
            Power Punch = new HandtoHand();
            DefaultAttack = (IDealsDamage)Punch;
            Punch.User = this;
            Punch.Name = "Punch";
            Punch.EnergySource = this;
           (Punch as HandtoHand).calculatecost();
        }
        public void addpower(Power p)
        {
            Powers.Add(p);
            p.User = this;
            if (p is Buff)
            {
                (p as Buff).Apply(this);
            }
        }
        public void removerpower(Power p)
        {
            Powers.Remove(p);
            p.User = null;
            if (p is Buff)
            {
                (p as Buff).Remove(this);
            }
        }
        public void Display()
        {
            Console.WriteLine("------------------------------------------------");
            StatsDisplay();
            Console.WriteLine("------------------------------------------------");
        }
        public void StatsDisplay()
        {
            Console.WriteLine("Name: " + this);
            Console.WriteLine("Health: " + Health + "/" + MaxHealth);
            Console.WriteLine("Stun: " + Stun + "/" + MaxStun);
            Console.WriteLine("Energy: " + Energy + "/" + MaxEnergy);
        }
        public void PowersDisplay()
        {
            for (int i = 0; i < Powers.Count; i++)
            {
                Console.WriteLine("------------------------------------------------");
                Powers[i].Display();
            }
        }
        public void FullDisplay()
        {
            Console.WriteLine("------------------------------------------------");
            StatsDisplay();
            PowersDisplay();
            Console.WriteLine("------------------------------------------------");
        }
        public void Recovery()
        {
            Stun += 1;
            Energy += 1;
        }
        public HitStruct ApplyDefense(HitStruct Hit)
        {
            if (Hit.DamageClass == damageclass.physical)
            {
                Hit.HealthDamage -= RPDEF;
                Hit.StunDamage -= RPDEF + PDEF;
            }
            if (Hit.DamageClass == damageclass.energy)
            {
                Hit.HealthDamage -= REDEF;
                Hit.StunDamage -= REDEF + EDEF;
            }
            return Hit;
        }
        public void GetHit(HitStruct Hit)
        {
            Health -= Hit.HealthDamage;
            Stun -= Hit.StunDamage;
        }
    }
}
