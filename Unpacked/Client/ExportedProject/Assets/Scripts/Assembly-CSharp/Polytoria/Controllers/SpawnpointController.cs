using System.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	public static class SpawnpointController
	{
		private static List<Part> spawns;

		public static Vector3 GetDefaultSpawnPosition()
		{
			return default(Vector3);
		}

		public static void AddSpawn(Part p)
		{
		}

		public static void RemoveSpawn(Part p)
		{
		}

		public static Transform GetSpawnPosition()
		{
			return null;
		}
	}
}
