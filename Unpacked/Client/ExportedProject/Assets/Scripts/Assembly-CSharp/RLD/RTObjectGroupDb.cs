using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class RTObjectGroupDb : MonoSingleton<RTObjectGroupDb>
	{
		[SerializeField]
		private List<GameObject> _objectGroups;

		public int NumGroups => 0;

		public void Add(GameObject gameObject)
		{
		}

		public void Remove(GameObject gameObject)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Clear()
		{
		}

		public bool IsGroup(GameObject gameObject)
		{
			return false;
		}

		public GameObject GetGroupByIndex(int index)
		{
			return null;
		}

		public GameObject GetGroupByName(string name)
		{
			return null;
		}

		public List<GameObject> GetAll()
		{
			return null;
		}

		public void RemoveNullRefs()
		{
		}
	}
}
