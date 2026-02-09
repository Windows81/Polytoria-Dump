using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectSelectionSettings : Settings
	{
		[SerializeField]
		private MultiSelectOverlapMode _multiSelectOverlapMode;

		[SerializeField]
		private GameObjectType _selectableObjectTypes;

		[SerializeField]
		private int _selectableLayers;

		[SerializeField]
		private int _duplicatableLayers;

		[SerializeField]
		private int _deletableLayers;

		private HashSet<GameObject> _nonSelectableObjects;

		private HashSet<Camera> _nonSelectableCameras;

		[SerializeField]
		private bool _canClickSelect;

		[SerializeField]
		private bool _enableCyclicalClickSelect;

		[SerializeField]
		private bool _canMultiSelect;

		[SerializeField]
		private int _minMultiSelectSize;

		public MultiSelectOverlapMode MultiSelectOverlapMode
		{
			get
			{
				return default(MultiSelectOverlapMode);
			}
			set
			{
			}
		}

		public bool CanClickSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EnableCyclicalClickSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CanMultiSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int SelectableLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DuplicatableLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DeletableLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MinMultiSelectSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsCameraSelectable(Camera camera)
		{
			return false;
		}

		public void SetCameraSelectable(Camera camera, bool isSelectable)
		{
		}

		public void SetCameraCollectionSelectable(List<Camera> cameraCollection, bool areSelectable)
		{
		}

		public bool IsObjectTypeSelectable(GameObjectType gameObjectType)
		{
			return false;
		}

		public void SetObjectTypeSelectable(GameObjectType gameObjectType, bool isSelectable)
		{
		}

		public bool IsObjectLayerSelectable(int objectLayer)
		{
			return false;
		}

		public void SetObjectLayerSelectable(int objectLayer, bool isSelectable)
		{
		}

		public bool IsObjectSelectable(GameObject gameObject)
		{
			return false;
		}

		public void SetObjectSelectable(GameObject gameObject, bool isSelectable)
		{
		}

		public void SetObjectCollectionSelectable(List<GameObject> gameObjectCollection, bool areSelectable)
		{
		}

		public void RemoveNullObjectRefs()
		{
		}

		public bool IsObjectLayerDuplicatable(int objectLayer)
		{
			return false;
		}

		public void SetObjectLayerDuplicatable(int objectLayer, bool isDuplicatable)
		{
		}

		public bool IsObjectLayerDeletable(int objectLayer)
		{
			return false;
		}
	}
}
