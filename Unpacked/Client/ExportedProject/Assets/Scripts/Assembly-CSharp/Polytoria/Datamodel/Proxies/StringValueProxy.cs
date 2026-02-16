using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class StringValueProxy : ValueBaseProxy
	{
		private readonly StringValue stringValue;

		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public StringValueProxy(StringValue target)
			: base(null)
		{
		}
	}
}
