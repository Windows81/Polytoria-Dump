using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace RLD
{
	public class RTPrefabScrollView : MonoBehaviour
	{
		public delegate void PrefabPreviewClickedHandler(RTPrefab prefab);

		public delegate void PrefabPreviewHoverEnterHandler(RTPrefab prefab);

		public delegate void PrefabPreviewHoverExitHandler(RTPrefab prefab);

		private ObjectPool _previewButtonPool;

		private GameObject _gridObject;

		private GridLayoutGroup _gridLayoutGroup;

		private List<RTPrefabPreviewButton> _activePreviewButtons;

		private List<string> _prefabSearchNames;

		private List<string> _prefabSearchMatches;

		public event PrefabPreviewClickedHandler PrefabPreviewClicked
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

		public event PrefabPreviewHoverEnterHandler PrefabPreviewHoverEnter
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

		public event PrefabPreviewHoverExitHandler PrefabPreviewHoverExit
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

		public void AddPrefabPreview(RTPrefab prefab)
		{
		}

		public void FilterPrefabsByName(string name)
		{
		}

		public void ClearPreviews()
		{
		}

		public void SyncWithLib(RTPrefabLib prefabLib)
		{
		}

		private void Awake()
		{
		}

		private void prefabNames(List<string> names)
		{
		}

		private void OnPreviewButtonClicked()
		{
		}

		private void OnPrefabPreviewHoverEnter(RTPrefab prefab)
		{
		}

		private void OnPrefabPreviewHoverExit(RTPrefab prefab)
		{
		}
	}
}
