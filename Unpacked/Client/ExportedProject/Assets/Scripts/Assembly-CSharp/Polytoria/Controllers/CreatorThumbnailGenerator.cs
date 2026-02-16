using System.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	public class CreatorThumbnailGenerator : MonoBehaviour
	{
		[SerializeField]
		private RawImage preview;

		[SerializeField]
		private int width;

		[SerializeField]
		private int height;

		[SerializeField]
		private float _padding;

		[SerializeField]
		private UnityEngine.Camera thumbnailCamera;

		private Dictionary<GameObject, int> oldLayers;

		public Texture2D GenerateThumbnail(Instance instance)
		{
			return null;
		}

		private void SetLayer(Instance i, int layer)
		{
		}

		public void PositionCamera(UnityEngine.Camera camera, Bounds bounds, float padding = 0f)
		{
		}

		private static void FindClosestPointsOnTwoLines(Ray line1, Ray line2, out Vector3 closestPointLine1, out Vector3 closestPointLine2)
		{
			closestPointLine1 = default(Vector3);
			closestPointLine2 = default(Vector3);
		}

		private static Ray GetPlanesIntersection(Plane p1, Plane p2)
		{
			return default(Ray);
		}

		private static bool IsOutermostPointInDirection(int pointIndex, Vector3 direction, Vector3[] boundingBoxPoints)
		{
			return false;
		}

		public void TestRender()
		{
		}
	}
}
