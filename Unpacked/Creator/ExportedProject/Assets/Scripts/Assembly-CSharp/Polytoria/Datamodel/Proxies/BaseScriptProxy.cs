using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class BaseScriptProxy : InstanceProxy
	{
		private readonly BaseScript baseScript;

		public new object this[string name]
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
		public BaseScriptProxy(BaseScript target)
			: base(null)
		{
		}

		public void Call(string function, params object[] args)
		{
		}
	}
}
