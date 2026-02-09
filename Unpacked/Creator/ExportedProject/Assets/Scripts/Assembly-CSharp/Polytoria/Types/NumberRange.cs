namespace Polytoria.Types
{
	public struct NumberRange
	{
		public float min;

		public float max;

		public NumberRange(float min, float max)
		{
			this.min = 0f;
			this.max = 0f;
		}

		public float Lerp(float t)
		{
			return 0f;
		}

		public static NumberRange New(float min, float max)
		{
			return default(NumberRange);
		}
	}
}
