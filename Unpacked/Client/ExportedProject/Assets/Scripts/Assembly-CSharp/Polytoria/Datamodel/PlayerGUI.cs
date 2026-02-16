using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	public class PlayerGUI : Instance
	{
		private CanvasGroup canvasGroup;

		[SyncVar(hook = "SyncSetInteractable")]
		private bool interactable;

		[SyncVar(hook = "SyncSetOpacity")]
		private float opacity;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_interactable;

		public Action<float, float> _Mirror_SyncVarHookDelegate_opacity;

		[Archivable]
		[CreatorProperty]
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

		[Archivable]
		[CreatorProperty]
		public float Opacity
		{
			get
			{
				return 0f;
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

		public float Networkopacity
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

		private void SyncSetInteractable(bool oldValue, bool newValue)
		{
		}

		private void SyncSetOpacity(float oldValue, float newValue)
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
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
