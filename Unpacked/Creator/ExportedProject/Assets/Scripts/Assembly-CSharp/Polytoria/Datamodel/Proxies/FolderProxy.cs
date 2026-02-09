using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class FolderProxy : InstanceProxy
	{
		private readonly Folder folder;

		[MoonSharpHidden]
		public FolderProxy(Folder target)
			: base(null)
		{
		}
	}
}
