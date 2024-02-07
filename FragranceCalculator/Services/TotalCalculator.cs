namespace FragranceCalculator.Services
{
    public class TotalCalculator
    {
        /// <summary>
        /// Calculates total wax weight for all vessel.
        /// </summary>
        /// <param name="percentage">Required fragrance percentage</param>
        /// <returns>Total wax weight</returns>
        public double CalculateTotalWaxGrams(int totalGrams, int percentage)
        {
            var totalWax = totalGrams - this.CalculateFragrance(totalGrams, percentage);

            return totalWax;
        }

        /// <summary>
        /// Calculates fragrance in grams from the percentage given.
        /// </summary>
        /// <param name="totalGrams">Grams used as a total.</param>
        /// <param name="requiredPercentage">The required percentage of fragrance.</param>
        /// <returns></returns>
        public double CalculateFragrance(int totalGrams,  int requiredPercentage)
        {
            var one = totalGrams / 100.0;
            var totalPercentage = one * requiredPercentage;

            return totalPercentage;
        }
    }
}
