namespace MyProject.Extensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Determines the number of decimal places needed based on the resolution provided.
        /// </summary>
        /// <param name="resolution"></param>
        /// <returns></returns>
        public static int DecimalPlaces(this double resolution)
        {
            resolution = Math.Abs(resolution);
            var decimalPlaces = 0;
            while (resolution % 1 != 0)
            {
                resolution *= 10;
                decimalPlaces++;
            }

            return decimalPlaces;
        }
        
        /// <summary>
        /// Provides a tolerance value given the number of decimal places.
        /// </summary>
        /// <param name="decimalPlaces"></param>
        /// <returns></returns>
        /// <remarks>If decimal places equals 2, then result would be 0.01</remarks>
        public static double PrecisionTolerance(int decimalPlaces)
        {
            return Math.Pow(10, -decimalPlaces);
        }
    }
}
