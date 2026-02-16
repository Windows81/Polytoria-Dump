using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class SceneGridHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _gridUp;

		[SerializeField]
		private Hotkeys _gridDown;

		private Hotkeys _snapToCursorPickPoint;

		public Hotkeys GridUp => null;

		public Hotkeys GridDown => null;

		public Hotkeys SnapToCursorPickPoint => null;
	}
}
