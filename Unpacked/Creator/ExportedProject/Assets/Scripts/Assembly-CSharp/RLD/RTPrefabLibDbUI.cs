using UnityEngine;

namespace RLD
{
	public class RTPrefabLibDbUI : MonoBehaviour
	{
		private RTActiveLibDropDown _activeLibDropDown;

		private RTPrefabScrollView _prefabScrollView;

		private RTHoveredPrefabNameLabel _hoveredPrefabNameLabel;

		private RTPrefabSearch _prefabSearch;

		public RTActiveLibDropDown ActiveLibDropDown => null;

		public RTPrefabScrollView PrefabScrollView => null;

		public RTHoveredPrefabNameLabel HoveredPrefabNameLabel => null;

		public RTPrefabSearch PrefabSearch => null;

		private void Awake()
		{
		}

		private void OnPrefabPreviewHoverEnter(RTPrefab prefab)
		{
		}

		private void OnPrefabPreviewHoverExit(RTPrefab prefab)
		{
		}

		private void OnPrefabSearchFieldValueChanged(string value)
		{
		}
	}
}
