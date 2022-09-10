using System;

namespace SwordDamageCalculator
{
    internal class Program
    {
        public static Random random = new Random();
        static char input;
        private static int numberOfRolls;

        
        public static void Main(string[] args)
        {
            WeaponDamage swordDamage = new SwordDamage(RollDice(3));
            WeaponDamage arrowDamage = new ArrowDamage(RollDice(2));
            
            
            
            //SwordDamage calculator = new SwordDamage(RollDice(3));  
            while (true)
            {

                Console.Write("\nS for sword, A for arrow, anything else to quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (weaponKey)
                {
                    case 'S':
                        numberOfRolls = 3;
                        DamageInput(swordDamage);
                        break;
                    case 'A':
                        numberOfRolls = 2;
                        DamageInput(arrowDamage);
                        break;
                    default:
                        return;
                }
                
            }

        }

        public static void DamageInput(WeaponDamage weapon)
        {
            Console.Write("\n0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
            input = Console.ReadKey(false).KeyChar;
            if (input != '0' && input != '1' && input != '2' && input != '3') return;
            weapon.Roll = RollDice(numberOfRolls);
            weapon.Magic = (input == '1' || input == '3');
            weapon.Flaming = (input == '2' || input == '3');
            
            Console.WriteLine($"\nrolled {weapon.Roll} for {weapon.Damage} damage.");
        }

        public static int RollDice(int numberOfRolls)
        {
            int rolled = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                    rolled += random.Next(1, 7);
            }
            return rolled;
        }
    }
}