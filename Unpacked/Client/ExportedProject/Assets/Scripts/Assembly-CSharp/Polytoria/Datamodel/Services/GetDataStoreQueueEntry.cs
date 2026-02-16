using System;

namespace Polytoria.Datamodel.Services
{
	public class GetDataStoreQueueEntry
	{
		public Datastore datastore;

		public Action<bool> callback;

		public GetDataStoreQueueEntry(Datastore datastore, Action<bool> callback)
		{
		}
	}
}
