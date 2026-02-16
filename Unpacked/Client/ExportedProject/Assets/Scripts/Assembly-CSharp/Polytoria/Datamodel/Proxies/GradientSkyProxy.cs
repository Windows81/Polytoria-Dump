using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class GradientSkyProxy : SkyBaseProxy
	{
		private readonly GradientSky gradientSky;

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

		[MoonSharpHidden]
		public GradientSkyProxy(GradientSky target)
			: base(null)
		{
		}
	}
}
