using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class BoxGizmo : GizmoBehaviour
	{
		public enum Usage
		{
			Generic = 0,
			ObjectScale = 1
		}

		private Usage _usage;

		private bool _isUsagePermanent;

		private Vector3 _boxSize;

		private GameObject _targetHierarchy;

		private Transform _targetHierarchyTransform;

		private LocalTransformSnapshot _dragBeginTargetTransformSnapshot;

		private GizmoCap2D _rightTick;

		private GizmoCap2D _topTick;

		private GizmoCap2D _backTick;

		private GizmoCap2D _leftTick;

		private GizmoCap2D _bottomTick;

		private GizmoCap2D _frontTick;

		private GizmoCap2DCollection _ticks;

		private bool _scaleFromCenter;

		private Vector3 _scalePivot;

		private GizmoSglAxisScaleDrag3D.WorkData _scaleDragWorkData;

		private GizmoSglAxisScaleDrag3D _scaleDrag;

		[SerializeField]
		private BoxGizmoSettings3D _settings3D;

		private BoxGizmoSettings3D _sharedSettings3D;

		[SerializeField]
		private BoxGizmoLookAndFeel3D _lookAndFeel3D;

		private BoxGizmoLookAndFeel3D _sharedLookAndFeel3D;

		private BoxGizmoHotkeys _hotkeys;

		private BoxGizmoHotkeys _sharedHotkeys;

		public BoxGizmoSettings3D Settings3D => null;

		public BoxGizmoSettings3D SharedSettings3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BoxGizmoLookAndFeel3D LookAndFeel3D => null;

		public BoxGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BoxGizmoHotkeys Hotkeys => null;

		public BoxGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Usage BoxUsage => default(Usage);

		public bool IsUsagePermanent => false;

		public Vector3 BoxCenter => default(Vector3);

		public Quaternion BoxRotation => default(Quaternion);

		public Vector3 BoxRight => default(Vector3);

		public Vector3 BoxUp => default(Vector3);

		public Vector3 BoxLook => default(Vector3);

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

		public void MakeUsagePermanent()
		{
		}

		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		public bool IsXTick(int handleId)
		{
			return false;
		}

		public bool IsYTick(int handleId)
		{
			return false;
		}

		public bool IsZTick(int handleId)
		{
			return false;
		}

		public void SetSnapEnabled(bool isEnabled)
		{
		}

		public void SetSize(Vector3 size)
		{
		}

		public void SetUsage(Usage usage)
		{
		}

		public bool SetTargetHierarchy(GameObject targetHierarchy)
		{
			return false;
		}

		public bool FitBoxToTargetHierarchy()
		{
			return false;
		}

		public override void OnAttached()
		{
		}

		public override bool OnGizmoCanBeginDrag(int handleId)
		{
			return false;
		}

		public override void OnGizmoUpdateBegin()
		{
		}

		public override void OnGizmoRender(Camera camera)
		{
		}

		public override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		public override void OnGizmoDragEnd(int handleId)
		{
		}

		private void OnUndoRedoEnd(IUndoRedoAction action)
		{
		}

		private void UpdateTickPositions()
		{
		}

		private void ValidateBoxSize()
		{
		}

		private void SetupSharedLookAndFeel()
		{
		}

		private void SetupSharedSettings()
		{
		}

		private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, GizmoTransform.ChangeData changeData)
		{
		}

		private OBB CalcTargetRootOBB(GameObject targetRoot)
		{
			return default(OBB);
		}
	}
}
