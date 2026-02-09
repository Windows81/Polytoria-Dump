using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class PrefabLibDbSettings
	{
		[SerializeField]
		private bool _spawnPrefabOnPreviewClick;

		public bool SpawnPrefabOnPreviewClick
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
