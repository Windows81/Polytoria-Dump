using System;
using Polytoria.Datamodel;

namespace Polytoria.Types
{
	[Serializable]
	public struct FootstepMaterial
	{
		public PartMaterial partMaterial;

		public FootstepSounds sounds;
	}
}
