using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Collections;

namespace Capers
{
    [Serializable]
    public class Character : Entity, IEnergy, IHealth, IStun, IRecovery
    {
        public List<Power> Powers = new List<Power>();
        //Resources
        int mHealth = 10;
        int mMaxHealth = 10;
        int mStun = 10;
        int mMaxStun = 10;
        int mEnergy = 10;
        int mMaxEnergy = 10;
        //Core stats
        int mStr = 10;
        int mCon = 10;
        int mEnd = 10;
        int mAgi = 10;
        int mInt = 10;
        int mWil = 10;
        int mCha = 10;
        //Secondary Stats
        int mPDEF = 2;
        int mRPDEF = 0;
        int mEDEF = 2;
        int mREDEF = 0;
        public IDealsDamage DefaultAttack;
        public bool mKO = false;
        public bool mDead = false;
        #region Properties
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
        public int Str
        {
            get
            {
                return mStr;
            }

            set
            {
                mStr = value;
                if (mStr < 0)
                {
                    mStr = 0;
                }
            }
        }
        public int Con
        {
            get
            {
                return mCon;
            }
            set
            {
                mCon = value;
                if (mCon < 0)
                {
                    mCon = 0;
                }
            }
        }
        public int End
        {
            get { return mEnd; }
            set { mEnd = value; }
        }
        public int Agi
        {
            get
            {
                return mAgi;
            }
            set
            {
                mAgi = value;
            }
        }
        public int Intel
        {
get { return mInt; }
            set { mInt = value; }
        }
        public int Wil
        {
            get { return mWil; }
            set { mWil = value; }
        }
        public int Cha
        {
            get { return mCha; }
            set { mCha = value; }
        }
        public int PointSpent
        {
            get {
                int value = 0;
                value += (Str - 10);
                value += (Con - 10) * 2;
                value += (End - 10) * 2;
                value += (Agi - 10);
                value += (Intel - 10);
                value += (Wil - 10) * 2;
                value += (Cha - 10);
                foreach (Power p in Powers)
                {
                    p.calculatecost();
                    value += p.PointCost;
                }
                return value;
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
        public void TakeRecovery()
        {
            for (int i = 0; i < Powers.Count; i++)
            {
                if (Powers[i] is IRecovery)
                {
                    (Powers[i] as IRecovery).TakeRecovery();
                }
            }
            QuickRecovery();
        }
        public void QuickRecovery()
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
        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            string path = "C:\\Users\\Telorath\\Heroes";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = path + "\\" + Name + ".txt";
            FileStream _stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(_stream, this);
            _stream.Close();
        }
        public void FullHeal()
        {
            Health = MaxHealth;
            Energy = MaxEnergy;
            Stun = MaxStun;
            mDead = false;
            mKO = false;
        }
        static public Character Load(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream _stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            Character Loaded = (Character)formatter.Deserialize(_stream);
            _stream.Close();
            return Loaded;
        }
    }
}
