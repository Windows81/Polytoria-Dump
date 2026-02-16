using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	public class CoreUIServiceProxy
	{
		private readonly CoreUIService coreUI;

		public bool UserCardEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ChatEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HealthBarEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LeaderboardEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HotbarEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MenuButtonEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CanRespawn
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
		public CoreUIServiceProxy(CoreUIService target)
		{
		}
	}
}
