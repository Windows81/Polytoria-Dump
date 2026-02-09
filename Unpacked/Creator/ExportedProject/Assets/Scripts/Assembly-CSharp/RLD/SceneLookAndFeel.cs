using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class SceneLookAndFeel : Settings
	{
		[SerializeField]
		private bool _drawLightIcons;

		[SerializeField]
		private bool _drawParticleSystemIcons;

		[SerializeField]
		private bool _drawCameraIcons;

		[SerializeField]
		private float _lightIconAlpha;

		[SerializeField]
		private float _particleSystemIconAlpha;

		[SerializeField]
		private float _cameraIconAlpha;

		[SerializeField]
		private Texture2D _lightIcon;

		[SerializeField]
		private Texture2D _particleSystemIcon;

		[SerializeField]
		private Texture2D _cameraIcon;

		public bool DrawLightIcons
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DrawParticleSystemIcons
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DrawCameraIcons
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float LightIconAlpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ParticleSystemIconAlpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CameraIconAlpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Texture2D LightIcon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D ParticleSystemIcon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D CameraIcon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
