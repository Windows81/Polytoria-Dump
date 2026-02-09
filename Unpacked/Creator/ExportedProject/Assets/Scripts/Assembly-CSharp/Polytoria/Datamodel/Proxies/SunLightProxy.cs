using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class SunLightProxy : DynamicInstanceProxy
	{
		private readonly SunLight sunLight;

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
		public SunLightProxy(SunLight target)
			: base(null)
		{
		}
	}
}
