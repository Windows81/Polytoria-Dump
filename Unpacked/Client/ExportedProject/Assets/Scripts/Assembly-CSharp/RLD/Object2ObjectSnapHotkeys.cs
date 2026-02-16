using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class Object2ObjectSnapHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _toggleSnap;

		[SerializeField]
		private Hotkeys _toggleSitBelowSurface;

		[SerializeField]
		private Hotkeys _enableMoreControl;

		[SerializeField]
		private Hotkeys _enableFlexiSnap;

		public Hotkeys ToggleSnap => null;

		public Hotkeys ToggleSitBelowSurface => null;

		public Hotkeys EnableMoreControl => null;

		public Hotkeys EnableFlexiSnap => null;
	}
}
