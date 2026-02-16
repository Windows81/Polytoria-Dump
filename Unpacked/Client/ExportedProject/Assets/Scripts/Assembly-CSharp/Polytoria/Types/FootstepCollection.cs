using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Types
{
	[CreateAssetMenu(fileName = "FootstepCollection", menuName = "Polytoria/FootstepCollection")]
	public class FootstepCollection : ScriptableObject
	{
		public FootstepSounds fallback;

		public FootstepMaterial[] sounds;

		public FootstepSounds GetSounds(PartMaterial partMaterial)
		{
			return null;
		}
	}
}
