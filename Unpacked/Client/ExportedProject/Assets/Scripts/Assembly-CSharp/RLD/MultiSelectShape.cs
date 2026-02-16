using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class MultiSelectShape
	{
		private Rect _enclosingRect;

		private bool _isVisible;

		private int _minSize;

		public Rect EnclosingRect => default(Rect);

		public bool IsVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int MinSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void SetEnclosingRectTopLeftPoint(Vector2 topLeftPoint)
		{
		}

		public void SetEnclosingRectBottomRightPoint(Vector2 bottomRightPoint)
		{
		}

		public void GetOverlappedObjects(List<GameObject> gameObjects, Camera camera, ObjectBounds.QueryConfig boundsQConfig, MultiSelectOverlapMode overlapMode, List<GameObject> overlappedObjects)
		{
		}

		public bool OverlapsObject(GameObject gameObject, Camera camera, ObjectBounds.QueryConfig boundsQConfig, MultiSelectOverlapMode overlapMode)
		{
			return false;
		}

		public void Render(Color fillColor, Color borderColor, Camera camera)
		{
		}

		private bool IsBigEnoughForOverlap()
		{
			return false;
		}
	}
}
