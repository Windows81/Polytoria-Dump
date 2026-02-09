using UnityEngine;

namespace namudev
{
	public class PropertyGridSelector : MonoBehaviour
	{
		private static readonly Color highlight;

		[SerializeField]
		private GameObject propertyGrid;

		private GameObject selected;

		private Color color;

		private void Update()
		{
		}

		private bool IsCursorOverUi()
		{
			return false;
		}

		private void Select(GameObject gameObject)
		{
		}

		private void ClearSelection()
		{
		}
	}
}
