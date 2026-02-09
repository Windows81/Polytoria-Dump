using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectGrabHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _toggleGrab;

		[SerializeField]
		private Hotkeys _enableRotation;

		[SerializeField]
		private Hotkeys _enableRotationAroundAnchor;

		[SerializeField]
		private Hotkeys _enableScaling;

		[SerializeField]
		private Hotkeys _enableOffsetFromSurface;

		[SerializeField]
		private Hotkeys _enableAnchorAdjust;

		[SerializeField]
		private Hotkeys _enableOffsetFromAnchor;

		[SerializeField]
		private Hotkeys _nextAlignmentAxis;

		public Hotkeys ToggleGrab => null;

		public Hotkeys EnableRotation => null;

		public Hotkeys EnableRotationAroundAnchor => null;

		public Hotkeys EnableScaling => null;

		public Hotkeys EnableOffsetFromSurface => null;

		public Hotkeys EnableAnchorAdjust => null;

		public Hotkeys EnableOffsetFromAnchor => null;

		public Hotkeys NextAlignmentAxis => null;

		private void EstablishPotentialOverlaps()
		{
		}
	}
}
