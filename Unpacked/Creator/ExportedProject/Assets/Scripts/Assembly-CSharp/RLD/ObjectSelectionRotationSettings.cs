using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectSelectionRotationSettings : Settings
	{
		[SerializeField]
		private ObjectRotationPivot _rotationPivot;

		[SerializeField]
		private ObjectKeyRotationSettings _keyRotationSettings;

		public ObjectRotationPivot RotationPivot
		{
			get
			{
				return default(ObjectRotationPivot);
			}
			set
			{
			}
		}

		public ObjectKeyRotationSettings KeyRotationSettings => null;
	}
}
