using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class DynamicConvertSettings : Settings
	{
		private Rect _prefabFolderDropRect;

		[SerializeField]
		private GameObjectType _convertableObjectTypes;

		[SerializeField]
		private string _prefabFolder;

		[SerializeField]
		private bool _processPrefabSubfolders;

		public GameObjectType ConvertableObjectTypes
		{
			get
			{
				return default(GameObjectType);
			}
			set
			{
			}
		}

		public string PrefabFolder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ProcessPrefabSubfolders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Rect PrefabFolderDropRect => default(Rect);
	}
}
