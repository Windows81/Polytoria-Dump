using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies.Services
{
	public class PurchasesServiceProxy
	{
		private readonly PurchasesService purchasesService;

		[MoonSharpHidden]
		public PurchasesServiceProxy(PurchasesService target)
		{
		}

		public void Prompt(Player player, int assetID, DynValue callback)
		{
		}
	}
}
