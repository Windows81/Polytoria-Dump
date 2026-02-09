using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class GradientSky : SkyBase
	{
		[SyncVar(hook = "OnSunDiscColorChanged")]
		private Color sunDiscColor;

		[SyncVar(hook = "OnSunDiscMultiplierChanged")]
		private float sunDiscMultiplier;

		[SyncVar(hook = "OnSunDiscExponentChanged")]
		private float sunDiscExponent;

		[SyncVar(hook = "OnSunHaloColorChanged")]
		private Color sunHaloColor;

		[SyncVar(hook = "OnSunHaloExponentChanged")]
		private float sunHaloExponent;

		[SyncVar(hook = "OnSunHaloContributionChanged")]
		private float sunHaloContribution;

		[SyncVar(hook = "OnHorizonLineColorChanged")]
		private Color horizonLineColor;

		[SyncVar(hook = "OnHorizonLineExponentChanged")]
		private float horizonLineExponent;

		[SyncVar(hook = "OnHorizonLineContributionChanged")]
		private float horizonLineContribution;

		[SyncVar(hook = "OnSkyGradientTopChanged")]
		private Color skyGradientTop;

		[SyncVar(hook = "OnSkyGradientBottomChanged")]
		private Color skyGradientBottom;

		[SyncVar(hook = "OnSkyGradientExponentChanged")]
		private float skyGradientExponent;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_sunDiscColor;

		public Action<float, float> _Mirror_SyncVarHookDelegate_sunDiscMultiplier;

		public Action<float, float> _Mirror_SyncVarHookDelegate_sunDiscExponent;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_sunHaloColor;

		public Action<float, float> _Mirror_SyncVarHookDelegate_sunHaloExponent;

		public Action<float, float> _Mirror_SyncVarHookDelegate_sunHaloContribution;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_horizonLineColor;

		public Action<float, float> _Mirror_SyncVarHookDelegate_horizonLineExponent;

		public Action<float, float> _Mirror_SyncVarHookDelegate_horizonLineContribution;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyGradientTop;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyGradientBottom;

		public Action<float, float> _Mirror_SyncVarHookDelegate_skyGradientExponent;

		[Archivable]
		[CreatorProperty]
		public Color SunDiscColor
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
		public float SunDiscMultiplier
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
		public float SunDiscExponent
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
		public Color SunHaloColor
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
		public float SunHaloExponent
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
		public float SunHaloContribution
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
		public Color HorizonLineColor
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
		public float HorizonLineExponent
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
		public float HorizonLineContribution
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
		public Color SkyGradientTop
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
		public Color SkyGradientBottom
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
		public float SkyGradientExponent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color NetworksunDiscColor
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

		public float NetworksunDiscMultiplier
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

		public float NetworksunDiscExponent
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

		public Color NetworksunHaloColor
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

		public float NetworksunHaloExponent
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

		public float NetworksunHaloContribution
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

		public Color NetworkhorizonLineColor
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

		public float NetworkhorizonLineExponent
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

		public float NetworkhorizonLineContribution
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

		public Color NetworkskyGradientTop
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

		public Color NetworkskyGradientBottom
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

		public float NetworkskyGradientExponent
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

		private void OnSunDiscColorChanged(Color oldValue, Color newValue)
		{
		}

		private void OnSunDiscMultiplierChanged(float oldValue, float newValue)
		{
		}

		private void OnSunDiscExponentChanged(float oldValue, float newValue)
		{
		}

		private void OnSunHaloColorChanged(Color oldValue, Color newValue)
		{
		}

		private void OnSunHaloExponentChanged(float oldValue, float newValue)
		{
		}

		private void OnSunHaloContributionChanged(float oldValue, float newValue)
		{
		}

		private void OnHorizonLineColorChanged(Color oldValue, Color newValue)
		{
		}

		private void OnHorizonLineExponentChanged(float oldValue, float newValue)
		{
		}

		private void OnHorizonLineContributionChanged(float oldValue, float newValue)
		{
		}

		private void OnSkyGradientTopChanged(Color oldValue, Color newValue)
		{
		}

		private void OnSkyGradientBottomChanged(Color oldValue, Color newValue)
		{
		}

		private void OnSkyGradientExponentChanged(float oldValue, float newValue)
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
