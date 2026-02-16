using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectExtrudeGizmoHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _enableOverlapTest;

		public Hotkeys EnableOverlapTest => null;
	}
}
