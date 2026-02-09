using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class IntValue : ValueBase
	{
		[SyncVar(hook = "OnValueChanged")]
		private int val;

		public Action<int, int> _Mirror_SyncVarHookDelegate_val;

		[Archivable]
		[CreatorProperty]
		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Networkval
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		private void OnValueChanged(int oldValue, int newValue)
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
