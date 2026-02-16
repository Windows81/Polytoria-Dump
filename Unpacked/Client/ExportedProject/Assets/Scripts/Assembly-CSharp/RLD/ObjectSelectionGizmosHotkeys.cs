using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectSelectionGizmosHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _activateMoveGizmo;

		[SerializeField]
		private Hotkeys _activateRotationGizmo;

		[SerializeField]
		private Hotkeys _activateScaleGizmo;

		[SerializeField]
		private Hotkeys _activateBoxScaleGizmo;

		[SerializeField]
		private Hotkeys _activateUniversalGizmo;

		[SerializeField]
		private Hotkeys _activateExtrudeGizmo;

		[SerializeField]
		private Hotkeys _toggleTransformSpace;

		public Hotkeys ActivateMoveGizmo => null;

		public Hotkeys ActivateRotationGizmo => null;

		public Hotkeys ActivateScaleGizmo => null;

		public Hotkeys ActivateBoxScaleGizmo => null;

		public Hotkeys ActivateUniversalGizmo => null;

		public Hotkeys ActivateExtrudeGizmo => null;

		public Hotkeys ToggleTransformSpace => null;
	}
}
