using ToyRobotCodeChallenge;

namespace ToyRobotCodeChallengeTests
{
    public class ValidationTests
    {
        [Test]
        public void TestIsValidCardinalPoint()
        {
            /*Valid Input*/
            var facingValue = "NORTH";
            var result = Validation.IsValidCardinalPoint(facingValue);

            Assert.IsTrue(result);

            /*Valid Input*/
            facingValue = "north";
            result = Validation.IsValidCardinalPoint(facingValue);
            Assert.IsTrue(result);

            /*Invalid Input*/
            facingValue = null;
            result = Validation.IsValidCardinalPoint(facingValue);
            Assert.IsFalse(result);

        }

        [Test]
        public void TestIsValidPosition()
        {
            /*Valid movement*/
            var position = 1;
            var result = Validation.IsValidPosition(position);

            Assert.IsTrue(result);

            /*Invalid Position*/
            position = -1;
            result = Validation.IsValidPosition(position);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestForwardMovement()
        {
            /*Valid Movement*/
            var position = 1;
            var result = Validation.ForwardMovement(position);

            Assert.AreEqual(result, 2);

            /*Invalid Movement*/
            position = 5;
            result = Validation.ForwardMovement(position);

            Assert.AreEqual(result, 5);

        }

        [Test]
        public void TestBackwardMovement()
        {
            /*Valid movement*/
            var position = 1;
            var result = Validation.BackwardMovement(position);

            Assert.AreEqual(result, 0);

            /*Invalid Movement*/
            position = 0;
            result = Validation.BackwardMovement(position);

            Assert.AreEqual(result, 0);

        }

        [Test]
        public void TestRobotPlacement()
        {
            var position = true; //As in robot is already in place.
            var result = Validation.IsRobotPlaced(position);

            Assert.IsTrue(result);

            position = false;

            //Test for the console warning.
            result = Validation.IsRobotPlaced(position);

            Assert.IsFalse(result);

        }
    }
}