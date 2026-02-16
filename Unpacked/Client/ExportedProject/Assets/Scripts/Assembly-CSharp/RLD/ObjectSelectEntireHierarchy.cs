using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class ObjectSelectEntireHierarchy : Singleton<ObjectSelectEntireHierarchy>
	{
		private bool _isActive;

		private bool _ignoreObjectGroups;

		public bool IgnoreObjectGroups
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void SetActive(bool isActive)
		{
		}

		private void OnPreSelectCustomize(ObjectPreSelectCustomizeInfo customizeInfo, List<GameObject> toBeSelected)
		{
		}

		private void OnPreDeselectCustomize(ObjectPreDeselectCustomizeInfo customizeInfo, List<GameObject> toBeDeselected)
		{
		}

		private Transform GetFurthestParentNotGroup(GameObject gameObj)
		{
			return null;
		}
	}
}
