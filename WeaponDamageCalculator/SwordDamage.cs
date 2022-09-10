namespace SwordDamageCalculator
{
    public class SwordDamage : WeaponDamage
    {
            private const int BASE_DAMAGE = 3;
            private const int FLAME_DAMAGE = 2;

            public SwordDamage(int startingRoll) : base(startingRoll)
            {
            }
            
            protected  override void CalculateDamage()
            {
                decimal magicMultiplier = Magic ? 1.75M : 1M;
                Damage = (int) (Roll * magicMultiplier) + BASE_DAMAGE;
                if (Flaming) Damage += FLAME_DAMAGE;
            }
        }
    }