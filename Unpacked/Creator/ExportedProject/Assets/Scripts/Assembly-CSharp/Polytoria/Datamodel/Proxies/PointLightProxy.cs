using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class PointLightProxy : DynamicInstanceProxy
	{
		private readonly PointLight pointLight;

		public float Range
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

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
		public PointLightProxy(PointLight target)
			: base(null)
		{
		}
	}
}
