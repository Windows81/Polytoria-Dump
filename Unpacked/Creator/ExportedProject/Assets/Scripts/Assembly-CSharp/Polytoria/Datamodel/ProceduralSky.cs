using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class ProceduralSky : SkyBase
	{
		[SyncVar(hook = "OnSunSizeChanged")]
		private float sunSize;

		[SyncVar(hook = "OnSunSizeConvergenceChanged")]
		private float sunSizeConvergence;

		[SyncVar(hook = "OnAtmosphereThicknessChanged")]
		private float atmosphereThickness;

		[SyncVar(hook = "OnSkyTintChanged")]
		private Color skyTint;

		[SyncVar(hook = "OnGroundColorChanged")]
		private Color groundColor;

		[SyncVar(hook = "OnExposureChanged")]
		private float exposure;

		public Action<float, float> _Mirror_SyncVarHookDelegate_sunSize;

		public Action<float, float> _Mirror_SyncVarHookDelegate_sunSizeConvergence;

		public Action<float, float> _Mirror_SyncVarHookDelegate_atmosphereThickness;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyTint;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_groundColor;

		public Action<float, float> _Mirror_SyncVarHookDelegate_exposure;

		[Archivable]
		[CreatorProperty]
		public float SunSize
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
		public float SunSizeConvergence
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
		public float AtmosphereThickness
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
		public Color SkyTint
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
		public Color GroundColor
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
		public float Exposure
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float NetworksunSize
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

		public float NetworksunSizeConvergence
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

		public float NetworkatmosphereThickness
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

		public Color NetworkskyTint
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

		public Color NetworkgroundColor
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

		public float Networkexposure
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

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void Apply()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		private void OnSunSizeChanged(float oldValue, float newValue)
		{
		}

		private void OnSunSizeConvergenceChanged(float oldValue, float newValue)
		{
		}

		private void OnAtmosphereThicknessChanged(float oldValue, float newValue)
		{
		}

		private void OnSkyTintChanged(Color oldValue, Color newValue)
		{
		}

		private void OnGroundColorChanged(Color oldValue, Color newValue)
		{
		}

		private void OnExposureChanged(float oldValue, float newValue)
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
