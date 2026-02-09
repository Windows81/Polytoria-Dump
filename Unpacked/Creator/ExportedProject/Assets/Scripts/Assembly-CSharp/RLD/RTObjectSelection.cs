using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class RTObjectSelection : MonoSingleton<RTObjectSelection>
	{
		[Flags]
		private enum SelectRestrictFlags
		{
			None = 0,
			ObjectLayer = 1,
			ObjectType = 2,
			Object = 4,
			SelectionListener = 8,
			All = 0xF
		}

		private struct CyclicalClickSelectInfo
		{
			public int LastSelectedIndex;

			public GameObject LastPickedObject;
		}

		private static readonly int _objectPickDeviceBtnIndex;

		private List<GameObject> _visibleObjectBuffer;

		private List<GameObject> _overlappedObjectBuffer;

		private List<GameObjectRayHit> _objectHitBuffer;

		[SerializeField]
		private bool _isEnabled;

		private List<Camera> _renderIgnoreCameras;

		private List<GameObject> _selectedObjects;

		private MultiSelectShape _multiSelectShape;

		private ObjectSelectionSnapshot _multiSelectPreChangeSnapshot;

		private bool _wasSelectionChangedViaMultiSelectShape;

		private bool _willBeDeleted;

		private bool _doingPreSelectCustomize;

		private bool _doingPreDeselectCustomize;

		private bool _firingSelectionChanged;

		private ObjectSelectionManipSession _activeManipSession;

		private CyclicalClickSelectInfo _cyclicalClickSelectInfo;

		[SerializeField]
		private ObjectSelectionHotkeys _hotkeys;

		[SerializeField]
		private ObjectSelectionSettings _settings;

		[SerializeField]
		private ObjectSelectionLookAndFeel _lookAndFeel;

		[SerializeField]
		private ObjectSelectionRotationSettings _rotationSettings;

		[SerializeField]
		private ObjectSelectionRotationHotkeys _rotationHotkeys;

		private DeviceObjectGrabSession _grabSession;

		[SerializeField]
		private ObjectGrabSettings _grabSettings;

		[SerializeField]
		private ObjectGrabLookAndFeel _grabLookAndFeel;

		[SerializeField]
		private ObjectGrabHotkeys _grabHotkeys;

		private ObjectGridSnapSession _gridSnapSession;

		[SerializeField]
		private ObjectGridSnapLookAndFeel _gridSnapLookAndFeel;

		[SerializeField]
		private ObjectGridSnapHotkeys _gridSnapHotkeys;

		private Object2ObjectSnapSession _object2ObjectSnapSession;

		[SerializeField]
		private Object2ObjectSnapSettings _object2ObjectSnapSettings;

		[SerializeField]
		private Object2ObjectSnapHotkeys _object2ObjectSnapHotkeys;

		[SerializeField]
		private EditorToolbar _settingsToolbar;

		public bool IsEnabled => false;

		public bool IsMultiSelectShapeVisible => false;

		public int NumSelectedObjects => 0;

		public ObjectSelectionHotkeys Hotkeys => null;

		public ObjectSelectionSettings Settings => null;

		public ObjectSelectionLookAndFeel LookAndFeel => null;

		public ObjectSelectionRotationSettings RotationSettings => null;

		public ObjectSelectionRotationHotkeys RotationHotkeys => null;

		public ObjectGrabSettings GrabSettings => null;

		public ObjectGrabHotkeys GrabHotkeys => null;

		public ObjectGrabLookAndFeel GrabLookAndFeel => null;

		public ObjectGridSnapLookAndFeel GridSnapLookAndFeel => null;

		public ObjectGridSnapHotkeys GridSnapHotkeys => null;

		public Object2ObjectSnapSettings Object2ObjectSnapSettings => null;

		public Object2ObjectSnapHotkeys Object2ObjectSnapHotkeys => null;

		public bool IsManipSessionActive => false;

		public ObjectSelectionManipSession ActiveManipSession => default(ObjectSelectionManipSession);

		public bool IsGrabSessionActive => false;

		public bool IsGridSnapSessionActive => false;

		public bool IsObject2ObjectSnapSessionActive => false;

		public List<GameObject> SelectedObjects => null;

		public event ObjectSelectionManipSessionBeginHandler ManipSessionBegin
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

		public event ObjectSelectionManipSessionEndHandler ManipSessionEnd
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

		public event ObjectSelectionCanClickSelectDeselectHandler CanClickSelectDeselect
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

		public event ObjectSelectionCanMultiSelectDeselectHandler CanMultiSelectDeselect
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

		public event ObjectSelectionChangedHandler Changed
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

		public event ObjectSelectionWillBeDeletedHandler WillBeDeleted
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

		public event ObjectSelectionDeletedHandler Deleted
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

		public event ObjectSelectionWillBeDuplicatedHandler WillBeDuplicated
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

		public event ObjectSelectionDuplicatedHandler Duplicated
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

		public event ObjectSelectionRotatedHandler Rotated
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

		public event ObjectSelectionPreSelectCustomizeHandler PreSelectCustomize
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

		public event ObjectSelectionPreDeselectCustomizeHandler PreDeselectCustomize
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

		public event ObjectSelectionEnabled Enabled
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

		public event ObjectSelectionDisabled Disabled
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

		public void Initialize_SystemCall()
		{
		}

		public void AttachGizmoController(IObjectCollectionGizmoController gizmoController)
		{
		}

		public bool IsRenderIgnoreCamera(Camera camera)
		{
			return false;
		}

		public void AddRenderIgnoreCamera(Camera camera)
		{
		}

		public void RemoveRenderIgnoreCamera(Camera camera)
		{
		}

		public void SetEnabled(bool isEnabled)
		{
		}

		public void SetRotation(Quaternion rotation)
		{
		}

		public void Rotate(Axis axis, float rotationAngle, ObjectRotationPivot rotationPivot)
		{
		}

		public void AppendObjects(List<GameObject> gameObjects, bool allowUndoRedo)
		{
		}

		public void RemoveObjects(List<GameObject> gameObjects, bool allowUndoRedo)
		{
		}

		public void SetSelectedObjects(List<GameObject> gameObjects, bool allowUndoRedo)
		{
		}

		public void ClearSelection(bool allowUndoRedo)
		{
		}

		public void Delete()
		{
		}

		public void ForceDelete()
		{
		}

		public bool CanBeDeleted()
		{
			return false;
		}

		public bool CanBeDuplicated()
		{
			return false;
		}

		public bool CanBeModifiedByAPI()
		{
			return false;
		}

		public ObjectSelectionDuplicationResult Duplicate()
		{
			return null;
		}

		public bool IsSelectionExactMatch(List<GameObject> gameObjectsToMatch)
		{
			return false;
		}

		public bool IsObjectSelected(GameObject gameObject)
		{
			return false;
		}

		public AABB GetWorldAABB()
		{
			return default(AABB);
		}

		public void Update_SystemCall()
		{
		}

		public void Render_SystemCall(Camera renderCamera)
		{
		}

		private void OnInputDevicePickButtonDown()
		{
		}

		private void OnInputDevicePickButtonUp()
		{
		}

		private void OnInputDeviceWasMoved()
		{
		}

		private void PerformMultiSelect()
		{
		}

		private void PerformClickSelect()
		{
		}

		private ObjectPreSelectCustomizeInfo DoPreSelectCustomize(List<GameObject> toBeSelected, ObjectSelectReason selectReason)
		{
			return null;
		}

		private List<GameObject> DoPreDeselectCustomize(List<GameObject> toBeDeselected, ObjectDeselectReason deselectReason)
		{
			return null;
		}

		private List<GameObject> FilterByRestrictions(IEnumerable<GameObject> gameObjects, SelectRestrictFlags restrictFlags, ObjectSelectReason selectReason)
		{
			return null;
		}

		private List<GameObjectRayHit> FilterByRestrictions(List<GameObjectRayHit> objectHits, SelectRestrictFlags restrictFlags)
		{
			return null;
		}

		private bool CanSelectObject(GameObject gameObject, SelectRestrictFlags restrictFlags, ObjectSelectReason selectReason)
		{
			return false;
		}

		private void SelectObject(GameObject gameObject, ObjectSelectReason selectReason)
		{
		}

		private void DeselectObject(GameObject gameObject, ObjectDeselectReason deselectReason)
		{
		}

		private void ClearSelection(ObjectDeselectReason deselectReason)
		{
		}

		private void OnSelectionChanged(ObjectSelectionChangedEventArgs args)
		{
		}

		private void RemoveNullAndInactiveObjectRefs()
		{
		}

		private void OnUndoEnd(IUndoRedoAction action)
		{
		}

		private void OnRedoEnd(IUndoRedoAction action)
		{
		}

		private void HandleUndoRedo(ObjectSelectionSnapshot undoRedoSnapshot, bool isUndo)
		{
		}

		private void OnGrabSessionBegin()
		{
		}

		private void OnGrabSessionEnd()
		{
		}

		private void OnGridSnapSessionBegin()
		{
		}

		private void OnGridSnapSessionEnd()
		{
		}

		private void OnObject2ObjectSnapSessionBegin()
		{
		}

		private void OnObject2ObjectSnapSessionEnd()
		{
		}
	}
}
