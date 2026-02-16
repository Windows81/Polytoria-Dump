namespace RLD
{
	public class ObjectDeselectEventArgs
	{
		private ObjectDeselectReason _deselectReason;

		public ObjectDeselectReason DeselectReason => default(ObjectDeselectReason);

		public ObjectDeselectEventArgs(ObjectDeselectReason deselectReason)
		{
		}
	}
}
