using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class Spotlight : DynamicInstance
	{
		private static float intensityMultiplier;

		private static float rangeMultiplier;

		[SyncVar]
		private float range;

		[SyncVar]
		private float brightness;

		[SyncVar]
		private Color color;

		[SyncVar]
		private float angle;

		[SyncVar]
		private bool shadows;

		[CreatorProperty]
		[Archivable]
		public float Range
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
		public float Angle
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
		public float Brightness
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
		public Color Color
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

		public float Networkrange
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

		public float Networkbrightness
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

		public Color Networkcolor
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

		public float Networkangle
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

		public bool Networkshadows
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		protected override void Start()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		[ClientRpc]
		private void RpcSetRange(float range)
		{
		}

		[ClientRpc]
		private void RpcSetAngle(float angle)
		{
		}

		[ClientRpc]
		private void RpcSetBrightness(float brightness)
		{
		}

		[ClientRpc]
		private void RpcSetColor(Color color)
		{
		}

		[ClientRpc]
		private void RpcSetShadowsEnabled(bool enabled)
		{
		}

		static Spotlight()
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSetRange__Single(float range)
		{
		}

		protected static void InvokeUserCode_RpcSetRange__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetAngle__Single(float angle)
		{
		}

		protected static void InvokeUserCode_RpcSetAngle__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetBrightness__Single(float brightness)
		{
		}

		protected static void InvokeUserCode_RpcSetBrightness__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetColor__Color(Color color)
		{
		}

		protected static void InvokeUserCode_RpcSetColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetShadowsEnabled__Boolean(bool enabled)
		{
		}

		protected static void InvokeUserCode_RpcSetShadowsEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
