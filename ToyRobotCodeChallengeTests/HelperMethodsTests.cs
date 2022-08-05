using ToyRobotCodeChallenge;

namespace ToyRobotCodeChallengeTests
{
    public class HelperMethodsTests
    {
        [Test]
        public void TestStringToCardinalPoint()
        {
            /*As only valid cardinal points are allowed in the system (through Place) we only test for valid cardinal points conversions*/

            var cardinalPoint = "NORTH";
            var convertedCP = cardinalPoint.StringToCardinalPoint();

            Assert.AreEqual(CardinalPoint.NORTH, convertedCP);

            cardinalPoint = "SOUTH";
            convertedCP = cardinalPoint.StringToCardinalPoint();

            Assert.AreEqual(CardinalPoint.SOUTH, convertedCP);

            cardinalPoint = "EAST";
            convertedCP = cardinalPoint.StringToCardinalPoint();

            Assert.AreEqual(CardinalPoint.EAST, convertedCP);

            cardinalPoint = "WEST";
            convertedCP = cardinalPoint.StringToCardinalPoint();

            Assert.AreEqual(CardinalPoint.WEST, convertedCP);

        }

        [Test]
        public void TestCardinalPointToString()
        {
            var cardinalPoint = CardinalPoint.NORTH.CardinalPointToString();

            Assert.AreEqual(cardinalPoint, "NORTH");

            cardinalPoint = CardinalPoint.SOUTH.CardinalPointToString();
            Assert.AreEqual(cardinalPoint, "SOUTH");

            cardinalPoint = CardinalPoint.EAST.CardinalPointToString();
            Assert.AreEqual(cardinalPoint, "EAST");

            cardinalPoint = CardinalPoint.WEST.CardinalPointToString();

            Assert.AreEqual(cardinalPoint, "WEST");
        }

    }
}