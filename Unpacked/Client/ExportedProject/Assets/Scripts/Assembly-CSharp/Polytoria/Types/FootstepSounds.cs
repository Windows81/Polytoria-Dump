using UnityEngine;

namespace Polytoria.Types
{
	[CreateAssetMenu(fileName = "FootstepSounds", menuName = "Polytoria/FootstepSounds")]
	public class FootstepSounds : ScriptableObject
	{
		public AudioClip[] sounds;
	}
}
