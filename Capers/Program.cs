using System;
using System.Windows.Forms;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capers;

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
            Character_Editter_Form CHARFORM = new Character_Editter_Form();
            Application.Run(CHARFORM);
            Event();
            Console.ReadLine();
        }
        static void Event()
        {
            List<Character> CHARDATABASE = Database.GetActiveDatabase().CharList();
            if (CHARDATABASE.Count < 2)
            {
                return;
            }
            for (int i = 0; i < CHARDATABASE.Count; i++)
            {
                if (CHARDATABASE[i].SPD == 0) { CHARDATABASE[i].SPD = 2; }
            }
            int var = 0;
            while (var == 0)
            {
                var = prng.Next(0, CHARDATABASE.Count);
            }
            Character Other = CHARDATABASE[var];
            Character First = CHARDATABASE[prng.Next(0, CHARDATABASE.Count)];
            var = prng.Next(1, 101);
            if (var < 1)
            {
                Console.WriteLine("You meet up with " + Other.Name + " and some stuff happens. Nobody kills each other though!");
            }
            else
            {
                Console.WriteLine("You run into " + Other.Name + " out on the street and a fight breaks out between you!");
                First.FullHeal();
                Other.FullHeal();
                MockBattle(First, Other);
            }
        }
        static void MockBattle(Character Combatant1, Character Combatant2)
        {
            bool Combat = true;
            int turn = 1;
            while (Combat)
            {
                if (turn % 13 + 1 <= Combatant1.SPD)
                    AttackRound(Combatant1, Combatant2);
                if (turn % 13 + 1 <= Combatant2.SPD)
                    AttackRound(Combatant2, Combatant1);
                if (turn % 12 == 0)
                {
                    Combatant1.TakeRecovery();
                    Combatant2.TakeRecovery();
                }
                Combatant1.Display();
                Combatant2.Display();
                if (Combatant1.KO || Combatant1.Dead || Combatant2.Dead || Combatant2.KO)
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
                if (Attacker.Attackroll(Defender))
                {
                    Hit = Defender.ApplyDefense(Hit);
                    Console.WriteLine(Attacker + " attacks " + Defender + " with " + Attack + " dealing " + Hit.HealthDamage + "(" + Hit.StunDamage + " Stun) damage!");
                    Defender.GetHit(Hit);
                }
                else
                {
                    Console.WriteLine(Attacker + " attacks " + Defender + " with " + Attack + ", but misses!");
                }
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
            int chance = prng.Next(1, 101);
            if (chance > 30)
            {
                ERESERVE = new EnergyReserve();
                ERESERVE.MaxEnergy = prng.Next(1, 9) * 10;
                ERESERVE.Energy = ERESERVE.MaxEnergy;
                (ERESERVE as Power).calculatecost();
                (ERESERVE as Entity).Name = "Energy Reserve";
                (ERESERVE as EnergyReserve).User = C;
                C.addpower((Power)ERESERVE);
            }
            chance = prng.Next(1, 101);
            if (chance > 20)
            {
                EnergyBlast EBLAST = new EnergyBlast();
                EBLAST.Name = "Energy Blast";
                EBLAST.Dice = prng.Next(1, 6);
                EBLAST.EnergySource = ERESERVE;
                EBLAST.DamageClass = (damageclass)prng.Next(0, Enum.GetNames(typeof(damageclass)).Length + 1);
                EBLAST.DamageType = (damagetype)prng.Next(0, Enum.GetNames(typeof(damagetype)).Length + 1);
                EBLAST.User = C;
                EBLAST.calculatecost();
                C.addpower(EBLAST);
            }
            if (chance > 60)
            {
                Armor ARMORPOWER = new Armor();
                ARMORPOWER.Name = "Armor";
                ARMORPOWER.REDEF = prng.Next(1, 10);
                ARMORPOWER.RPDEF = prng.Next(1, 10);
                ARMORPOWER.EnergySource = ERESERVE;
                ARMORPOWER.User = C;
                ARMORPOWER.calculatecost();
                C.addpower(ARMORPOWER);
            }
            return C;
        }
    }
}