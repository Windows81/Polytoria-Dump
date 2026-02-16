using UnityEngine;

namespace RLD
{
	public static class ObjectSpawnUtil
	{
		public struct Config
		{
			public float ObjectSize;
		}

		private static Config _defaultConfig;

		public static Config DefaultConfig => default(Config);

		public static GameObject SpawnInFrontOfCamera(GameObject sourceObject, Camera camera, Config config)
		{
			return null;
		}
	}
}
