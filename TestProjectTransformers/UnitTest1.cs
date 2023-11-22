using Project_A_OOP_2023;

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
            var battleHistory = new BattleHistory(DateTime.Now, "Optimus Prime defeats Starscream");

            battleHistory.RecordBattle(winner, loser);

            Assert.AreEqual("Victory for Optimus Prime under Starscream", battleHistory.outcome);
        }

        [TestMethod]
        public void Autobot_TransformsToCar_Correctly()
        {
            var autobot = new Autobot("ID124", "Bumblebee", "Scout");
            autobot.Transform(); // Передбачається, що цей метод змінює стан на Car

            Assert.AreEqual(TransformedObject.Car, autobot.TransformedInto);
        }

        [TestMethod]
        public void Decepticon_TransformsToPlane_Correctly()
        {
            var decepticon = new Decepticon("ID125", "Starscream", "Air Command");
            decepticon.Transform(); // Передбачається, що цей метод змінює стан на Plane

            Assert.AreEqual(TransformedObject.Plane, decepticon.TransformedInto);
        }

        // Цей тест перевіряє, що метод Transform() автобота перемикає стан з Original на Car і назад
        [TestMethod]
        public void Autobot_TransformTogglesBetweenOriginalAndCar()
        {
            var autobot = new Autobot("ID124", "Bumblebee", "Scout");
            autobot.Transform(); // Перевірка першої трансформації
            Assert.AreEqual(TransformedObject.Car, autobot.TransformedInto);

            autobot.Transform(); // Перевірка повернення до оригінального стану
            Assert.AreEqual(TransformedObject.Original, autobot.TransformedInto);
        }

        // Цей тест перевіряє, що метод Transform() десептикона перемикає стан з Original на Plane і назад
        [TestMethod]
        public void Decepticon_TransformTogglesBetweenOriginalAndPlane()
        {
            var decepticon = new Decepticon("ID125", "Starscream", "Air Command");
            decepticon.Transform(); // Перевірка першої трансформації
            Assert.AreEqual(TransformedObject.Plane, decepticon.TransformedInto);

            decepticon.Transform(); // Перевірка повернення до оригінального стану
            Assert.AreEqual(TransformedObject.Original, decepticon.TransformedInto);
        }

        [TestMethod]
        public void Transformer_DefaultTransformationIsOriginal()
        {
            var transformer = new Transformer("ID123", "Generic");
            // Передбачається, що за замовчуванням трансформер не трансформований

            Assert.AreEqual(TransformedObject.Original, transformer.TransformedInto);
        }
    }
}