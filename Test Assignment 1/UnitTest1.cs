using Assignment_1;
using System.ComponentModel.DataAnnotations;

namespace Test_Assignment_1
{
    [TestClass]
    public class UnitTest1
    {
        private static FootballPlayer _validPlayer;
        private static FootballPlayer _invalidPlayer;
        [TestInitialize]
        public void SetUp()
        {
            _validPlayer = new FootballPlayer();
            _invalidPlayer = new FootballPlayer();
        }
        [TestMethod]
        public void TestValidateName()
        {
            _validPlayer.Name = "Ib";
            _invalidPlayer.Name = "I";
            
            _validPlayer.ValidateName();
            
            Assert.ThrowsException<ValidationException>(() => _invalidPlayer.ValidateName());
        }
        [TestMethod]
        public void TestValidateAge()
        {
            _validPlayer.Age = 1;
            _invalidPlayer.Age = 0;
            
            _validPlayer.ValidateAge();

            Assert.ThrowsException<ValidationException>(() => _invalidPlayer.ValidateAge());
        }

        [TestMethod]
        public void TestValidateShirtNumberTooSmall()
        {
            _validPlayer.ShirtNumber = 50;
            _invalidPlayer.ShirtNumber = 0;

            _validPlayer.ValidateShirtNumber();

            Assert.ThrowsException<ValidationException>(() => _invalidPlayer.ValidateShirtNumber());
        }
        [TestMethod]
        public void TestValidateShirtNumberTooLarge()
        {
            _invalidPlayer.ShirtNumber = 100;

            Assert.ThrowsException<ValidationException>(() => _invalidPlayer.ValidateShirtNumber());
        }
    }
}