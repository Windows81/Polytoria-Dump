using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class LightingProxy : InstanceProxy
	{
		private readonly Lighting lighting;

		public float SunBrightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color SunColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color AmbientColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public AmbientSource AmbientSource
		{
			get
			{
				return default(AmbientSource);
			}
			set
			{
			}
		}

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

		[MoonSharpHidden]
		public LightingProxy(Lighting target)
			: base(null)
		{
		}
	}
}
