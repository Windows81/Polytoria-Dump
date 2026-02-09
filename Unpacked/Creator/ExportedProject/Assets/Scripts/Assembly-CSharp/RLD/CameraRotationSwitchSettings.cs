using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class CameraRotationSwitchSettings : Settings
	{
		private static readonly float _minConstantDuration;

		[SerializeField]
		private CameraRotationSwitchMode _switchMode;

		[SerializeField]
		private float _constantSwitchDurationInSeconds;

		[SerializeField]
		private float _smoothValue;

		public CameraRotationSwitchMode SwitchMode
		{
			get
			{
				return default(CameraRotationSwitchMode);
			}
			set
			{
			}
		}

		public float ConstantSwitchDurationInSeconds
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SmoothValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
