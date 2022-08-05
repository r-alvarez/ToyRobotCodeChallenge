
namespace ToyRobotCodeChallenge
{
    internal class Validation
    {
        /// <summary>
        /// Method to check if Cardinal point has been sent in the correct format.
        /// </summary>
        /// <param name="cardinalPoint"></param>
        /// <returns></returns>
        internal static bool IsValidCardinalPoint(string cardinalPoint)
        {
            if (!string.IsNullOrWhiteSpace(cardinalPoint))
            {
                var facing = cardinalPoint.Trim().ToUpper();

                if (facing == "NORTH" || facing == "SOUTH" || facing == "EAST" || facing == "WEST")
                    return true;
            }
            /*Make sure we have the correct form of string*/
            return false;
        }

        /// <summary>
        /// The table is only 5 units long, so only 0-4 positions are valid 
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        internal static bool IsValidPosition(int coordinate) => coordinate >= 0 && coordinate < 5;

        /// <summary>
        /// Checks for Placement of the robot.
        /// </summary>
        /// <param name="placement"></param>
        /// <returns></returns>
        internal static bool IsRobotPlaced(bool placement)
        {
            if (placement)
            {
                return true;
            }

            Console.WriteLine("Robot needs to be placed first, No action has been taken");
            return false;
        }

        /// <summary>
        /// Validates that a forward movement will not throw the toy over the table top
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        internal static int ForwardMovement(int currentPosition)
        {
            var newPosition = currentPosition;
            newPosition++;

            if (IsValidPosition(newPosition))
            {
                return newPosition;
            }

            return currentPosition;
        }

        /// <summary>
        /// Validates that a backward movement will not throw the toy over the table top
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        internal static int BackwardMovement(int currentPosition)
        {

            var newPosition = currentPosition;
            newPosition--;

            if (IsValidPosition(newPosition))
            {
                return newPosition;
            }

            return currentPosition;
        }
    }
}
