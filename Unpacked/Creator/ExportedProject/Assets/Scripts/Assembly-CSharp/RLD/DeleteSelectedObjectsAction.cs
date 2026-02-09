using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class DeleteSelectedObjectsAction : IUndoRedoAction
	{
		private List<GameObject> _selectedObjects;

		private List<GameObject> _deletedObjects;

		private ObjectSelectionSnapshot _preDeleteSnapshot;

		private ObjectSelectionSnapshot _postDeleteSnapshot;

		private bool _canDestroyObjects;

		public ObjectSelectionSnapshot PreDeleteSnapshot => null;

		public ObjectSelectionSnapshot PostDeleteSnapshot => null;

		public DeleteSelectedObjectsAction(List<GameObject> selectedObjects, ObjectSelectionSnapshot preDeleteSnapshot)
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
