namespace human{
    public class ahuman{
        // Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health.
        // Give a default value of 3 for strength, intelligence, and dexterity. Health should have a default of 100.
        // When an object is constructed from this class it should have the ability to pass a name
        public string name{ get; set; }
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;
        public ahuman(string Name){
            name = Name;
        }
        public ahuman(string Name, int Strength, int Intelligence, int Dexterity, int Health){
            name = Name;
            strength = Strength;
            intelligence = Intelligence;
            dexterity = Dexterity;
            health = Health;
        }
        public void attack(object target){
            ahuman enemy = target as ahuman;
            enemy.health -= 5 * strength;
        }
    }
}