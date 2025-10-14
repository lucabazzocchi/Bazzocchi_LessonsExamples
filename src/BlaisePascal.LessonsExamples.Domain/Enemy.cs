namespace BlaisePascal.LessonsExamples.Domain
{
    public class Enemy
    {

        // Attributes


        //Properties

        //public int Health
        //{
        //    get
        //    {
        //        return _health;
        //    }
        //    private set
        //    {
        //        if (_health < 0)
        //        {
        //            throw new ArgumentOutOfRangeException("value");
        //        }

        //        _health = value;
        //    }

        //}
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsAlive  { get; private set; }
        public int Health { get; private set; }



        // Constructor

        //OverLoading costruttore

        public Enemy() { }



        public Enemy(string name)
        {
            SetName(name);
        }

        public Enemy(string name, int health)
        {
            SetName(name);
            SetHealth(health);

        }

        public string GetName()
        {
            return Name;
        }
        public int GetHealth()
        {
            return Health;
        }




        // Function


        public void SetName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName.Trim()))
                Name = newName;
        }

        public void SetHealth(int newHealth)
        {
            if (int.IsPositive(newHealth) && newHealth <= 100)
                Health = newHealth;
        }

        public void TakeDamage(int damage)
        {
            if (int.IsNegative(damage))
            {

            }
            else
            {
                if (damage < Health && IsAlive == true)
                {
                    //Health = Math.Max(0, Health - damage);  //prende il massimo fra due numeri quindi se health va sotto 0 prende 0
                    Health -= damage;
                }
                else
                {
                    IsAlive = false;
                    Health = 0;
                }

            }

        }
            

        public void IsEnemyAlive()
        {
            if (Health > 0)
            {
                IsAlive = true;
            }
            else
            {
                IsAlive = false;
            }

        }
    }
}