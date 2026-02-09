using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class ColorValueProxy : ValueBaseProxy
	{
		private readonly ColorValue colorValue;

		public Color Value
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public ColorValueProxy(ColorValue target)
			: base(null)
		{
		}
	}
}
