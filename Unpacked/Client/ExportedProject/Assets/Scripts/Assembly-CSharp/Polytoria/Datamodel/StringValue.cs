using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class StringValue : ValueBase
	{
		[SyncVar(hook = "OnValueChanged")]
		private string val;

		public Action<string, string> _Mirror_SyncVarHookDelegate_val;

		[Archivable]
		[CreatorProperty]
		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Networkval
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		private void OnValueChanged(string oldValue, string newValue)
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
