using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;
using SoftMasking;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class UIField : Instance, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		public LuaEvent MouseUp;

		public LuaEvent MouseDown;

		[SyncVar(hook = "SyncSetPositionOffset")]
		private Vector2 positionOffset;

		[SyncVar(hook = "SyncSetSizeOffset")]
		private Vector2 sizeOffset;

		[SyncVar(hook = "SyncSetPositionRelative")]
		private Vector2 positionRelative;

		[SyncVar(hook = "SyncSetSizeRelative")]
		private Vector2 sizeRelative;

		[SyncVar(hook = "SyncSetRotation")]
		private float rotation;

		[SyncVar(hook = "SyncSetPivotPoint")]
		private Vector2 pivotPoint;

		[SyncVar(hook = "SyncSetVisible")]
		private bool visible;

		[SyncVar(hook = "SyncSetClipDescendants")]
		private bool clipDescendants;

		private RectTransform parentRect;

		private RectTransform recttransform;

		private SoftMask mask;

		private bool hasHVLayoutParent;

		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_positionOffset;

		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_sizeOffset;

		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_positionRelative;

		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_sizeRelative;

		public Action<float, float> _Mirror_SyncVarHookDelegate_rotation;

		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_pivotPoint;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_visible;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_clipDescendants;

		[CreatorProperty]
		[Archivable]
		public Vector2 PositionOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public Vector2 PositionRelative
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public float Rotation
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
		public Vector2 SizeOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public Vector2 SizeRelative
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public Vector2 PivotPoint
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

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

		[CreatorProperty]
		[Archivable]
		public bool ClipDescendants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector2 NetworkpositionOffset
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		public Vector2 NetworksizeOffset
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		public Vector2 NetworkpositionRelative
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		public Vector2 NetworksizeRelative
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		public float Networkrotation
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

		public Vector2 NetworkpivotPoint
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
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

		public bool NetworkclipDescendants
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

		private void SyncSetPositionOffset(Vector2 oldValue, Vector2 newValue)
		{
		}

		private void SyncSetSizeOffset(Vector2 oldValue, Vector2 newValue)
		{
		}

		private void SyncSetPositionRelative(Vector2 oldValue, Vector2 newValue)
		{
		}

		private void SyncSetSizeRelative(Vector2 oldValue, Vector2 newValue)
		{
		}

		private void SyncSetRotation(float oldValue, float newValue)
		{
		}

		private void SyncSetPivotPoint(Vector2 oldValue, Vector2 newValue)
		{
		}

		private void SyncSetVisible(bool oldValue, bool newValue)
		{
		}

		private void SyncSetClipDescendants(bool oldValue, bool newValue)
		{
		}

		protected override void Awake()
		{
		}

		private void UpdateVisibility()
		{
		}

		protected override void Start()
		{
		}

		private void Update()
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

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
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
