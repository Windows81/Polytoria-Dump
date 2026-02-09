using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class BoolValue : ValueBase
	{
		[SyncVar(hook = "OnValueChanged")]
		private bool val;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_val;

		[Archivable]
		[CreatorProperty]
		public bool Value
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Networkval
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

		protected override void CopyProperties(Instance clone)
		{
		}

		private void OnValueChanged(bool oldValue, bool newValue)
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
