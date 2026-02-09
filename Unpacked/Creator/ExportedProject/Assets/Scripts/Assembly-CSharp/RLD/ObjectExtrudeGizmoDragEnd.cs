using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class ObjectExtrudeGizmoDragEnd : IUndoRedoAction
	{
		private bool _wasExecuted;

		private bool _destroyClones;

		private List<GameObject> _targetParents;

		private List<LocalTransformSnapshot> _undoTargetSnapshots;

		private List<LocalTransformSnapshot> _redoTargetSnapshots;

		private List<GameObject> _extrudeClones;

		public int NumTargets => 0;

		public void SetTargetParents(IEnumerable<GameObject> targetParents)
		{
		}

		public void TakeUndoTargetSnapshots()
		{
		}

		public void TakeRedoTargetSnapshots()
		{
		}

		public void AddExtrudeClones(List<GameObject> extrudeClones)
		{
		}

		public void AddExtrudeClone(GameObject extrudeClone)
		{
		}

		public void Execute()
		{
		}

		public void Undo()
		{
		}

		public void Redo()
		{
		}

		public void OnRemovedFromUndoRedoStack()
		{
		}
	}
}
