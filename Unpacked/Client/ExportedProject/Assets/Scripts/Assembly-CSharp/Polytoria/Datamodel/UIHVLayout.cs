using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	public class UIHVLayout : UIField
	{
		protected HorizontalOrVerticalLayoutGroup layoutGroup;

		[SyncVar(hook = "SyncSpacing")]
		protected float spacing;

		[SyncVar(hook = "SyncChildControlWidth")]
		protected bool childControlWidth;

		[SyncVar(hook = "SyncChildControlHeight")]
		protected bool childControlHeight;

		[SyncVar(hook = "SyncChildScaleWidth")]
		protected bool childScaleWidth;

		[SyncVar(hook = "SyncChildScaleHeight")]
		protected bool childScaleHeight;

		[SyncVar(hook = "SyncChildForceExpandWidth")]
		protected bool childForceExpandWidth;

		[SyncVar(hook = "SyncChildForceExpandHeight")]
		protected bool childForceExpandHeight;

		[SyncVar(hook = "SyncPaddingLeft")]
		protected int paddingLeft;

		[SyncVar(hook = "SyncPaddingRight")]
		protected int paddingRight;

		[SyncVar(hook = "SyncPaddingTop")]
		protected int paddingTop;

		[SyncVar(hook = "SyncPaddingBottom")]
		protected int paddingBottom;

		[SyncVar(hook = "SyncChildAlignment")]
		protected TextAnchor childAlignment;

		[SyncVar(hook = "SyncReverseAlignment")]
		protected bool reverseAlignment;

		public Action<float, float> _Mirror_SyncVarHookDelegate_spacing;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childControlWidth;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childControlHeight;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childScaleWidth;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childScaleHeight;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childForceExpandWidth;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childForceExpandHeight;

		public Action<int, int> _Mirror_SyncVarHookDelegate_paddingLeft;

		public Action<int, int> _Mirror_SyncVarHookDelegate_paddingRight;

		public Action<int, int> _Mirror_SyncVarHookDelegate_paddingTop;

		public Action<int, int> _Mirror_SyncVarHookDelegate_paddingBottom;

		public Action<TextAnchor, TextAnchor> _Mirror_SyncVarHookDelegate_childAlignment;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_reverseAlignment;

		[CreatorProperty]
		[Archivable]
		public float Spacing
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
		public bool ChildControlWidth
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
		public bool ChildControlHeight
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
		public bool ChildScaleWidth
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
		public bool ChildScaleHeight
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
		public bool ChildForceExpandWidth
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
		public bool ChildForceExpandHeight
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
		public int PaddingLeft
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public int PaddingRight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public int PaddingTop
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public int PaddingBottom
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public TextAnchor ChildAlignment
		{
			get
			{
				return default(TextAnchor);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public bool ReverseAlignment
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Networkspacing
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

		public bool NetworkchildControlWidth
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

		public bool NetworkchildControlHeight
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

		public bool NetworkchildScaleWidth
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

		public bool NetworkchildScaleHeight
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

		public bool NetworkchildForceExpandWidth
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

		public bool NetworkchildForceExpandHeight
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

		public int NetworkpaddingLeft
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

		public int NetworkpaddingRight
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

		public int NetworkpaddingTop
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

		public int NetworkpaddingBottom
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

		public TextAnchor NetworkchildAlignment
		{
			get
			{
				return default(TextAnchor);
			}
			[param: In]
			set
			{
			}
		}

		public bool NetworkreverseAlignment
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

		private void SyncSpacing(float oldValue, float newValue)
		{
		}

		private void SyncChildControlWidth(bool oldValue, bool newValue)
		{
		}

		private void SyncChildControlHeight(bool oldValue, bool newValue)
		{
		}

		private void SyncChildScaleWidth(bool oldValue, bool newValue)
		{
		}

		private void SyncChildScaleHeight(bool oldValue, bool newValue)
		{
		}

		private void SyncChildForceExpandWidth(bool oldValue, bool newValue)
		{
		}

		private void SyncChildForceExpandHeight(bool oldValue, bool newValue)
		{
		}

		private void SyncPaddingLeft(int oldValue, int newValue)
		{
		}

		private void SyncPaddingRight(int oldValue, int newValue)
		{
		}

		private void SyncPaddingTop(int oldValue, int newValue)
		{
		}

		private void SyncPaddingBottom(int oldValue, int newValue)
		{
		}

		private void SyncChildAlignment(TextAnchor oldValue, TextAnchor newValue)
		{
		}

		private void SyncReverseAlignment(bool oldValue, bool newValue)
		{
		}

		protected override void Start()
		{
		}

		private void LateUpdate()
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
