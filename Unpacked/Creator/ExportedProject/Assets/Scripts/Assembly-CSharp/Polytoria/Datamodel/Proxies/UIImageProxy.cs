using MoonSharp.Interpreter;
using Polytoria.Controllers;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class UIImageProxy : UIFieldProxy
	{
		private readonly UIImage uiImage;

		public string ImageID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ImageType ImageType
		{
			get
			{
				return default(ImageType);
			}
			set
			{
			}
		}

		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool Clickable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Loading => false;

		[MoonSharpHidden]
		public UIImageProxy(UIImage target)
			: base(null)
		{
		}
	}
}
