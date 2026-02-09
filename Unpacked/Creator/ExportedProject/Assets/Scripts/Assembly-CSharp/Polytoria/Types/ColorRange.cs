using UnityEngine;

namespace Polytoria.Types
{
	public struct ColorRange
	{
		public Color min;

		public Color max;

		public ColorRange(Color min, Color max)
		{
			this.min = default(Color);
			this.max = default(Color);
		}

		public Color Lerp(float t)
		{
			return default(Color);
		}

		public static ColorRange New(Color min, Color max)
		{
			return default(ColorRange);
		}
	}
}
