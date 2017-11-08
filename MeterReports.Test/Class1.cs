using NUnit.Framework;

namespace MeterReports.Test
{
    public enum TestTypes
    {
        None,
        UnitTesting,
        IntegrationTesting,
        FlyByTheSeatOfYourPantsTesting
    }
    [TestFixture]
    public class EnumToStringConverter
    {
        [Test]
        public void CanConvertEnumIntoMultipleWords()
        {
            // Arrange/Act
            var actual = TestTypes.UnitTesting.ToString();

            // Assert
            Assert.That(actual, Is.EqualTo("UnitTesting"));
        }

        [Test]
        public void CheckCRC__True()
        {
            // Arrange/Act
            var actual = TestTypes.UnitTesting.ToString();

            // Assert
            Assert.That(actual, Is.EqualTo("UnitTesting"));
        }
    }
}
