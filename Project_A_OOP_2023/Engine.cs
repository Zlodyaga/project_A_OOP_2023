namespace Project_A_OOP_2023
{
    public class Engine
    {
        public string engineType { get; private set; }

        public Engine(string type = "Default")
        {
            this.engineType = type;
        }
    }
}
