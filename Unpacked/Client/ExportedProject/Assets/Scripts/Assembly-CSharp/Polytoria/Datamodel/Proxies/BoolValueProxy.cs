using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class BoolValueProxy : ValueBaseProxy
	{
		private readonly BoolValue boolValue;

		public bool Value
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
		public BoolValueProxy(BoolValue target)
			: base(null)
		{
		}
	}
}
