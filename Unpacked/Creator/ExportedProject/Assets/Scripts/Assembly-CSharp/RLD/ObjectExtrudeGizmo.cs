using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectExtrudeGizmo : GizmoBehaviour
	{
		private struct HandleDragExtrudeData
		{
			public Vector3 ExtrudeDir;

			public Vector3 ExtrudeCenter;

			public int AxisIndex;
		}

		private List<GameObject> _objectBuffer;

		private Vector3 _boxSize;

		private GizmoSpace _extrudeSpace;

		private List<GameObject> _targetParents;

		private HashSet<GameObject> _ignoredParentObjects;

		private ObjectBounds.QueryConfig _boundsQConfig;

		private SceneOverlapFilter _sceneOverlapFilter;

		private ObjectExtrudeGizmoDragEnd _dragEndAction;

		private HandleDragExtrudeData _handleDragExtrData;

		private GizmoLineSlider3D _rightExtrude;

		private GizmoLineSlider3D _upExtrude;

		private GizmoLineSlider3D _frontExtrude;

		private GizmoLineSlider3D _leftExtrude;

		private GizmoLineSlider3D _bottomExtrude;

		private GizmoLineSlider3D _backExtrude;

		private GizmoLineSlider3DCollection _extrudeSliders;

		[SerializeField]
		private ObjectExtrudeGizmoLookAndFeel3D _lookAndFeel3D;

		private ObjectExtrudeGizmoLookAndFeel3D _sharedLookAndFeel3D;

		[SerializeField]
		private ObjectExtrudeGizmoHotkeys _hotkeys;

		private ObjectExtrudeGizmoHotkeys _sharedHotkeys;

		public ObjectExtrudeGizmoLookAndFeel3D LookAndFeel3D => null;

		public ObjectExtrudeGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObjectExtrudeGizmoHotkeys Hotkeys => null;

		public ObjectExtrudeGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 BoxCenter => default(Vector3);

		public Quaternion BoxRotation => default(Quaternion);

		public Vector3 BoxSize => default(Vector3);

		public Vector3 BoxRight => default(Vector3);

		public Vector3 BoxUp => default(Vector3);

		public Vector3 BoxLook => default(Vector3);

		public OBB OBB => default(OBB);

		public GizmoSpace ExtrudeSpace => default(GizmoSpace);

		public int NumTargetParents => 0;

		public event ObjectExtrudeGizmoExtrudeUpdateHandler ExtrudeUpdate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		public bool IsRightExtrudeHandle(int handleId)
		{
			return false;
		}

		public bool IsLeftExtrudeHandle(int handleId)
		{
			return false;
		}

		public bool IsTopExtrudeHandle(int handleId)
		{
			return false;
		}

		public bool IsBottomExtrudeHandle(int handleId)
		{
			return false;
		}

		public bool IsFrontExtrudeHandle(int handleId)
		{
			return false;
		}

		public bool IsBackExtrudeHandle(int handleId)
		{
			return false;
		}

		public void SetIgnoredParentObjects(IEnumerable<GameObject> ignoredParentObjects)
		{
		}

		public void SetExtrudeSpace(GizmoSpace extrudeSpace)
		{
		}

		public void SetExtrudeTargets(IEnumerable<GameObject> extrudeTargets)
		{
		}

		public void FitBoxToTargets()
		{
		}

		public override void OnDetached()
		{
		}

		public override void OnEnabled()
		{
		}

		public override void OnDisabled()
		{
		}

		public override void OnGizmoEnabled()
		{
		}

		public override void OnAttached()
		{
		}

		public override void OnGizmoUpdateBegin()
		{
		}

		public override void OnGizmoRender(Camera camera)
		{
		}

		public override void OnGizmoDragBegin(int handleId)
		{
		}

		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		public override void OnGizmoDragEnd(int handleId)
		{
		}

		private void UpdateExtrudeSliderTransforms()
		{
		}

		private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, GizmoTransform.ChangeData changeData)
		{
		}

		private void SetAABB(AABB aabb)
		{
		}

		private void SetOBB(OBB obb)
		{
		}

		private void UpdateSnapSteps()
		{
		}

		private void ValidateBoxSize()
		{
		}

		private void SetupSharedLookAndFeel()
		{
		}

		private void OnUndoRedoEnd(IUndoRedoAction action)
		{
		}
	}
}
