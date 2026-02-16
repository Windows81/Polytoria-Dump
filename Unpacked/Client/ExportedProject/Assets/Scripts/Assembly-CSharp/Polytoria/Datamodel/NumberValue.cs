using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class NumberValue : ValueBase
	{
		[SyncVar(hook = "OnValueChanged")]
		private float val;

		public Action<float, float> _Mirror_SyncVarHookDelegate_val;

		[Archivable]
		[CreatorProperty]
		public float Value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Networkval
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

		protected override void CopyProperties(Instance clone)
		{
		}

		private void OnValueChanged(float oldValue, float newValue)
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
