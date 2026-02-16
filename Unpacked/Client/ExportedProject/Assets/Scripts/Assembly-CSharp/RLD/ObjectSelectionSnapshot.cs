using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class ObjectSelectionSnapshot
	{
		private List<GameObject> _snapshotObjects;

		private ObjectSelectionGizmosSnapshot _gizmosSnapshot;

		public int NumObjects => 0;

		public List<GameObject> SnapshotObjects => null;

		public ObjectSelectionGizmosSnapshot GizmosSnapshot => null;

		public ObjectSelectionSnapshot()
		{
		}

		public ObjectSelectionSnapshot(ObjectSelectionSnapshot copy)
		{
		}

		public void Snapshot()
		{
		}
	}
}
