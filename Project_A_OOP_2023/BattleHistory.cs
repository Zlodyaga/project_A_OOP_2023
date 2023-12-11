namespace Project_A_OOP_2023
{
    using System;
    using System.Collections.Generic;

    public class BattleRecord
    {
        public DateTime Date { get; private set; }
        public string Outcome { get; private set; }

        public BattleRecord(DateTime date, string outcome)
        {
            Date = date;
            Outcome = outcome;
        }
    }

    public class BattleHistory
    {
        public List<BattleRecord> battles = new List<BattleRecord>();

        public BattleHistory()
        { }

        public BattleHistory(BattleRecord battle)
        {
            battles.Add(battle);
        }

        public void RecordBattle(Transformer winner, Transformer loser)
        {
            DateTime battleDate = DateTime.Now;
            string outcome = $"Victory for {winner.name} over {loser.name}";
            battles.Add(new BattleRecord(battleDate, outcome));
        }

        public void DisplayBattleHistory()
        {
            foreach (var battle in battles)
            {
                Console.WriteLine($"Date: {battle.Date}, Outcome: {battle.Outcome}");
            }
        }
    }

}
