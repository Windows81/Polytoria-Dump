using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class UIView : UIField
	{
		private Image border;

		private RectTransform borderRect;

		private Image fill;

		[SyncVar(hook = "SyncSetColor")]
		private Color color;

		[SyncVar(hook = "SyncSetBorderWidth")]
		private float borderWidth;

		[SyncVar(hook = "SyncSetBorderColor")]
		private Color borderColor;

		[SyncVar(hook = "SyncSetCornerRadius")]
		private float cornerRadius;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_color;

		public Action<float, float> _Mirror_SyncVarHookDelegate_borderWidth;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_borderColor;

		public Action<float, float> _Mirror_SyncVarHookDelegate_cornerRadius;

		[CreatorProperty]
		[Archivable]
		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public float BorderWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public float CornerRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color Networkcolor
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

		public float NetworkborderWidth
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

		public Color NetworkborderColor
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

		public float NetworkcornerRadius
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

		private void UpdateBorder()
		{
		}

		private void SyncSetBorderWidth(float oldValue, float newValue)
		{
		}

		private void SyncSetBorderColor(Color oldValue, Color newValue)
		{
		}

		private void SyncSetCornerRadius(float oldValue, float newValue)
		{
		}

		private void SyncSetColor(Color oldValue, Color newValue)
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
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
