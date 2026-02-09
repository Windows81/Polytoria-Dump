using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class MeshPartProxy : PartProxy
	{
		private readonly MeshPart meshPart;

		public int AssetID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string CurrentAnimation => null;

		public bool IsAnimationPlaying => false;

		public bool PlayAnimationOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CollisionType CollisionType
		{
			get
			{
				return default(CollisionType);
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public MeshPartProxy(MeshPart target)
			: base(null)
		{
		}

		public void PlayAnimation(string animationName, string objectPath, float speed = 1f, bool loop = true)
		{
		}

		public void StopAnimation(string name = null)
		{
		}

		public string[] GetAnimations()
		{
			return null;
		}

		public string[] GetAnimationSources(string animationName)
		{
			return null;
		}

		public AnimationInfo[] GetAnimationInfo()
		{
			return null;
		}
	}
}
