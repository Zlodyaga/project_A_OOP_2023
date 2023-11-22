using Project_A_OOP_2023;

class Program
{
    static List<Transformer> transformers = new List<Transformer>();

    static void Main(string[] args)
    {
        //Стартові дані
        transformers.Add(new Autobot("121", "Optimus Prime", "Leader"));
        transformers.Add(new Autobot("122", "Bumblebee", "Scout"));
        transformers.Add(new Decepticon("123", "Starscream", "Air Commander"));
        transformers.Add(new Decepticon("124", "Megatron", "Conquest"));
        while (true)
        {
            Console.WriteLine("Welcome to the Transformer Management System!");
            Console.WriteLine("1. Add a new Transformer");
            Console.WriteLine("2. Transform a Transformer");
            Console.WriteLine("3. Display all Transformers");
            Console.WriteLine("4. Record a Battle");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Clear();
                    AddTransformer();
                    break;
                case "2":
                    Console.Clear();
                    DisplayTransformers();
                    TransformTransformer();
                    break;
                case "3":
                    Console.Clear();
                    DisplayTransformersDetailed();
                    break;
                case "4":
                    Console.Clear();
                    DisplayTransformers();
                    RecordBattle();
                    break;
                case "5":
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddTransformer()
    {
        Console.Write("Enter Transformer ID: ");
        var id = Console.ReadLine();
        Console.Write("Enter Transformer Name: ");
        var name = Console.ReadLine();
        Console.Write("Enter Transformer Type (Autobot/Decepticon): ");
        var type = Console.ReadLine();
        Console.Write("Enter Specialization or Evil Purpose: ");
        var specOrPurpose = Console.ReadLine();

        Transformer newTransformer;
        if (type.ToLower() == "autobot")
        {
            newTransformer = new Autobot(id, name, specOrPurpose);
        }
        else
        {
            newTransformer = new Decepticon(id, name, specOrPurpose);
        }

        transformers.Add(newTransformer);
        Console.WriteLine("Transformer added successfully!");
    }

    static void TransformTransformer()
    {
        Console.Write("Enter Transformer ID to transform: ");
        var id = Console.ReadLine();
        var transformer = transformers.Find(t => t.id == id);
        if (transformer != null)
        {
            transformer.Transform();
            Console.WriteLine($"{transformer.name} has been transformed into a {transformer.TransformedInto}.");
        }
        else
        {
            Console.WriteLine("Transformer not found!");
        }
    }

    static void DisplayTransformers()
    {
        foreach (var transformer in transformers)
        {
            Console.WriteLine($"ID: {transformer.id}, Name: {transformer.name}, Type: {transformer.TransformedInto}");
        }
    }

    static void DisplayTransformersDetailed()
    {
        foreach (var transformer in transformers)
        {
            string type = transformer is Autobot ? "Autobot" : "Decepticon";
            string specOrPurpose = type == "Autobot" ? ((Autobot)transformer).specialization : ((Decepticon)transformer).evilPurpose;

            Console.WriteLine($"ID: {transformer.id}, Name: {transformer.name}, Type: {type}, " +
                              $"Detail: {specOrPurpose}, Transformed Into: {transformer.TransformedInto}");
        }
    }

    static void RecordBattle()
    {
        Console.Write("Enter Winner Transformer ID: ");
        var winnerId = Console.ReadLine();
        var winner = transformers.Find(t => t.id == winnerId);

        Console.Write("Enter Loser Transformer ID: ");
        var loserId = Console.ReadLine();
        var loser = transformers.Find(t => t.id == loserId);

        if (winner != null && loser != null)
        {
            var battleHistory = new BattleHistory(DateTime.Now, $"Victory for {winner.name} over {loser.name}");
            Console.WriteLine(battleHistory.outcome);
        }
        else
        {
            Console.WriteLine("One or both Transformers not found!");
        }
    }
}
