using UnityEngine;

namespace Polytoria.Datamodel
{
	public struct ClientSyncState
	{
		public float nextSyncTime;

		public Vector3 velocity;

		public Vector3 angularVelocity;

		public bool isKinematic;

		public bool useGravity;

		public float drag;

		public float angularDrag;
	}
}
