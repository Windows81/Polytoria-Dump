using UnityEngine;

namespace Polytoria.Controllers
{
	public class AppearanceData
	{
		public Color headColor;

		public Color torsoColor;

		public Color leftArmColor;

		public Color rightArmColor;

		public Color leftLegColor;

		public Color rightLegColor;

		public string[] hatUrls;

		public int faceID;

		public int shirtID;

		public int pantsID;

		public int torsoID;

		public string torsoUrl;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
