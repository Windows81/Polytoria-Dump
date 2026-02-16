namespace RLD
{
	public class ObjectSelectEventArgs
	{
		private ObjectSelectReason _selectReason;

		public ObjectSelectReason SelectReason => default(ObjectSelectReason);

		public ObjectSelectEventArgs(ObjectSelectReason selectReason)
		{
		}
	}
}
