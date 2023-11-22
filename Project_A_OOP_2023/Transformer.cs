using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A_OOP_2023
{
    public interface ITransformable
    {
        TransformedObject TransformedInto { get; set; }

        void Transform();
    }

    public enum TransformedObject
    {
        Original,
        Car,
        Plane,
        Ship,
    }

    public class Transformer : ITransformable, ICloneable
    {
        public string id { get; private set; }
        public string name { get; private set; }
        public Engine engine { get; private set; }
        public Weapon weapon { get; private set; }
        private TransformedObject _transformedInto;
        public TransformedObject TransformedInto { get => _transformedInto; set => _transformedInto = value; }


        public Transformer(string id, string name)
        {
            this.id = id;
            this.name = name;
            this.engine = new Engine();
            this.weapon = new Weapon();
            TransformedInto = (TransformedObject)0;
        }

        public Transformer(string id, string name, string engine, string weapon) : this(id, name)
        {
            this.engine = new Engine(engine);
            this.weapon = new Weapon(weapon);
        }

        public virtual void Transform()
        {
            this.TransformedInto = (TransformedObject)1;
        }

        public object Clone()
        {
            // Глибоке клонування
            Transformer clone = (Transformer)this.MemberwiseClone();
            clone.engine = new Engine(this.engine.engineType);
            clone.weapon = new Weapon(this.weapon.weaponType);
            return clone;
        }
    }
}
