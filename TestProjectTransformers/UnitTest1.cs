namespace TestProjectTransformers
{
    [TestClass]
    public class TransformerTests
    {
        [TestMethod]
        public void Transformer_CorrectlyInitializesProperties()
        {
            var transformer = new Transformer("ID123", "Optimus Prime");

            Assert.AreEqual("ID123", transformer.id);
            Assert.AreEqual("Optimus Prime", transformer.name);
            Assert.IsNotNull(transformer.engine);
        }

        [TestMethod]
        public void Autobot_SpecializationIsSetCorrectly()
        {
            var autobot = new Autobot("ID124", "Bumblebee", "Scout");

            Assert.AreEqual("Scout", autobot.specialization);
        }

        [TestMethod]
        public void Decepticon_EvilPurposeIsSetCorrectly()
        {
            var decepticon = new Decepticon("ID125", "Megatron", "Conquest");

            Assert.AreEqual("Conquest", decepticon.evilPurpose);
        }

        [TestMethod]
        public void Engine_InitializesWithDefaultType()
        {
            var engine = new Engine();

            Assert.AreEqual("Default", engine.engineType);
        }

        [TestMethod]
        public void Weapon_InitializesWithType()
        {
            var weapon = new Weapon("Laser");

            Assert.AreEqual("Laser", weapon.weaponType);
        }

        [TestMethod]
        public void BattleHistory_RecordsBattleCorrectly()
        {
            var winner = new Autobot("ID126", "Optimus Prime", "Leader");
            var loser = new Decepticon("ID127", "Starscream", "Air Commander");
            var battleHistory = new BattleHistory(DateTime.Now, "Victory for Autobots");

            battleHistory.RecordBattle(winner, loser); //Цей метод зараз не реалізований, отже тест Failed

            Assert.AreEqual("Victory for Autobots", battleHistory.outcome);
        }
    }
}