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
            Character Bob = new Character();
            Character Darkness = new Character();
            Darkness.Name = "Darkness";
            Bob.Name = "Bob";
            EnergyReserve E = new EnergyReserve();
            E.Name = "Mana";
            E.MaxEnergy = 10;
            E.Energy = 10;
            EnergyBlast En = new EnergyBlast();
            En.EnergySource = E;
            En.Dice = 1;
            En.mAdvantageMult = 0.50f;
            En.mDisadvantageMult = 0.5f;
            En.Name = "Magic Missile";
            En.mDamageType = damagetype.arcane;
            En.calculatecost();
            Bob.addpower(E);
            Bob.addpower(En);
            Bob.FullDisplay();
            Armor Arm = new Armor();
            Arm.RPDEF = 3;
            Arm.REDEF = 3;
            Darkness.addpower(Arm);
            Bob.Energy = 0;
            Darkness.Energy = 0;
            MockBattle(Bob, Darkness);
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
                    Bob.Recovery();
                    Darkness.Recovery();
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
                Attacker.Recovery();
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
    }
}