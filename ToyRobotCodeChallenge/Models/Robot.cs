namespace ToyRobotCodeChallenge
{
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CardinalPoint CardinalPoint { get; set; }

        /*Checker for command placed being run.*/
        public bool RobotPlaced { get; set; }
    }
}
