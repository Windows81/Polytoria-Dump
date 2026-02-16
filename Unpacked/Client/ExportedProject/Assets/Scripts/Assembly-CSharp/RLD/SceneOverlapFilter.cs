using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class SceneOverlapFilter
	{
		private List<GameObjectType> _allowedObjectTypes;

		private List<GameObject> _ignoreObjects;

		private int _layerMask;

		public List<GameObjectType> AllowedObjectTypes => null;

		public List<GameObject> IgnoreObjects => null;

		public int LayerMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void FilterOverlaps(List<GameObject> gameObjects)
		{
		}
	}
}
