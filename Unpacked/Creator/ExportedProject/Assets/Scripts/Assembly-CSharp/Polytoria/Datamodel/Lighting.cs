using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	public class Lighting : Instance
	{
		[SyncVar]
		private Color ambientColor;

		[SyncVar]
		private AmbientSource ambientSource;

		private SunLight sun;

		[CreatorProperty]
		[Archivable]
		public Color AmbientColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public AmbientSource AmbientSource
		{
			get
			{
				return default(AmbientSource);
			}
			set
			{
			}
		}

		public bool Shadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float SunBrightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color SunColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color NetworkambientColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		public AmbientSource NetworkambientSource
		{
			get
			{
				return default(AmbientSource);
			}
			[param: In]
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		[ClientRpc]
		private void RpcSetAmbientColor(Color c)
		{
		}

		[ClientRpc]
		private void RpcSetAmbientSource(AmbientSource source)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSetAmbientColor__Color(Color c)
		{
		}

		protected static void InvokeUserCode_RpcSetAmbientColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetAmbientSource__AmbientSource(AmbientSource source)
		{
		}

		protected static void InvokeUserCode_RpcSetAmbientSource__AmbientSource(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static Lighting()
		{
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
