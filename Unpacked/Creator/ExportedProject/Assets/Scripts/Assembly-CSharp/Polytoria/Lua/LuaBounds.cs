using System;
using UnityEngine;

namespace Polytoria.Lua
{
	public class LuaBounds
	{
		public static Bounds New()
		{
			return default(Bounds);
		}

		public static Bounds New(Vector3 center, Vector3 size)
		{
			return default(Bounds);
		}

		public static Vector3 ClosestPoint(Bounds bounds, Vector3 point)
		{
			return default(Vector3);
		}

		public static bool Contains(Bounds bounds, Vector3 point)
		{
			return false;
		}

		public static void Encapsulate(Bounds bounds, Vector3 point)
		{
		}

		public static void Encapsulate(Bounds bounds, Bounds other)
		{
		}

		public static bool Intersects(Bounds bounds, Bounds other)
		{
			return false;
		}

		public static void SetMinMax(Bounds bounds, Vector3 min, Vector3 max)
		{
		}

		public static float SqrDistance(Bounds bounds, Vector3 point)
		{
			return 0f;
		}

		public static Tuple<bool, float> IntersectRay(Bounds bounds, Vector3 origin, Vector3 direction)
		{
			return null;
		}
	}
}
