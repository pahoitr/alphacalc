namespace AlphaCalc
{
    /// <summary>
    /// Provides a set of static method for calculation.
    /// </summary>
    public static class IntCalculator
    {
        /// <summary>
        /// Calculates sum of two numbers.
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <returns>Sum of <paramref name="first"/> and <paramref name="second"/> numbers.</returns>
        public static int Sum(int first, int second)
        {
            return first + second;
        }

        /// <summary>
        /// Calculates product of two numbers.
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <returns>Product of <paramref name="first"/> and <paramref name="second"/> numbers.</returns>
        public static int Multiply(int first, int second)
        {
            return first * second;
        }
    }
}
