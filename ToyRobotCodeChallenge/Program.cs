// See https://aka.ms/new-console-template for more information

/*Example Inputs*/

using ToyRobotCodeChallenge;

var robot = new RobotMovement();


/*Example a*/
Console.WriteLine("Example A");

robot.Place(0, 0, "NORTH");
robot.Move();
robot.Report();

/*Example b*/

Console.WriteLine("Example B");
robot.Place(0, 0, "NORTH");
robot.Left();
robot.Report();

/*Example C*/
Console.WriteLine("Example C");

robot.Place(1, 2, "EAST");
robot.Move();
robot.Move();
robot.Left();
robot.Move();
robot.Report();

Console.ReadKey();

