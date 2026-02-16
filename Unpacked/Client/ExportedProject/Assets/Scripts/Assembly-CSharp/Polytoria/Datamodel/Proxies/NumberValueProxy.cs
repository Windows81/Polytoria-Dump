using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class NumberValueProxy : ValueBaseProxy
	{
		private readonly NumberValue numberValue;

		public float Value
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
		public NumberValueProxy(NumberValue target)
			: base(null)
		{
		}
	}
}
