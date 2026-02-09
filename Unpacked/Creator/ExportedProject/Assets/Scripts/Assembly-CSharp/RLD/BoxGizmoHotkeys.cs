using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class BoxGizmoHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _enableSnapping;

		[SerializeField]
		private Hotkeys _enableCenterPivot;

		public Hotkeys EnableSnapping => null;

		public Hotkeys EnableCenterPivot => null;
	}
}
