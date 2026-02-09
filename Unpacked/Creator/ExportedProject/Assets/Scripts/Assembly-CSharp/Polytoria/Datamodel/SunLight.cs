using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[RequireComponent(typeof(Light))]
	public class SunLight : DynamicInstance
	{
		private Light light;

		[SyncVar(hook = "OnBrightnessChanged")]
		private float brightness;

		[SyncVar(hook = "OnColorChanged")]
		private Color color;

		[SyncVar(hook = "OnShadowsChanged")]
		private bool shadows;

		public Action<float, float> _Mirror_SyncVarHookDelegate_brightness;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_color;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_shadows;

		[Archivable]
		[CreatorProperty]
		public float Brightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Archivable]
		[CreatorProperty]
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		[Archivable]
		[CreatorProperty]
		public bool Shadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Networkbrightness
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public Color Networkcolor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		public bool Networkshadows
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void OnBrightnessChanged(float oldValue, float newValue)
		{
		}

		private void OnColorChanged(Color oldValue, Color newValue)
		{
		}

		private void OnShadowsChanged(bool oldValue, bool newValue)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
