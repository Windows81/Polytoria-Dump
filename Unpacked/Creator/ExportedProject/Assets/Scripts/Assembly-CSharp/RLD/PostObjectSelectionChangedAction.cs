namespace RLD
{
	public class PostObjectSelectionChangedAction : IUndoRedoAction
	{
		private ObjectSelectionSnapshot _preChangeSnapshot;

		private ObjectSelectionSnapshot _postChangeSnapshot;

		public ObjectSelectionSnapshot PreChangeSnapshot => null;

		public ObjectSelectionSnapshot PostChangeSnapshot => null;

		public PostObjectSelectionChangedAction(ObjectSelectionSnapshot preChangeSnapshot, ObjectSelectionSnapshot postChangeSnapshot)
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
