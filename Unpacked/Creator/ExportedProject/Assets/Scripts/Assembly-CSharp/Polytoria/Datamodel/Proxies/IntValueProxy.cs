using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class IntValueProxy : ValueBaseProxy
	{
		private readonly IntValue intValue;

		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public IntValueProxy(IntValue target)
			: base(null)
		{
		}
	}
}
