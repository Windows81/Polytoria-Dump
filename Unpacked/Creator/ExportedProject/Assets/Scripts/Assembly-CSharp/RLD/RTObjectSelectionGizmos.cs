using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class RTObjectSelectionGizmos : MonoSingleton<RTObjectSelectionGizmos>, IObjectCollectionGizmoController
	{
		private class ObjectSelectionGizmo
		{
			private int _id;

			private Gizmo _gizmo;

			private BoxGizmo _boxScaleGizmo;

			private ObjectTransformGizmo _transformGizmo;

			private ObjectExtrudeGizmo _extrudeGizmo;

			private bool _isUsable;

			public int Id => 0;

			public Gizmo Gizmo => null;

			public BoxGizmo BoxScaleGizmo => null;

			public bool IsBoxScaleGizmo => false;

			public ObjectTransformGizmo TransformGizmo => null;

			public bool IsTransformGizmo => false;

			public ObjectExtrudeGizmo ExtrudeGizmo => null;

			public bool IsExtrudeGizmo => false;

			public bool IsUsable
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public ObjectSelectionGizmo(int id, Gizmo gizmo)
			{
			}
		}

		[SerializeField]
		private EditorToolbar _mainToolbar;

		[SerializeField]
		private UniversalGizmoConfig _universalGizmoConfig;

		private GizmoCollectionEnabledStateSnapshot _gizmosEnabledStateSnapshot;

		private List<ObjectSelectionGizmo> _allGizmos;

		private List<ObjectTransformGizmo> _objectTransformGizmos;

		private int _workGizmoId;

		private ObjectSelectionGizmo _workGizmo;

		private bool _areGizmosVisible;

		private GizmoSpace _transformSpace;

		private GameObject _pivotObject;

		private IEnumerable<GameObject> _targetObjectCollection;

		[SerializeField]
		private ObjectSelectionGizmosHotkeys _hotkeys;

		[SerializeField]
		private MoveGizmoSettings2D _moveGizmoSettings2D;

		[SerializeField]
		private MoveGizmoSettings3D _moveGizmoSettings3D;

		[SerializeField]
		private MoveGizmoLookAndFeel2D _moveGizmoLookAndFeel2D;

		[SerializeField]
		private MoveGizmoLookAndFeel3D _moveGizmoLookAndFeel3D;

		[SerializeField]
		private MoveGizmoHotkeys _moveGizmoHotkeys;

		[SerializeField]
		private ObjectTransformGizmoSettings _objectMoveGizmoSettings;

		[SerializeField]
		private RotationGizmoSettings3D _rotationGizmoSettings3D;

		[SerializeField]
		private RotationGizmoLookAndFeel3D _rotationGizmoLookAndFeel3D;

		[SerializeField]
		private RotationGizmoHotkeys _rotationGizmoHotkeys;

		[SerializeField]
		private ObjectTransformGizmoSettings _objectRotationGizmoSettings;

		[SerializeField]
		private ScaleGizmoSettings3D _scaleGizmoSettings3D;

		[SerializeField]
		private ScaleGizmoLookAndFeel3D _scaleGizmoLookAndFeel3D;

		[SerializeField]
		private ScaleGizmoHotkeys _scaleGizmoHotkeys;

		[SerializeField]
		private ObjectTransformGizmoSettings _objectScaleGizmoSettings;

		[SerializeField]
		private UniversalGizmoSettings2D _universalGizmoSettings2D;

		[SerializeField]
		private UniversalGizmoSettings3D _universalGizmoSettings3D;

		[SerializeField]
		private UniversalGizmoLookAndFeel2D _universalGizmoLookAndFeel2D;

		[SerializeField]
		private UniversalGizmoLookAndFeel3D _universalGizmoLookAndFeel3D;

		[SerializeField]
		private UniversalGizmoHotkeys _universalGizmoHotkeys;

		[SerializeField]
		private ObjectTransformGizmoSettings _objectUniversalGizmoSettings;

		[SerializeField]
		private BoxGizmoSettings3D _boxScaleGizmoSettings3D;

		[SerializeField]
		private BoxGizmoLookAndFeel3D _boxScaleGizmoLookAndFeel3D;

		[SerializeField]
		private BoxGizmoHotkeys _boxScaleGizmoHotkeys;

		[SerializeField]
		private ObjectExtrudeGizmoLookAndFeel3D _extrudeGizmoLookAndFeel3D;

		[SerializeField]
		private ObjectExtrudeGizmoHotkeys _extrudeGizmoHotkeys;

		public bool AreGizmosVisible => false;

		public GameObject PivotObject => null;

		public Gizmo WorkGizmo => null;

		public ObjectSelectionGizmosHotkeys Hotkeys => null;

		public MoveGizmoSettings2D MoveGizmoSettings2D => null;

		public MoveGizmoSettings3D MoveGizmoSettings3D => null;

		public MoveGizmoLookAndFeel2D MoveGizmoLookAndFeel2D => null;

		public MoveGizmoLookAndFeel3D MoveGizmoLookAndFeel3D => null;

		public MoveGizmoHotkeys MoveGizmoHotkeys => null;

		public ObjectTransformGizmoSettings ObjectMoveGizmoSettings => null;

		public RotationGizmoSettings3D RotationGizmoSettings3D => null;

		public RotationGizmoLookAndFeel3D RotationGizmoLookAndFeel3D => null;

		public RotationGizmoHotkeys RotationGizmoHotkeys => null;

		public ObjectTransformGizmoSettings ObjectRotationGizmoSettings => null;

		public ScaleGizmoSettings3D ScaleGizmoSettings3D => null;

		public ScaleGizmoLookAndFeel3D ScaleGizmoLookAndFeel3D => null;

		public ScaleGizmoHotkeys ScaleGizmoHotkeys => null;

		public ObjectTransformGizmoSettings ObjectScaleGizmoSettings => null;

		public UniversalGizmoSettings2D UniversalGizmoSettings2D => null;

		public UniversalGizmoSettings3D UniversalGizmoSettings3D => null;

		public UniversalGizmoLookAndFeel2D UniversalGizmoLookAndFeel2D => null;

		public UniversalGizmoLookAndFeel3D UniversalGizmoLookAndFeel3D => null;

		public UniversalGizmoHotkeys UniversalGizmoHotkeys => null;

		public ObjectTransformGizmoSettings ObjectUniversalGizmoSettings => null;

		public BoxGizmoSettings3D BoxScaleGizmoSettings3D => null;

		public BoxGizmoLookAndFeel3D BoxScaleGizmoLookAndFeel3D => null;

		public BoxGizmoHotkeys BoxScaleGizmoHotkeys => null;

		public ObjectExtrudeGizmoLookAndFeel3D ExtrudeGizmoLookAndFeel3D => null;

		public ObjectExtrudeGizmoHotkeys ExtrudeGozmoHotkeys => null;

		public void SetTargetObjectCollection(IEnumerable<GameObject> targetObjectCollection)
		{
		}

		public void Initialize_SystemCall()
		{
		}

		public void SetGizmoUsable(int gizmoId, bool isUsable)
		{
		}

		public Gizmo GetGizmoById(int gizmoId)
		{
			return null;
		}

		public List<Gizmo> GetAllGizmos()
		{
			return null;
		}

		public int GetGizmoId(Gizmo gizmo)
		{
			return 0;
		}

		public ObjectTransformGizmo GetTransformGizmoById(int id)
		{
			return null;
		}

		public void SetTransformPivot(GizmoObjectTransformPivot transformPivot)
		{
		}

		public void SetTransformSpace(GizmoSpace transformSpace)
		{
		}

		public void SetWorkGizmo(int gizmoId)
		{
		}

		public void SetGizmosVisisble(bool visible)
		{
		}

		public void Update_SystemCall()
		{
		}

		private void OnObjectSelectionChanged(ObjectSelectionChangedEventArgs args)
		{
		}

		private void OnUndoRedo(IUndoRedoAction action)
		{
		}

		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}

		private void OnTargetObjectGroupUpdated()
		{
		}

		private void OnObjectSelectionManipSessionBegin(ObjectSelectionManipSession manipSession)
		{
		}

		private void OnObjectSelectionManipSessionEnd(ObjectSelectionManipSession manipSession)
		{
		}

		private void OnObjectSelectionRotated()
		{
		}

		private void OnObjectSelectionEnabled()
		{
		}

		private void OnObjectSelectionDisabled()
		{
		}

		private ObjectSelectionGizmo GetObjectSelectionGizmo(Gizmo gizmo)
		{
			return null;
		}

		private ObjectSelectionGizmo GetObjectSelectionGizmo(int id)
		{
			return null;
		}

		private bool IsGizmoRegistered(int gizmoId)
		{
			return false;
		}

		private bool IsGizmoRegistered(Gizmo gizmo)
		{
			return false;
		}

		private bool RegisterGizmo(int gizmoId, Gizmo gizmo)
		{
			return false;
		}
	}
}
