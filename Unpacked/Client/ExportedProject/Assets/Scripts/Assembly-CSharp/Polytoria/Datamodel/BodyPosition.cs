using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class BodyPosition : Instance
	{
		[SyncVar]
		private Vector3 tPos;

		[SyncVar]
		private float force;

		[SyncVar]
		private float accDist;

		[CreatorProperty]
		[Archivable]
		public Vector3 TargetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public float Force
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public float AcceptanceDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 NetworktPos
		{
			get
			{
				return default(Vector3);
			}
			[param: In]
			set
			{
			}
		}

		public float Networkforce
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public float NetworkaccDist
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		protected override void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
