using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class ObjectPreSelectCustomizeInfo
	{
		private List<GameObject> _toBeSelected;

		private ObjectSelectReason _selectRason;

		public ObjectSelectReason SelectReason => default(ObjectSelectReason);

		public int ToBeSelectedCount => 0;

		public List<GameObject> ToBeSelected => null;

		public ObjectPreSelectCustomizeInfo(List<GameObject> toBeSelected, ObjectSelectReason selectReason)
		{
		}

		public void SelectThese(IEnumerable<GameObject> toBeSelected)
		{
		}

		public void IgnoreThese(IEnumerable<GameObject> toBeIgnored)
		{
		}
	}
}
