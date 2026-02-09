using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class ObjectSelectionChangedEventArgs
	{
		private ObjectSelectReason _selectReason;

		private List<GameObject> _objectsWhichWereSelected;

		private ObjectDeselectReason _deselectReason;

		private List<GameObject> _objectsWhichWereDeselected;

		private ObjectSelectionSnapshot _undoRedoSnapshot;

		public ObjectSelectReason SelectReason => default(ObjectSelectReason);

		public int NumObjectsSelected => 0;

		public List<GameObject> ObjectsWhichWereSelected => null;

		public ObjectDeselectReason DeselectReason => default(ObjectDeselectReason);

		public int NumObjectsDeselected => 0;

		public List<GameObject> ObjectsWhichWereDeselected => null;

		public ObjectSelectionSnapshot UndoRedoSnapshot => null;

		public ObjectSelectionChangedEventArgs(ObjectSelectReason selectReason, List<GameObject> objectsWhichWereSelected, ObjectDeselectReason deselectReason, List<GameObject> objectsWhichWereDeselected, ObjectSelectionSnapshot undoRedoSnapshot = null)
		{
		}
	}
}
