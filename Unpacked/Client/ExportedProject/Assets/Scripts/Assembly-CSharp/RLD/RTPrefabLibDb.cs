using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RLD
{
	[Serializable]
	[ExecuteInEditMode]
	public class RTPrefabLibDb : MonoSingleton<RTPrefabLibDb>
	{
		[SerializeField]
		private string _newLibName;

		[SerializeField]
		private Vector2 _prefabScrollPos;

		[SerializeField]
		private int _numPrefabsPerRow;

		[NonSerialized]
		private EditorPrefabPreviewGen _editorPrefabPreviewGen;

		[SerializeField]
		private PrefabLibDbSettings _settings;

		[SerializeField]
		private RTPrefabLibDbUI _runtimeUI;

		[SerializeField]
		private PrefabPreviewLookAndFeel _prefabPreviewLookAndFeel;

		[SerializeField]
		private int _activeLibIndex;

		[SerializeField]
		private List<RTPrefabLib> _libs;

		public int NumLibs => 0;

		public int ActiveLibIndex => 0;

		public RTPrefabLib ActiveLib => null;

		public PrefabPreviewLookAndFeel PrefabPreviewLookAndFeel => null;

		public RTPrefabLibDbUI RuntimeUI => null;

		public bool HasRuntimeUI => false;

		public PrefabLibDbSettings Settings => null;

		public EditorPrefabPreviewGen EditorPrefabPreviewGen => null;

		public event PrefabLibDbPrefabSpawnedHander PrefabSpawned
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

		public RTPrefabLib CreateLib(string libName)
		{
			return null;
		}

		public void SortLibsByName()
		{
		}

		public bool SetLibName(RTPrefabLib lib, string newLibName)
		{
			return false;
		}

		public void SetActiveLib(int libIndex)
		{
		}

		public void SetActiveLib(RTPrefabLib lib)
		{
		}

		public void SetActiveLib(string libName)
		{
		}

		public void Clear()
		{
		}

		public void Remove(int libIndex)
		{
		}

		public void Remove(string libName)
		{
		}

		public void Remove(RTPrefabLib lib)
		{
		}

		public void Remove(List<RTPrefabLib> libs)
		{
		}

		public List<RTPrefabLib> GetEmptyLibs()
		{
			return null;
		}

		public void RemoveEmptyLibs()
		{
		}

		public bool Contains(string libName)
		{
			return false;
		}

		public bool Contains(RTPrefabLib lib)
		{
			return false;
		}

		public List<string> GetAllLibNames()
		{
			return null;
		}

		public int GetLibIndex(string libName)
		{
			return 0;
		}

		public int GetLibIndex(RTPrefabLib lib)
		{
			return 0;
		}

		public RTPrefabLib GetLib(int libIndex)
		{
			return null;
		}

		public RTPrefabLib GetLib(string libName)
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnActiveLibDropDownChanged()
		{
		}

		private void OnPrefabCreatedInLib(RTPrefabLib prefabLib, RTPrefab prefab)
		{
		}

		private void OnPrefabRemovedFromLib(RTPrefabLib prefabLib, RTPrefab prefab)
		{
		}

		private void OnPrefabLibCleared(RTPrefabLib prefabLib)
		{
		}

		private void OnPrefabPreviewButtonClicked(RTPrefab prefab)
		{
		}
	}
}
