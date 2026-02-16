using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	public class Climbable : Part
	{
		[SyncVar]
		private float climbSpeed;

		[CreatorProperty]
		[Archivable]
		public float ClimbSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float NetworkclimbSpeed
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
