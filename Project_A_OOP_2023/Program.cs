void main()
{
    Console.WriteLine("something");
}

public interface ITransformable
{
    void Transform();
}

public class Transformer : ITransformable
{
    public string id { get; private set; }
    public string name { get; private set; }
    public Engine engine { get; private set; }
    public Weapon weapon { get; private set; }

    public Transformer(string id, string name)
    {
        this.id = id;
        this.name = name;
        this.engine = new Engine();
        this.weapon = new Weapon();
    }

    public Transformer(string id, string name, string engine, string weapon) : this(id, name)
    {
        this.engine = new Engine(engine);
        this.weapon = new Weapon(weapon);
    }

    public virtual void Transform()
    {
        // Реалізація трансформації
        throw new NotImplementedException();
    }
}

public class Autobot : Transformer
{
    public string specialization { get; private set; }

    public Autobot(string id, string name, string spec) : base(id, name)
    {
        this.specialization = spec;
    }

    public override void Transform()
    {
        throw new NotImplementedException();
    }
}

public class Decepticon : Transformer
{
    public string evilPurpose { get; private set; }

    public Decepticon(string id, string name, string purpose) : base(id, name)
    {
        this.evilPurpose = purpose;
    }

    public override void Transform()
    {
        throw new NotImplementedException();
    }
}

public class Engine
{
    public string engineType { get; private set; }

    public Engine(string type = "Default")
    {
        this.engineType = type;
    }
}

public class Weapon
{
    public string weaponType { get; private set; }

    public Weapon(string type = "Default")
    {
        this.weaponType = type;
    }
}

public class BattleHistory
{
    public DateTime date { get; private set; }
    public string outcome { get; private set; }

    public BattleHistory(DateTime date, string outcome)
    {
        this.date = date;
        this.outcome = outcome;
    }

    public void RecordBattle(Transformer winner, Transformer loser)
    {
        throw new NotImplementedException();
    }
}
