using System.Collections.Generic;
using Mirror;

namespace Polytoria.Datamodel
{
	public static class NetMessageReadWriteFunctions
	{
		private static void WriteDictionary<T>(this NetworkWriter writer, Dictionary<string, T> dict)
		{
		}

		public static Dictionary<string, T> ReadDictionary<T>(NetworkReader reader)
		{
			return null;
		}

		public static void WriteNetMessage(this NetworkWriter writer, NetMessage value)
		{
		}

		public static NetMessage ReadNetMessage(this NetworkReader reader)
		{
			return null;
		}
	}
}
