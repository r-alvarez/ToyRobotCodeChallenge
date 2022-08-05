namespace ToyRobotCodeChallenge
{
    /// <summary>
    /// Class with extension methods created to support functionality
    /// </summary>
    internal static class HelperMethods
    {
        /// <summary>
        /// Converter for String values to Cardinal Points.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal static CardinalPoint StringToCardinalPoint(this string value)
        {
            if (value == "NORTH")
                return CardinalPoint.NORTH;
            if (value == "SOUTH")
                return CardinalPoint.SOUTH;
            if (value == "EAST")
                return CardinalPoint.EAST;

            return CardinalPoint.WEST;
        }

        internal static string CardinalPointToString(this CardinalPoint cardinalPoint) => Enum.GetName(typeof(CardinalPoint), cardinalPoint);

    }
}
