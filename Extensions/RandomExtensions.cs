namespace Extensions
{
    public static class RandomExtensions
	{
		/// <summary>
		/// Returns a random number from a normal (or Gaussian) distribution.
		/// </summary>
		/// <param name="random">Object from System.Random class.</param>
		/// <param name="mu">Mean or expectation of the distribution.</param>
		/// <param name="sigma">Variance of the distribution.</param>
		/// <returns>Random number from Gaussian distribution.</returns>
		public static double NextGaussian(this Random random, float mu = 0f, float sigma = 1f)
		{
            // uniform(0,1] random doubles
            double u1 = 1.0 - random.NextDouble(); 
			double u2 = 1.0 - random.NextDouble();
            
			//random normal(0,1)
            double stdNormal = Math.Sqrt(-2.0f * Math.Log(u1)) * Math.Sin(2.0f * Math.PI * u2);
            
			//random normal(mean,stdDev^2)
            double rand = mu + sigma * stdNormal;

			return rand;
		}

		/// <summary>
		/// Returns a random boolean value.
		/// </summary>
		/// <param name="random">Object from System.Random class.</param>
		/// <returns>A boolean value with 50% of chance to being true and 50% false.</returns>
		public static bool NextBool(this Random random)
		{
			return random.Next(0, 2) == 0;
		}
	}
}
