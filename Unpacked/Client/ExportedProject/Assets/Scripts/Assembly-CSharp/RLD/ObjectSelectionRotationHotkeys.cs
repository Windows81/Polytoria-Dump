using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectSelectionRotationHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _rotateAroundX;

		[SerializeField]
		private Hotkeys _rotateAroundY;

		[SerializeField]
		private Hotkeys _rotateAroundZ;

		[SerializeField]
		private Hotkeys _setRotationToIdentity;

		public Hotkeys RotateAroundX => null;

		public Hotkeys RotateAroundY => null;

		public Hotkeys RotateAroundZ => null;

		public Hotkeys SetRotationToIdentity => null;
	}
}
