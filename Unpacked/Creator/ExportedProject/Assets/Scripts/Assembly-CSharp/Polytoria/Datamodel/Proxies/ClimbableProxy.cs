using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class ClimbableProxy : PartProxy
	{
		private readonly Climbable climbable;

		public float ClimbSpeed
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
		public ClimbableProxy(Climbable target)
			: base(null)
		{
		}
	}
}
