namespace ToyRobotCodeChallengeTests
{
    public class MovementTests
    {
        [Test]
        public void TestPlaceRobot()
        {

            /*Positive Test*/
            var robotMovement = new RobotMovement();
            var x = 0;
            var y = 0;
            var facing = "NORTH";
            robotMovement.Place(x, y, facing);
            var currentPlace = robotMovement.Report();

            Assert.That(currentPlace, Is.EqualTo("0,0,NORTH"));

        }

        [Test]
        public void TestMove()
        {
            var robotMovement = new RobotMovement();
            robotMovement.Move();

            /*No PLACE ran. Console warning the user that place needs to be run before any movement occurs*/
            var currentPlace = robotMovement.Report();

            /*Validates to default values 0,0,NORTH*/
            Assert.That(currentPlace, Is.EqualTo("0,0,NORTH"));

            robotMovement.Place(0, 0, "NORTH");
            robotMovement.Move();
            currentPlace = robotMovement.Report();

            /*Validates to default values 0,0,NORTH*/
            Assert.That(currentPlace, Is.EqualTo("0,1,NORTH"));
        }


        [Test]
        public void TestLeft()
        {
            /*Placement needs to occur first*/
            var robotMovement = new RobotMovement();
            robotMovement.Place(0, 0, "NORTH");

            /*Check Cardinal Point modification.*/
            robotMovement.Left();
            var currentPlacement = robotMovement.Report();

            Assert.That(currentPlacement, Is.EqualTo("0,0,WEST"));
        }

        [Test]
        public void TestRight()
        {
            /*Placement needs to occur first*/
            var robotMovement = new RobotMovement();
            robotMovement.Place(0, 0, "NORTH");


            /*Check Cardinal Point modification.*/
            robotMovement.Right();
            var currentPlacement = robotMovement.Report();

            Assert.That(currentPlacement, Is.EqualTo("0,0,EAST"));
        }
    }
}