using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class InstanceValue : ValueBase
	{
		[SyncVar(hook = "OnValueChanged")]
		private Instance val;

		protected NetworkBehaviourSyncVar ___valNetId;

		public Action<Instance, Instance> _Mirror_SyncVarHookDelegate_val;

		[Archivable]
		[CreatorProperty]
		public Instance Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Instance Networkval
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

		private void OnValueChanged(Instance oldValue, Instance newValue)
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
