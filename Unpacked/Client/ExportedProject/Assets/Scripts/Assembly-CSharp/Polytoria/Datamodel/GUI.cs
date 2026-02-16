using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.UI;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class GUI : Instance
	{
		private CreatorViewport vp;

		[SyncVar(hook = "SyncSetVisible")]
		private bool visible;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_visible;

		[CreatorProperty]
		[Archivable]
		public bool Visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Networkvisible
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

		protected override void Start()
		{
		}

		public void Update()
		{
		}

		public void SyncSetVisible(bool oldValue, bool newValue)
		{
		}

		protected override void OnHide()
		{
		}

		protected override void OnShow()
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
