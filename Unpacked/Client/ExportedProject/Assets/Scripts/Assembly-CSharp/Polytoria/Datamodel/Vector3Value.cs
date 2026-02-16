using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class Vector3Value : ValueBase
	{
		[SyncVar(hook = "OnValueChanged")]
		private Vector3 val;

		public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_val;

		[Archivable]
		[CreatorProperty]
		public Vector3 Value
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Networkval
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

		protected override void CopyProperties(Instance clone)
		{
		}

		private void OnValueChanged(Vector3 oldValue, Vector3 newValue)
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
