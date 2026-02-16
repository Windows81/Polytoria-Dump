using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class ColorValue : ValueBase
	{
		[SyncVar(hook = "OnValueChanged")]
		private Color val;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_val;

		[Archivable]
		[CreatorProperty]
		public Color Value
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color Networkval
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

		protected override void CopyProperties(Instance clone)
		{
		}

		private void OnValueChanged(Color oldValue, Color newValue)
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
