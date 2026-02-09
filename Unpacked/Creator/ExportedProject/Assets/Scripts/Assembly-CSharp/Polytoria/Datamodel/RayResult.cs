using UnityEngine;

namespace Polytoria.Datamodel
{
	public struct RayResult
	{
		public Vector3 Origin { get; set; }

		public Vector3 Direction { get; set; }

		public Vector3 Position { get; set; }

		public Vector3 Normal { get; set; }

		public float Distance { get; set; }

		public Instance Instance { get; set; }
	}
}
