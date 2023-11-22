namespace Project_A_OOP_2023
{
    public class Autobot : Transformer
    {
        public string specialization { get; private set; }

        public Autobot(string id, string name, string spec) : base(id, name)
        {
            this.specialization = spec;
        }

        public override void Transform()
        {
            if (TransformedInto == (TransformedObject)0)
            {
                this.TransformedInto = (TransformedObject)1;
            }
            else
            {
                this.TransformedInto = (TransformedObject)0;
            }
        }
    }
}
