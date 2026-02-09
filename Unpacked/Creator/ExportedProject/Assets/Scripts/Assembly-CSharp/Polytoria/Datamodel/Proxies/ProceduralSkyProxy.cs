using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class ProceduralSkyProxy : SkyBaseProxy
	{
		private readonly ProceduralSky proceduralSky;

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

		[MoonSharpHidden]
		public ProceduralSkyProxy(ProceduralSky target)
			: base(null)
		{
		}
	}
}
