using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class CameraSettings : Settings
	{
		[SerializeField]
		private bool _canProcessInput;

		public bool CanProcessInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
