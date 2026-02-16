using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class RTPrefabLib
	{
		[SerializeField]
		private string _name;

		[SerializeField]
		private List<RTPrefab> _prefabs;

		public int NumPrefabs => 0;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event PrefabCreatedInLibHandler PrefabCreated
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

		public event PrefabRemovedFromLibHandler PrefabRemoved
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

		public event PrefabLibClearedHandler Cleared
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

		public RTPrefab CreatePrefab(GameObject unityPrefab, Texture2D prefabPreview)
		{
			return null;
		}

		public RTPrefab CreatePrefabFromSceneObject(GameObject sceneObject)
		{
			return null;
		}

		public List<RTPrefab> CreatePrefabsFromSceneObjects(List<GameObject> sceneObjects)
		{
			return null;
		}

		public void Remove(int prefabIndex)
		{
		}

		public void Remove(RTPrefab prefab)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(GameObject unityPrefab)
		{
			return false;
		}

		public bool Contains(RTPrefab prefab)
		{
			return false;
		}

		public int GetPrefabIndex(RTPrefab prefab)
		{
			return 0;
		}

		public RTPrefab GetPrefab(int prefabIndex)
		{
			return null;
		}

		public RTPrefab GetPrefab(GameObject unityPrefab)
		{
			return null;
		}
	}
}
