using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class RotationGizmoHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _enableSnapping;

		public Hotkeys EnableSnapping => null;
	}
}
