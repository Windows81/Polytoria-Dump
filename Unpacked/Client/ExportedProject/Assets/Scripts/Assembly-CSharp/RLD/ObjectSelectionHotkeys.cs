using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectSelectionHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _appendToSelection;

		[SerializeField]
		private Hotkeys _multiDeselect;

		[SerializeField]
		private Hotkeys _deleteSelected;

		[SerializeField]
		private Hotkeys _focusCameraOnSelection;

		[SerializeField]
		private Hotkeys _duplicateSelection;

		public Hotkeys AppendToSelection => null;

		public Hotkeys MultiDeselect => null;

		public Hotkeys DeleteSelected => null;

		public Hotkeys FocusCameraOnSelection => null;

		public Hotkeys DuplicateSelection => null;
	}
}
