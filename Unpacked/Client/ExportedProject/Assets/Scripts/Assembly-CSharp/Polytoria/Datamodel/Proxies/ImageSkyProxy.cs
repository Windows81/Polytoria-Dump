using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class ImageSkyProxy : SkyBaseProxy
	{
		private readonly ImageSky imageSky;

		public int TopId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int BottomId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int LeftId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int RightId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int FrontId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int BackId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public ImageSkyProxy(ImageSky target)
			: base(null)
		{
		}
	}
}
