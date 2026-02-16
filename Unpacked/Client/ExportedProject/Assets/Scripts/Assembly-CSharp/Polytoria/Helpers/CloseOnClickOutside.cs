using UnityEngine;

namespace Polytoria.Helpers
{
	public class CloseOnClickOutside : MonoBehaviour
	{
		private bool close;

		private void Update()
		{
		}

		private bool ClickingSelfOrChild()
		{
			return false;
		}
	}
}
