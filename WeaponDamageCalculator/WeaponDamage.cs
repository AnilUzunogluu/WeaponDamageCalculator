namespace SwordDamageCalculator
{
    public class WeaponDamage
    {
        public int Damage { get; protected set; }
        
        private int _roll;
        public int Roll
        {
            get => _roll;
            set
            {
                _roll = value;
                CalculateDamage();
            }
        }
        
        private bool _flaming;
        public bool Flaming
        {
            get => _flaming;
            set
            {
                _flaming = value;
                CalculateDamage();
            }
        }
        
        private bool _magic;
        public bool Magic
        {
            get => _magic;
            set
            {
                _magic = value;
                CalculateDamage();
            }
        }

        public WeaponDamage(int startingRoll)
        {
            _roll = startingRoll;
            CalculateDamage();
        }
        
        protected virtual void CalculateDamage()
        {
            //Overriden in subclasses.
        }
    }
}