using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class ServerHiddenProxy : InstanceProxy
	{
		private readonly ServerHidden serverHidden;

		[MoonSharpHidden]
		public ServerHiddenProxy(ServerHidden target)
			: base(null)
		{
		}
	}
}
