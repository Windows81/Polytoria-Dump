using System.Collections.Generic;
using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Services
{
	public class Datastore
	{
		private struct DatastoreEntry
		{
			public object value;

			public float timestamp;
		}

		public static readonly float CACHE_TIME;

		private string key;

		private bool loading;

		private Dictionary<string, DatastoreEntry> data;

		private ScriptService scriptService;

		public LuaEvent Loaded;

		public bool Loading => false;

		public string Key => null;

		public Datastore(string key)
		{
		}

		public void Deserialize(string jsonData)
		{
		}

		public void Get(string key, DynValue callback)
		{
		}

		public void Set(string key, DynValue value, DynValue callback = null)
		{
		}

		public void Remove(string key, DynValue callback = null)
		{
		}
	}
}
