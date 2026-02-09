using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class SceneSettings : Settings
	{
		[SerializeField]
		private ScenePhysicsMode _physicsMode;

		[SerializeField]
		private float _noVolumeObjectSize;

		public ScenePhysicsMode PhysicsMode
		{
			get
			{
				return default(ScenePhysicsMode);
			}
			set
			{
			}
		}

		public float NoVolumeObjectSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
