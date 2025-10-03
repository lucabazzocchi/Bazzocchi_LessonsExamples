namespace BlaisePascal.LessonsExamples.Domain
{
    public class Enemy
    {
        //TODO: Attributes decomposition
        // Attributes
        private string _name;
        private string _description;
        private int _health;
        private bool _isAlive;
     

        // Constructor

        //OverLoading costruttore
        public Enemy()
        {

        }

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
            return _name;
        }
        public int GetHealth()
        {
            return _health;
        }

        // Function
        public void SetName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
                _name = newName;
        }

        public void SetHealth(int newHealth)
        {
            if (int.IsPositive(newHealth) && newHealth <= 100)
                _health = newHealth;
        }



    }
}
