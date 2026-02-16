using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class InstanceValueProxy : ValueBaseProxy
	{
		private readonly InstanceValue instanceValue;

		public Instance Value
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
		public InstanceValueProxy(InstanceValue target)
			: base(null)
		{
		}
	}
}
