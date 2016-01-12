using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capers
{
    class Program
    {
        public static Random prng = new Random();
        static void Main(string[] args)
        {
#if false
            Character Bob = new Character();
            Bob.Name = "Bob";
            Power ERESERVE = new EnergyReserve();
            (ERESERVE as EnergyReserve).MaxEnergy = 100;
            (ERESERVE as EnergyReserve).Energy = 100;
            Bob.addpower(ERESERVE);
            Power EBLAST1 = new EnergyBlast();
            (EBLAST1 as EnergyBlast).Dice = 2;
            EBLAST1.EnergySource = (EnergyReserve)ERESERVE;
            Power EBLAST2 = new EnergyBlast();
            (EBLAST2 as EnergyBlast).Dice = 1;
            EBLAST2.EnergySource = (EnergyReserve)ERESERVE;
            EBLAST1.calculatecost();
            EBLAST2.calculatecost();
            Bob.addpower(EBLAST1);
            Bob.addpower(EBLAST2);
            Database.GetActiveDatabase().AddCharacter(Bob);
            Database.GetActiveDatabase().Save();
#endif
#if false
            Database Active = Database.GetActiveDatabase();
            Active.AddCharacter(Newcharacter("Bob"));
            Active.AddCharacter(Newcharacter("Marie"));
            Active.AddCharacter(Newcharacter("Laura"));
            Active.AddCharacter(Newcharacter("Robert"));
            Active.AddCharacter(Newcharacter("Kerchik"));
            Active.AddCharacter(Newcharacter("Maldor"));
            Active.AddCharacter(Newcharacter("GALAVOR DESTROYER OF HUMANITY"));
            Active.Save();
#endif
#if true
            Database.LoadDatabase();
            Database.GetActiveDatabase().ReadCharacters();
#endif
            Console.ReadLine();
        }
        static void MockBattle(Character Bob, Character Darkness)
        {
            bool Combat = true;
            int turn = 1;
            while (Combat)
            {
                AttackRound(Bob, Darkness);
                AttackRound(Darkness, Bob);
                if (turn % 12 == 0)
                {
                    Bob.TakeRecovery();
                    Darkness.TakeRecovery();
                }
                Bob.Display();
                Darkness.Display();
                if (Bob.KO || Bob.Dead || Darkness.Dead || Darkness.KO)
                {
                    Combat = false;
                }
                turn++;
            }
        }
        static void AttackRound(Character Attacker, Character Defender)
        {
            IDealsDamage Attack = Attacker.DefaultAttack;
            HitStruct Hit = new HitStruct();
            for (int i = 0; i < Attacker.Powers.Count; i++)
            {
                if (Attacker.Powers[i] is IDealsDamage && Attacker.Powers[i].CanUse())
                {
                    Attack = (IDealsDamage)Attacker.Powers[i];
                    break;
                }
            }
            if (Attack != null && (Attack as Power).CanUse())
            {
                Hit = Attack.GetDamage();
                Hit = Defender.ApplyDefense(Hit);
                Console.WriteLine(Attacker + " attacks " + Defender + " with " + Attack + " dealing " + Hit.HealthDamage + "(" + Hit.StunDamage + " Stun) damage!");
                Defender.GetHit(Hit);
            }
            else
            {
                Console.WriteLine(Attacker + " was too tired to use any abilities this turn and used a recovery instead!");
                Attacker.TakeRecovery();
            }
        }
        static HitStruct PowerHit(IDealsDamage Power, IHealth Target)
        {
            HitStruct Hit = Power.GetDamage();
            Target.Health -= Hit.HealthDamage;
            IStun StunTarget = Target as IStun;
            if (StunTarget != null)
            {
                StunTarget.Stun -= Hit.StunDamage;
            }
            return Hit;
        }
        static Character Newcharacter(string name)
        {
            Character C = new Character();
            IEnergy ERESERVE = C;
            C.Name = name;
            int chance = prng.Next(1,101);
            if (chance > 30)
            {
                ERESERVE = new EnergyReserve();
                ERESERVE.MaxEnergy = prng.Next(1, 9) * 10;
                (ERESERVE as Power).calculatecost();
                C.addpower((Power)ERESERVE);
            }
            chance = prng.Next(1, 101);
#if false
            if (chance > 20)
            {
                EnergyBlast = new EnergyBlast();
                
            }
#endif
            return C;
        }
    }
}