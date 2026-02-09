using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class BoxGizmoSettings3D : Settings
	{
		[SerializeField]
		private float _xSnapStep;

		[SerializeField]
		private float _ySnapStep;

		[SerializeField]
		private float _zSnapStep;

		[SerializeField]
		private float _dragSensitivity;

		public float XSnapStep => 0f;

		public float YSnapStep => 0f;

		public float ZSnapStep => 0f;

		public float DragSensitivity => 0f;

		public void SetXSnapStep(float snapStep)
		{
		}

		public void SetYSnapStep(float snapStep)
		{
		}

		public void SetZSnapStep(float snapStep)
		{
		}

		public void SetDragSensitivity(float sensitivity)
		{
		}
	}
}
