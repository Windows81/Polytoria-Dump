using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class SpotlightProxy : DynamicInstanceProxy
	{
		private readonly Spotlight spotlight;

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

		public float Angle
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
		public SpotlightProxy(Spotlight target)
			: base(null)
		{
		}
	}
}
