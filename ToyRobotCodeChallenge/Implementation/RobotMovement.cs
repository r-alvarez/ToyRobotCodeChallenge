using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ToyRobotCodeChallengeTests")]

namespace ToyRobotCodeChallenge
{
    internal class RobotMovement
    {
        readonly Robot robot = new();

        /// <summary>
        /// Places Robot at the values of the Parameters, only if the values are 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="facing"></param>
        internal void Place(int x, int y, string facing)
        {
            if (Validation.IsValidCardinalPoint(facing))
            {
                /*Verify that the robot can be placed in the table*/
                if (Validation.IsValidPosition(x) || Validation.IsValidPosition(y))
                {
                    robot.RobotPlaced = true;
                }

                /*Only update if X is still on the surface table*/
                if (Validation.IsValidPosition(x))
                {

                    robot.X = x;
                }

                /*Only update if Y is still on the surface table*/
                if (Validation.IsValidPosition(y))
                {
                    robot.Y = y;
                }

                robot.CardinalPoint = facing.StringToCardinalPoint();
            }
            else
            {
                Console.WriteLine("Incorrect value passed as facing value, placement has been ignored.");
            }

        }

        /// <summary>
        /// Turns the cardinal position of the Robot 90 degrees to the right.
        /// </summary>
        internal void Right()
        {
            var currentCardinalPoint = robot.CardinalPoint;

            switch (currentCardinalPoint)
            {
                case CardinalPoint.NORTH:
                    robot.CardinalPoint = CardinalPoint.EAST;
                    break;
                case CardinalPoint.SOUTH:
                    robot.CardinalPoint = CardinalPoint.WEST;
                    break;
                case CardinalPoint.EAST:
                    robot.CardinalPoint = CardinalPoint.SOUTH;
                    break;
                default:
                    robot.CardinalPoint = CardinalPoint.NORTH;
                    break;
            }
        }

        /// <summary>
        /// Turns the cardinal position of the Robot 90 degrees to the right.
        /// </summary>
        internal void Left()
        {
            var currentCardinalPoint = robot.CardinalPoint;

            switch (currentCardinalPoint)
            {
                case CardinalPoint.NORTH:
                    robot.CardinalPoint = CardinalPoint.WEST;
                    break;
                case CardinalPoint.SOUTH:
                    robot.CardinalPoint = CardinalPoint.EAST;
                    break;
                case CardinalPoint.EAST:
                    robot.CardinalPoint = CardinalPoint.NORTH;
                    break;
                default:
                    robot.CardinalPoint = CardinalPoint.SOUTH;
                    break;
            }
        }

        /// <summary>
        /// Allows the robot to move in the direction is facing.
        /// </summary>
        internal void Move()
        {
            //Movement can only ocurr if the robot was already placed.
            if (robot.RobotPlaced)
            {
                var currentY = robot.Y;
                var currentX = robot.X;

                switch (robot.CardinalPoint)
                {
                    case CardinalPoint.NORTH:
                        robot.Y = Validation.ForwardMovement(currentY);
                        break;
                    case CardinalPoint.SOUTH:
                        robot.Y = Validation.BackwardMovement(currentY);
                        break;
                    case CardinalPoint.EAST:
                        robot.X = Validation.ForwardMovement(currentX);
                        break;
                    case CardinalPoint.WEST:
                        robot.X = Validation.BackwardMovement(currentX);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Robot needs to be placed first, No movement has ocurred");
            }

        }

        /// <summary>
        /// Reports the current position of the Robot.
        /// </summary>
        /// <returns></returns>
        internal string? Report()
        {
            var positionReport = $"{robot.X},{robot.Y},{robot.CardinalPoint.CardinalPointToString()}";
            Console.WriteLine(positionReport);
            return positionReport;

        }
    }
}
