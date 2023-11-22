namespace Project_A_OOP_2023
{
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
            date = DateTime.Now;
            outcome = $"Victory for {winner.name} under {loser.name}";
        }
    }
}
