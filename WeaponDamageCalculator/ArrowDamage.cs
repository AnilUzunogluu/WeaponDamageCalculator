using System;

namespace SwordDamageCalculator
{
    public class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = 0.45M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        public ArrowDamage(int startingRoll) : base(startingRoll)
        {
        }

        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            Damage = Flaming ? RoundUpDamage(baseDamage + FLAME_DAMAGE) : RoundUpDamage(baseDamage);
        }

        private int RoundUpDamage(decimal value)
        {
            int result = (int) Math.Ceiling(value);
            return result;
        }
    }
}