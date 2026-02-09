using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class ObjectSelectionDuplicationResult
	{
		private List<GameObject> _duplicateParents;

		public List<GameObject> DuplicateParents => null;

		public int NumDuplicateParents => 0;

		public ObjectSelectionDuplicationResult(List<GameObject> duplicatedParents)
		{
		}

		public GameObject GetParentByIndex(int index)
		{
			return null;
		}
	}
}
