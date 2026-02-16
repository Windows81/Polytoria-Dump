using System;
using System.Runtime.InteropServices;
using Mirror;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class Text3D : DynamicInstance
	{
		private TMP_Text tmp;

		[SyncVar]
		protected string text;

		[SyncVar]
		protected Color color;

		[SyncVar]
		protected float fontSize;

		[SyncVar]
		protected bool faceCamera;

		[SyncVar]
		protected HorizontalAlignmentOptions horizontalAlignment;

		[SyncVar]
		protected VerticalAlignmentOptions verticalAlignment;

		[SyncVar(hook = "SyncSetFont")]
		private TextFontPreset font;

		[SyncVar]
		private Vector3 rotationCache;

		[SyncVar]
		private Vector3 positionCache;

		[SerializeField]
		private ContentSizeFitter csf;

		public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font;

		[CreatorProperty]
		[Archivable]
		public string Text
		{
			get
			{
				return null;
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
		public float FontSize
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
		public bool FaceCamera
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public HorizontalAlignmentOptions HorizontalAlignment
		{
			get
			{
				return default(HorizontalAlignmentOptions);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public VerticalAlignmentOptions VerticalAlignment
		{
			get
			{
				return default(VerticalAlignmentOptions);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public TextFontPreset Font
		{
			get
			{
				return default(TextFontPreset);
			}
			set
			{
			}
		}

		public string Networktext
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

		public float NetworkfontSize
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

		public bool NetworkfaceCamera
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

		public HorizontalAlignmentOptions NetworkhorizontalAlignment
		{
			get
			{
				return default(HorizontalAlignmentOptions);
			}
			[param: In]
			set
			{
			}
		}

		public VerticalAlignmentOptions NetworkverticalAlignment
		{
			get
			{
				return default(VerticalAlignmentOptions);
			}
			[param: In]
			set
			{
			}
		}

		public TextFontPreset Networkfont
		{
			get
			{
				return default(TextFontPreset);
			}
			[param: In]
			set
			{
			}
		}

		public Vector3 NetworkrotationCache
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

		public Vector3 NetworkpositionCache
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

		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		[ClientRpc]
		private void RpcSetText(string t)
		{
		}

		[ClientRpc]
		private void RpcSetColor(Color color)
		{
		}

		[ClientRpc]
		private void RpcSetFontSize(float fs)
		{
		}

		[ClientRpc]
		private void RpcSetHorizontalAlignment(HorizontalAlignmentOptions al)
		{
		}

		[ClientRpc]
		private void RpcSetVerticalAlignment(VerticalAlignmentOptions al)
		{
		}

		private void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSetText__String(string t)
		{
		}

		protected static void InvokeUserCode_RpcSetText__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetColor__Color(Color color)
		{
		}

		protected static void InvokeUserCode_RpcSetColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetFontSize__Single(float fs)
		{
		}

		protected static void InvokeUserCode_RpcSetFontSize__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions(HorizontalAlignmentOptions al)
		{
		}

		protected static void InvokeUserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions(VerticalAlignmentOptions al)
		{
		}

		protected static void InvokeUserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static Text3D()
		{
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
