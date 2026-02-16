using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class ObjectPreDeselectCustomizeInfo
	{
		private List<GameObject> _toBeDeselected;

		private ObjectDeselectReason _deselectReason;

		public ObjectDeselectReason DeselectReason => default(ObjectDeselectReason);

		public int ToBeDeselectedCount => 0;

		public List<GameObject> ToBeDeselected => null;

		public ObjectPreDeselectCustomizeInfo(List<GameObject> toBeDeselected, ObjectDeselectReason deselectReason)
		{
		}

		public void DeselectThese(IEnumerable<GameObject> toBeDeselected)
		{
		}

		public void IgnoreThese(IEnumerable<GameObject> toBeIgnored)
		{
		}
	}
}
