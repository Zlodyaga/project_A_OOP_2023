namespace Project_A_OOP_2023
{
    public class Decepticon : Transformer
    {
        public string evilPurpose { get; private set; }

        public Decepticon(string id, string name, string purpose) : base(id, name)
        {
            this.evilPurpose = purpose;
        }

        public override void Transform(TransformedObject transformedObject = TransformedObject.Plane)
        {
            if (TransformedInto == (TransformedObject)0)
            {
                this.TransformedInto = transformedObject;
            }
            else
            {
                this.TransformedInto = (TransformedObject)0;
            }
        }
    }
}
