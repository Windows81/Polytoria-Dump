using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectGridSnapHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _beginGridSnap;

		public Hotkeys BeginGridSnap => null;
	}
}
