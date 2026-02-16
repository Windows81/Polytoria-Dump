using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class UIButton : UILabel
	{
		private Button button;

		[SyncVar(hook = "SetInteractable")]
		private bool interactable;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_interactable;

		[CreatorProperty]
		[Archivable]
		public bool Interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Networkinteractable
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

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void SetInteractable(bool oldValue, bool value)
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
