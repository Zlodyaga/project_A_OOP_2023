namespace Project_A_OOP_2023
{
    public class Weapon
    {
        public string weaponType { get; private set; }

        public Weapon(string type = "Default")
        {
            this.weaponType = type;
        }
    }
}
